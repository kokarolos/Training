﻿using System;

namespace Iterator
{
    public class Waitress
    {
        private PancakeHouseMenu _pancakeHouseMenu;
        private DinerMenu _dinerMenu;

        public Waitress(PancakeHouseMenu pancakeHouseMenu, DinerMenu dinerMenu)
        {
            _pancakeHouseMenu = pancakeHouseMenu;
            _dinerMenu = dinerMenu;
        }
        public void PrintMenu()
        {
            Iterator pancakeIterator = _pancakeHouseMenu.CreateIterator();
            Iterator dinerIterator = _dinerMenu.CreateIterator();
            Console.WriteLine("Menu\n----------\nBreakfast");
            PrintMenu(pancakeIterator);
            Console.WriteLine("\nLunch");
            PrintMenu(pancakeIterator);
        }
        private void PrintMenu(Iterator iterator)
        {
            while (iterator.HasNext())
            {
                MenuItem menuItem = (MenuItem)iterator.Next();
                Console.WriteLine($"{menuItem.GetName()}");
                Console.WriteLine($"{menuItem.GetPrice()}");
                Console.WriteLine($"{menuItem.GetDescription()}");
            }
        }
    }
}
