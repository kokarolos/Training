namespace Decorator
{
    public abstract class Beverage
    {
        protected string Description = "Unknown Beverage";


        public string GetDescription()
        {
            return this.description;
        }

        public abstract decimal Cost(); // We have to implement that method is Subclasses
    }
}
