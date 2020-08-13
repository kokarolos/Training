namespace Decorator
{
    public class Decaf : Beverage
    {
        public Decaf()
        {
            description = "Decafeine";
        }
        public override decimal Cost()
        {
            return 0.90m;
        }
    }
}
