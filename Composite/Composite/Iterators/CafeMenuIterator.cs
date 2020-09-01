using System.Collections.Generic;

namespace Composite
{
    public class CafeMenuIterator : Iterator
    {
        private List<MenuItem> _menuItems;
        private int _index = 0;
        public CafeMenuIterator(List<MenuItem> menuItems)
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