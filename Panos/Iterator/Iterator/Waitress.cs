using System;
using System.Collections.Generic;

namespace Iterator
{
    public class Waitor
    {
        List<Menu> menus;

        public Waitor(List<Menu> menus)
        {
            this.menus = menus;
        }

        public void PrintMenu()
        {
            // HAVE TO FIX THAT IMPLEMENTATION

            ////Iterator menuIterator = menus
            //while (menuIterator.HasNext())
            //{
            //    Menu menu = (Menu)menuIterator.Next();
            //    PrintMenu(menu.CreateIterator());
            //}
        }

        private void PrintMenu(Iterator iterator)
        {
            while (iterator.HasNext())
            {
                MenuItem menuItem = (MenuItem)iterator.Next();
                Console.WriteLine(menuItem.GetName() + ", ");
                Console.WriteLine(menuItem.GetPrice() + " -- ");
                Console.WriteLine(menuItem.GetDescription());
            }
        }
    }
}
