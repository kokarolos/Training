using System;
using System.Collections;
using System.Collections.Generic;

namespace Iterator
{
    partial class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<IMenu> menus = new List<IMenu>()
            {
                new PancakeHouseMenu(),
                new DinerMenu(),
                new CafeMenu()
            };
            var waitress = new Waitress(menus);
            waitress.PrintMenu();
        }
    }

    public class CafeMenu : IMenu
    {
        private Hashtable _menuItems;

        public CafeMenu()
        {
            Add("Veggie Burger and Air Fries", "Veggie burger on a whole wheat bun,lettuce,tomato and fries", true, 3.99);
            Add("Soup of the day", "A cip of soup of the day, with a side salad", false, 3.69);
            Add("Burrito", "A large burrito, with whole pinto beans, salsa, guacamole", true, 4.29);
        }

        public void Add(string name, string description, bool vegetarian, double price)
        {
            var menuItem = new MenuItem(name, description, vegetarian, price);
            _menuItems.Add(menuItem.GetName(), menuItem);
        }

        public Iterator CreateIterator()
        {
            return new CafeMenuIterator(_menuItems);
        }

    }

    public class CafeMenuIterator : Iterator
    {
        private Hashtable _menuItems;
        public int _position = 0;

        public CafeMenuIterator(Hashtable menuItems)
        {
            _menuItems = menuItems;
        }

        public bool HasNext()
        {
            return true;
            //return _position <= _menuItems.Count - 1 && _menuItems[]
        }

        public object Next()
        {
            _position++;
            return _menuItems[_position] as CafeMenu;
        }

        public void Remove()
        {
            if (_position <= 0)
            {
                throw new InvalidOperationException("You cant remove an item until you've done at least one next()");
            }
            if (_menuItems[_position] != null)
            {
                for (int i = _position - 1; i < _menuItems.Count - 1; i++)
                {
                    _menuItems[i] = _menuItems[i + 1];
                }
                _menuItems[_menuItems.Count - 1] = null;
            }
        }
    }
}
