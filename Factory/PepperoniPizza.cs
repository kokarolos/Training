using System;

namespace Factory
{
    public class PepperoniPizza : Pizza
    {
        private IPizzaIngredientFactory _pizzaIngredientFactory;
        public PepperoniPizza(IPizzaIngredientFactory pizzaIngredientFactory)
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
