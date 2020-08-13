using System.Collections.Generic;

namespace Factory
{
    public class NYPizzaIngredientFactory : IPizzaIngredientFactory
    {
        public Cheese CreateCheese()
        {
            return new ReggianoCheese();
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
            return new MarinaraSauce();
        }

        public List<Vegetable> CreateVegetables()
        {
            List<Vegetable> veggies = new List<Vegetable>()
            {
                new Garlic(),
                new Onion(),
                new Mushroom(),
                new RedPepper()
            };
            return veggies;
        }
    }

}
