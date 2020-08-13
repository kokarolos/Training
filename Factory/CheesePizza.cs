using System;

namespace Factory
{
    public class CheesePizza : Pizza
    {
        private IPizzaIngredientFactory _pizzaIngredientFactory;
        public CheesePizza(IPizzaIngredientFactory pizzaIngredientFactory)
        {
            _pizzaIngredientFactory = pizzaIngredientFactory;
        }

        public override void Prepare()
        {
            Console.WriteLine($"Preparing {GetType().Name}");
            Dough = _pizzaIngredientFactory.CreateDough();
            Cheese = _pizzaIngredientFactory.CreateCheese();
            Veggies = _pizzaIngredientFactory.CreateVegetables();
            Dough = _pizzaIngredientFactory.CreateDough();
        }
    }
}
