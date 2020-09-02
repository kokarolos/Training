using System;
namespace Iterator
{
    public class DinerMenuIterator : Iterator
    {
        MenuItem[] items;
        int position = 0;

        public DinerMenuIterator(MenuItem[] items)
        {
            this.items = items;
        }


        public bool HasNext()
        {
            if (position >= items.Length || items[position] == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public object Next()
        {
            MenuItem menuItem = items[position];
            position = position + 1;
            return menuItem;
        }

        public void Remove()
        {
            if (position<=0)
            {
                throw new Exception("You cant remove an item until you 've done at least one next()");
            }
            if (items[position - 1] != null) 
            {
                for (int i = position-1; i < (items.Length-1); i++)
                {
                    items[i] = items[i + 1];
                }
                items[items.Length - 1] = null;
            }
        }

    }






}
