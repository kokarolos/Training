using System;
using System.Collections.Generic;

namespace Composite
{
    public class CafeMenu : MenuComponent
    {
        private List<MenuItem> _menuItems = new List<MenuItem>();
        public CafeMenu()
        {
            Add("Veggie Burger and Air Fries", "Veggie burger on a whole wheat bun, lettuce, tomato, and fries", true, 3.99M);
            Add("Soup of the day", "A cup of the soup of the day, with a side salad", false, 3.69M);
            Add("Burrito", "A large burrito, with whole pinto beans, salsa, guacamole", true, 4.29M);
        }
        public void Add(string name,string description,bool isVegetarian,decimal price)
        {
            var item = new MenuItem(name, description, isVegetarian, price);
            _menuItems.Add(item);
        }

        public override void Add(MenuComponent menuComponent)
        {
            throw new NotImplementedException();
        }

        public override Iterator CreateIterator()
        {
            return new CafeMenuIterator(_menuItems);
        }

        public override MenuComponent GetChild(int i)
        {
            throw new NotImplementedException();
        }

        public override void Print()
        {
            throw new NotImplementedException();
        }

        public override void Remove(MenuComponent menuComponent)
        {
            throw new NotImplementedException();
        }
    }
}