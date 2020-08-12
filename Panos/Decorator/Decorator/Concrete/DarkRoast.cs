namespace Decorator
{
    public class DarkRoast : Beverage
    {
        public DarkRoast()
        {
            description = "DarkRoast";
        }
        public override decimal Cost()
        {
            return 0.40m;
        }
    }
}
