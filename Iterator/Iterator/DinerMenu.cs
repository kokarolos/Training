namespace Iterator
{
    public class DinerMenu
    {
        private static int _maxItems = 6;
        private int _numberOfItems = 0;
        private MenuItem[] _menuItems;

        public DinerMenu()
        {

        }
        public Iterator CreateIterator()
        {
            return new DinnerMenuIterator(_menuItems);
        }
    }
}
