using System;

namespace Decorator
{
    public class Mocha : BeverageDecorator
    {
        private Beverage _beverage;

        public Mocha(Beverage beverage)
        {
            _beverage = beverage;
            Console.WriteLine($"{GetDescription()} added");
        }

        public override decimal Cost()
        {
            return _beverage.Cost() + 0.22M;
        }
    }
}


