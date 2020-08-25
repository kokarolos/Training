using System.Collections.Generic;

namespace Iterator
{
    public class PancakeHouseIterator : Iterator
    {
        List<MenuItem> items;
        private int position = 0;

        public PancakeHouseIterator(List<MenuItem>items)
        {
            this.items = items;
        }

        public bool HasNext()
        {
            return position <= items.Count && !(items[position] is null);
        }

        public object Next()
        {
            var menuItem = items[position];
            position++;
            return menuItem;
        }



       
    }


}
