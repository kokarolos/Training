namespace Decorator
{
    public class Whip : CondimentDecorator
    {
        Beverage Beverage; // Instance var to hold the Beverage wrapping

        public Whip(Beverage beverage)
        {
            this.Beverage = beverage;
        }

        public override string GetDescription()
        {
            return Beverage.GetDescription() + " " + GetType().Name;

        }
        public override decimal Cost()  // Compute the cost of the Beverage with our decorator
        {
            return Beverage.Cost() + 0.56m;
        }
    }



}
