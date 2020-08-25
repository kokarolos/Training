namespace Iterator
{
    public class DinerMenu
    {
        private static int _maxItems = 6;
        private int _numberOfItems = 0;
        private MenuItem[] _menuItems;

        public DinerMenu()
        {
            _menuItems = new MenuItem[_maxItems];
            AddItem("Vegeterian BLT", "(Fakin') Bacon with lettuce and tomato on whole wheat", true, 2.99);
            AddItem("BLT", "Bacon with lettuce tomato on whole wheat", false, 2.99);
            AddItem("Soup of the day", "Soup of the day with a side of potato salada", false, 3.29);
            AddItem("HotDog", "A hot dog,with saurkraut, relish, onions, topped with cheese", false, 3.05);
        }

        public void AddItem(string name,string description,bool vegeterian,double price)
        {
            var menuItem = new MenuItem(name, description, vegeterian, price);
            if(_numberOfItems >= _maxItems)
            {
                System.Console.WriteLine("Sorry Menu is full! Can't add item to menu");
            }
            else
            {
                _menuItems[_numberOfItems] = menuItem;
                _numberOfItems++;
            }
        }
        public Iterator CreateIterator()
        {
            return new DinnerMenuIterator(_menuItems);
        }
    }
}
