using System.Collections.Generic;

namespace Composite
{
    public class PancakeHouseMenu : MenuComponent
    {
        private int _numberOfItems = 0;
        private List<MenuComponent> _menuItems;

        public PancakeHouseMenu()
        {
            _menuItems = new List<MenuComponent>();
            Add("Vegetarian BLT", "(Fakin') Bacon with lettuce & tomato on whole wheat", true, 2.99M);
            Add("BLT", "Bacon with lettuce & tomato on whole wheat", false, 2.99M);
            Add("Soup of the day", "Soup of the day with a side of potato salad", false, 3.29M);
            Add("HotDog", "A hot dog with saurkraut,relish,onions,topped with cheese", false, 3.05M);
        }

        private void Add(string name, string description, bool isVegetarian, decimal price)
        {
            var item = new MenuItem(name, description, isVegetarian, price);
            _menuItems.Add(item);
        }

        public override void Add(MenuComponent menuComponent)
        {
            _menuItems.Add(menuComponent);
        }

        public override MenuComponent GetChild(int i)
        {
            throw new System.NotImplementedException();
        }

        public override void Print()
        {
            throw new System.NotImplementedException();
        }

        public override void Remove(MenuComponent menuComponent)
        {
            throw new System.NotImplementedException();
        }
    }
}