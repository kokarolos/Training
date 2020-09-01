namespace Composite
{
    public class Waitress
    {
        private MenuComponent _allMenus;
        public Waitress(MenuComponent allMenus)
        {
            _allMenus = allMenus;
        }
        public void Print()
        {
            _allMenus.Print();
        }
    }
}