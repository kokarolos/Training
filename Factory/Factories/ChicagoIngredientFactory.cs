using System.Collections.Generic;

namespace Factory
{
    public class ChicagoIngredientFactory : IPizzaIngredientFactory
    {
        public ICheese CreateCheese()
        {
            return new ParmesanCheese();
        }

        public IClam CreateClam()
        {
            return new FreshClam();
        }

        public IDough CreateDough()
        {
            return new ThickCrustDough();
        }

        public IPepperoni CreatePepperoni()
        {
            return new SlicedPepperoni();
        }

        public ISauce CreateSauce()
        {
            return new PlumTomatoSauce();
        }

        public List<IVegetable> CreateVegetables()
        {
            List<IVegetable> veggies = new List<IVegetable>()
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
