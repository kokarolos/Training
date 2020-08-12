
namespace Decorator
{
    public class HouseBlend : Beverage
    {
        public HouseBlend()
        {
           _description = "HouseBlend, ";
        }
        public override decimal Cost()
        {
            return 6.52M;
        }

        public override string GetDescription()
        {
            return _description;
        }
    }
}

