namespace Decorator
{
    public class Milk:CondimentDecorator
    {
        Beverage Beverage; // Instance var to hold the Beverage wrapping

        public Milk(Beverage beverage)
        {
            this.Beverage = beverage;
        }

        public override string GetDescription()
        {
            return Beverage.GetDescription() + "Milk" ;

        }
        public override decimal Cost()  // Compute the cost of the Beverage with our decorator
        {
            return Beverage.Cost() + 0.12m;
        }
    }



}
