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
            return _position <= _menuItems.Count && !(_menuItems[_position] is null);
        }

        public object Next()
        {
            var menuItem = _menuItems[_position];
            _position++;
            return menuItem;
        }
    }
}
