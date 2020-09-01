using System.Collections.Generic;

namespace Composite
{
    public class PancakeHouseMenu : IMenu
    {
        private static int _maxItems = 6;
        private int _numberOfItems = 0;
        private List<MenuItem> _menuItems;

        public PancakeHouseMenu()
        {
            Add("Vegetarian BLT", "(Fakin') Bacon with lettuce & tomato on whole wheat", true, 2.99M);
            Add("BLT", "Bacon with lettuce & tomato on whole wheat", false, 2.99M);
            Add("Soup of the day", "Soup of the day with a side of potato salad", false, 3.29M);
            Add("HotDog", "A hot dog with saurkraut,relish,onions,topped with cheese", false, 3.05M);
        }
        public void Add(string name, string description, bool isVegetarian, decimal price)
        {
            var item = new MenuItem(name, description, isVegetarian, price);
            _menuItems.Add(item);
        }

        public Iterator CreateIterator()
        {
            return new PancakeHouseMenuIterator(_menuItems);
        }
    }
}