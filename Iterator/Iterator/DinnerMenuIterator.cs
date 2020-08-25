namespace Iterator
{
    public class DinnerMenuIterator : Iterator
    {
        private MenuItem[] _items;
        private int _position = 0;

        public DinnerMenuIterator(MenuItem[] items)
        {
            _items = items;
        }

        public bool HasNext()
        {
            return _position >= _items.Length || _items[_position] == null;
        }

        public object Next()
        {
            MenuItem menuItem = _items[_position];
            _position++;
            return menuItem;
        }
    }
}
