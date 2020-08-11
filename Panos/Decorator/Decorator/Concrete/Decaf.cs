namespace Decorator
{
    public class Decaf : Beverage
    {
        public Decaf()
        {
            Description = "Decaf"; 
        }
        public override decimal Cost()
        {
            return 0.90m;
        }
    }
}
