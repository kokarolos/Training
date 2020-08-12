
namespace Decorator
{
    public class Decaf : Beverage
    {
        public override decimal Cost()
        {
            return 2.79M;
        }

        public override string GetDescription()
        {
            return "Decaf, ";
        }
    }
}


