namespace Decorator
{
    public class DarkRoast : Beverage
    {
        public DarkRoast()
        {
            Description = GetType().Name; 
        }
        public override decimal Cost()
        {
            return 0.40m;
        }
    }
}
