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
<<<<<<< HEAD
            return Beverage.GetDescription() +" "+ "Mocka" ;
=======
            return Beverage.GetDescription() + "Mocka" ;
>>>>>>> e123ccebe6330cd2f4e9354ad7523224d75d6888

        }
        public override decimal Cost()  // Compute the cost of the Beverage with our decorator
        {
            
            return Beverage.Cost() + 0.30m;
        }

    }
}
