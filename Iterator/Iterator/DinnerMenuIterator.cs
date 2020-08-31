using System;

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

        public void Remove()
        {
            if (_position <= 0)
            {
                throw new InvalidOperationException("You cant remove an item until you've done at least one next()");
            }
            if (_items[_position] != null)
            {
                for (int i = _position - 1; i < _items.Length - 1; i++)
                {
                    _items[i] = _items[i + 1];
                }
                _items[_items.Length - 1] = null;
            }
        }
    }
}
