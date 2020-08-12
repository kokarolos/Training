namespace Decorator
{
    public abstract class Beverage
    {
        protected string _description;
        public abstract string GetDescription();

        public abstract decimal Cost();
    }
}


