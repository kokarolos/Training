namespace Decorator
{
    public abstract class Beverage
    {
        protected string _description => GetType().Name;

        public string GetDescription()
        {
            return _description;
        }

        public abstract decimal Cost();
    }
}


