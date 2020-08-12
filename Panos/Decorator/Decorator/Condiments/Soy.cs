namespace Decorator
{
    public class Soy : CondimentDecorator
    {
        Beverage Beverage; // Instance var to hold the Beverage wrapping
<<<<<<< HEAD
=======
        
>>>>>>> e123ccebe6330cd2f4e9354ad7523224d75d6888

        public Soy(Beverage beverage)
        {
            this.Beverage = beverage;
        }

        public override string GetDescription()
        {
            return Beverage.GetDescription() + " " + GetType().Name;
        }

        public override decimal Cost()  // Compute the cost of the Beverage with our decorator
        {
            return Beverage.Cost() + 0.30m;
        }
    }



}
