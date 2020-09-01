namespace Composite
{
    public class DinerMenuIterator : Iterator
    {
        private MenuItem[] _menuItems;
        private int _index = 0;
        public DinerMenuIterator(MenuItem[] menuItems)
        {
            _menuItems = menuItems;
        }

        public bool HasNext()
        {
            return _index >= _menuItems.Length - 1 || !(_menuItems[_index] is null);
        }

        public object Next()
        {
            var item = _menuItems[_index];
            _index++;
            return item;
        }
    }
}