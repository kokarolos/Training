using System.Collections;
using System.Collections.Generic;

namespace Iterator
{
    public class PancakeHouseMenu : IMenu
    {
        private List<MenuItem> _menuItems;
        public PancakeHouseMenu()
        {
            _menuItems = new List<MenuItem>();
            AddItem("K&B's Pancake Breakfast", "Pancakes with srambled eggs, and toast", true, 2.99);
            AddItem("Regular Pancake Breakfast", "Pancakes with fried eggs,sausage", false, 2.99);
            AddItem("Blueburry Pancakes", "Pancakes made with fresh BlueBerries", true, 3.49);
            AddItem("Waffles", "Waffles, with your choice of blueberries or strawberries", true, 3.59);
        }

        public void AddItem(string name,string description,bool vegeterian,double price)
        {
            MenuItem menuItem = new MenuItem(name, description, vegeterian, price);
            _menuItems.Add(menuItem);
        }

        public Iterator CreateIterator()
        {
            return new PancakeHouseIterator(_menuItems);
        }
    }
}
