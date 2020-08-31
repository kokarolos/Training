using System;
using System.Collections.Generic;

namespace Iterator
{
    public class Waitress
    {
        private IEnumerable<IMenu> _menus; 

        public Waitress(IEnumerable<IMenu> menus)
        {
            _menus = menus;
        }

        public void PrintMenu()
        {
          // Iterator menuIterator = _menus.GetEnumerator();
          // Iterator pancakeIterator = _pancakeHouseMenu.CreateIterator();
          // Iterator dinerIterator = _dinerMenu.CreateIterator();
          // Iterator cafeIterator = _cafeMenu.CreateIterator();
          // Console.WriteLine("Menu\n----------\nBreakfast");
          // PrintMenu(pancakeIterator);
          // Console.WriteLine("\nLunch");
          // PrintMenu(dinerIterator);
          // Console.WriteLine("\nDinner");
          // PrintMenu(cafeIterator);
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
