using System.Collections.Generic;

namespace Composite
{
    public class PancakeHouseMenuIterator : Iterator
    {
        private List<MenuComponent> _menuItems;
        private int _index = 0;
        public PancakeHouseMenuIterator(List<MenuComponent> menuItems)
        {
            _menuItems = menuItems;
        }

        public bool HasNext()
        {
            return _index >= _menuItems.Count - 1 || !(_menuItems[_index] is null);
        }

        public object Next()
        {
            var item = _menuItems[_index];
            _index++;
            return item;
        }
    }
}