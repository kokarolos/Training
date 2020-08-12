namespace Decorator
{
    public class Mocha : BeverageDecorator
    {
        private Beverage _beverage;

        public Mocha(Beverage beverage)
        {
            _beverage = beverage;
            _description = "Mocha ";
        }
        public override decimal Cost()
        {
            return _beverage.Cost() + 0.22M;
        }
        public override string GetDescription()
        {
            return _beverage.GetDescription() + _description;
        }
    }
}


