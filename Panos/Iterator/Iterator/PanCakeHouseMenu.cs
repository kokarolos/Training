using System.Collections.Generic;

namespace Iterator
{
    public class PanCakeHouseMenu :Menu
    {
        List<MenuItem> menuItems;

        public PanCakeHouseMenu()
        {
            menuItems = new List<MenuItem>();
            AddItem("K&B's Pancake breakfast", "Pancakes with scrumbled eggs and toast", true, 2.99);
            AddItem("Regular Pancake breakfast", "Pancakes with fried eggs and sausage", false, 2.99);
            AddItem("Blueberry Pancakes", "Pancakes with blueberries", false, 3.49);
            AddItem("Waffles Pancakes", "Waffles with your choice", true, 3.59);
        }
        public void AddItem(string name, string description, bool vegetarian, double price)
        {
            MenuItem menuItem = new MenuItem(name, description, vegetarian, price);
            menuItems.Add(menuItem);
        }
        
        public Iterator CreateIterator()
        {
            return new PancakeHouseIterator(menuItems);
        }
    }
}
