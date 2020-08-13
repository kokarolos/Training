using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory1.IngredientFactory
{
    class ChicagoPizzaingredientsFactory : PizzaIngredientFactory
    {
        public Cheese CreateCheese()
        {
            return new Mozzarela();
        }

        public Clams CreateClam()
        {
            return new FrozenClam();

        }

        public Dough CreateDough()
        {
            return new ThinCrustDough();
        }

        public Pepperoni CreatePepperoni()
        {
            return new SlicedPepperoni();
        }

        public Sauce CreateSauce()
        {
            return new PlumtomatoSauce();
        }

        public Veggies[] CreateVeggies()
        {
            Veggies[] veggies = { new BlackOlive(), new Spinach(), new EggPlant() };
            return veggies;
        }
    }
}
