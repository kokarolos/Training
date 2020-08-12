namespace Decorator
{
    public class HouseBlend : Beverage
    {
        public HouseBlend()
        {
            description = GetType().Name;
        }
        public override decimal Cost()  // Return the price of HouseBlend without any Condiment.
        {
            return 0.70m;  
        }
    }
}
