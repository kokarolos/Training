namespace Decorator
{
    public class Espresso : Beverage //We extend the beverage class since tthis i a beverage
    {
        public Espresso()
        {
            this.Description = "Espresso";
        }

        public override decimal Cost()
        {
            return 0.80m;
        }
    }



}
