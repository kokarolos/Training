namespace Composite
{
    public abstract class MenuComponent
    {
        protected string _description;
        protected string _name;
        protected bool _isVegetarian;
        protected decimal _price;

        public abstract void Add(MenuComponent menuComponent);
        public abstract void Remove(MenuComponent menuComponent);
        public abstract MenuComponent GetChild(int i);
        public abstract void Print();
        public abstract Iterator CreateIterator();
    }
}