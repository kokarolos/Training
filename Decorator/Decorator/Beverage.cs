namespace Decorator
{
    public abstract class Beverage
    {
        protected string _description;
        public string Description
        {
            get => _description;
            set => _description = GetType().Name;
        }
        public abstract decimal Cost();
    }
}


