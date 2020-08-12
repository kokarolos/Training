namespace Decorator
{

    // Moka is a decorator , so we extend CondimentDecorator


    public class Mocka : CondimentDecorator // CondimentDecorator extends Beverage.
    {
        Beverage Beverage; // Instance var to hold the Beverage wrapping

        public Mocka(Beverage beverage)
        {
            this.Beverage = beverage;
        }

        public override string GetDescription()
        {
            return Beverage.GetDescription() + "Mocka" ;
        }
        public override decimal Cost()  // Compute the cost of the Beverage with our decorator
        {
            
            return Beverage.Cost() + 0.30m;
        }

    }
}
