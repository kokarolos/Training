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
<<<<<<< HEAD
            return Beverage.GetDescription() + " " + this.GetType().Name;
=======
            return Beverage.GetDescription() + "Milk" ;
>>>>>>> e123ccebe6330cd2f4e9354ad7523224d75d6888

        }
        public override decimal Cost()  // Compute the cost of the Beverage with our decorator
        {
            return Beverage.Cost() + 0.12m;
        }
    }



}
