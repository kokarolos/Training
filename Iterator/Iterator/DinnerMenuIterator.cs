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
            return _position <= _items.Length && !(_items[_position] is null);
        }

        public object Next()
        {
            var menuItem = _items[_position];
            _position++;
            return menuItem;
        }
    }
}
