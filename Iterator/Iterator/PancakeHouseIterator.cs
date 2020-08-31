using System;
using System.Collections.Generic;

namespace Iterator
{
    public class PancakeHouseIterator : Iterator
    {
        private List<MenuItem> _menuItems;
        private int _position = 0;

        public PancakeHouseIterator(List<MenuItem> items)
        {
            _menuItems = items;
        }

        public bool HasNext()
        {
            return _position <= _menuItems.Count -1 && _menuItems[_position] != null;
        }

        public object Next()
        {
            var menuItem = _menuItems[_position];
            _position++;
            return menuItem;
        }

        public void Remove()
        {
            if (_position <= 0)
            {
                throw new InvalidOperationException("You cant remove an item until you've done at least one next()");
            }
            if (_menuItems[_position] != null)
            {
                for (int i = _position - 1; i < _menuItems.Count - 1; i++)
                {
                    _menuItems[i] = _menuItems[i + 1];
                }
                _menuItems[_menuItems.Count - 1] = null;
            }
        }
    }
}
