using System;

namespace Iterator
{
    public class DinerMenu 
    {
        static readonly int MaxItems = 6;
        int numberOfItems = 0;
        MenuItem[] menuItems;

        public DinerMenu()
        {
            menuItems = new MenuItem[MaxItems];

            AddItem("Vegetaarian BLT", "Bacon,Tomato", true, 2.99);
            AddItem("BLT", "Bacon and Green", false, 2.99);
            AddItem("Soup", "With Potato salad", false, 2.99);
            AddItem(" ELT", "Tomato", false, 2.99);
            AddItem("Vege FLT", "Tomato", false, 2.99);

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
            return new DinerMenuIterator(menuItems);
        }
    }
}
