﻿using System.Collections.Generic;
using System;

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
            if (position >= items.Count || items[position] == null)
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
            var menuItem = items[position];
            position++;
            return menuItem;
        }

        public void Remove()
        {
            if (position <= 0)
            {
                throw new Exception("You cant remove an item until you 've done at least one next()");
            }
            if (items[position - 1] != null)
            {
                for (int i = position - 1; i < (items.Count - 1); i++)
                {
                    items[i] = items[i + 1];
                }
                items[items.Count - 1] = null;
            }
        }
    }
}
