using System;

namespace Factory
{
    public class VeggiePizza : Pizza
    {
        private IPizzaIngredientFactory _pizzaIngredientFactory;
        public VeggiePizza(IPizzaIngredientFactory pizzaIngredientFactory)
        {
            _pizzaIngredientFactory = pizzaIngredientFactory;
        }

        public override void Prepare()
        {
            Console.WriteLine($"Preparing {GetType().Name}");
            Dough = _pizzaIngredientFactory.CreateDough();
            Clam = _pizzaIngredientFactory.CreateClam();
            Cheese = _pizzaIngredientFactory.CreateCheese();
            Veggies = _pizzaIngredientFactory.CreateVegetables();
            Sauce = _pizzaIngredientFactory.CreateSauce();
        }
    }
}