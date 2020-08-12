namespace Decorator
{
    public class HouseBlend : Beverage
    {
        public HouseBlend()
        {
<<<<<<< HEAD
            Description = GetType().Name; 
        }

=======
            description = GetType().Name;
        }
>>>>>>> e123ccebe6330cd2f4e9354ad7523224d75d6888
        public override decimal Cost()  // Return the price of HouseBlend without any Condiment.
        {
            return 0.70m;  
        }
    }
}
