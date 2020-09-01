using System;

namespace Composite
{
    public class DinerMenu : IMenu
    {
        private static int _maxItems = 6;
        private int _numberOfItems = 0;
        MenuItem[] _menuItems;

        public DinerMenu()
        {
            Add("Vegetarian BLT", "(Fakin') Bacon with lettuce & tomato on whole wheat", true, 2.99M);
            Add("BLT", "Bacon with lettuce & tomato on whole wheat", false, 2.99M);
            Add("Soup of the day", "Soup of the day with a side of potato salad", false, 3.29M);
            Add("HotDog", "A hot dog with saurkraut,relish,onions,topped with cheese", false, 3.05M);
        }

        public void Add(string name, string description, bool isVegetarian, decimal price)
        {
            var item = new MenuItem(name, description, isVegetarian, price);
            if (_numberOfItems >= _maxItems)
            {
                Console.WriteLine("Menu is fulled");
            }
            else
            {
                _menuItems[_numberOfItems] = item;
                _numberOfItems++;
            }
        }
        public Iterator CreateIterator()
        {
            return new DinerMenuIterator(_menuItems);
        }
    }
}