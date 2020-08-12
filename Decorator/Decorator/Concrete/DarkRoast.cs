namespace Decorator
{
    public class DarkRoast : Beverage
    {
        public override decimal Cost()
        {
            return 3.25M;
        }

        public override string GetDescription()
        {
            return "DarkRoast, ";
        }
    }
}
