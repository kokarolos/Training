using System;

namespace Factory
{
    public class ClamPizza : Pizza
    {
        private IPizzaIngredientFactory _pizzaIngredientFactory;
        public ClamPizza(IPizzaIngredientFactory pizzaIngredientFactory)
        {
            _pizzaIngredientFactory = pizzaIngredientFactory;
        }

        public override void Prepare()
        {
            Console.WriteLine($"Preparing {GetType().Name}");
            Dough = _pizzaIngredientFactory.CreateDough();
            Clam = _pizzaIngredientFactory.CreateClam();
            Cheese = _pizzaIngredientFactory.CreateCheese();
        }
    }

}
