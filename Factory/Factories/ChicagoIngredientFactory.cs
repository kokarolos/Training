using System.Collections.Generic;

namespace Factory
{
    public class ChicagoIngredientFactory : IPizzaIngredientFactory
    {
        public Cheese CreateCheese()
        {
            return new ParmesanCheese();
        }

        public Clam CreateClam()
        {
            return new FreshClam();
        }

        public Dough CreateDough()
        {
            return new ThickCrustDough();
        }

        public Pepperoni CreatePepperoni()
        {
            return new SlicedPepperoni();
        }

        public Sauce CreateSauce()
        {
            return new PlumTomatoSauce();
        }

        public List<Vegetable> CreateVegetables()
        {
            List<Vegetable> veggies = new List<Vegetable>()
            {
                new Garlic(),
                new Onion(),
                new Mushroom(),
                new RedPepper(),
                new Eggplant(),
                new Garlic()
            };
            return veggies;
        }
    }

}
