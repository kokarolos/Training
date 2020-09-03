using System.Collections;
using System;

namespace Iterator
{
    public class CafeMenu : Menu
    {

        static readonly int MaxItems = 6;
        int numberOfItems = 0;
        MenuItem[] menuItems;

        public CafeMenu()
        {

            menuItems = new MenuItem[MaxItems];

            AddItem("Veggie Burger and Air Fries", "Veggie Burger on Wholewheat bun ,lettuce,tomato, and fries", true, 3.99);
            AddItem("Soup of the day", "a cup of the soup of the day, with a side salad", false, 3.69);
            AddItem("Burrito", "A large Burrito, with whole pinto beans, salsa, quacamole", true, 429);
        }

        public void AddItem(string name, string description, bool vegeterian, double price)
        {
            MenuItem menuItem = new MenuItem(name, description, vegeterian, price);
            if (numberOfItems >= MaxItems) Console.WriteLine("Sorry menu is full");
            else
            {
                menuItems[numberOfItems] = menuItem;
                numberOfItems++;
            }
        }

        public Iterator CreateIterator()
        {
            return new CoffeeMenuIterator(menuItems);
        }
    }
}
