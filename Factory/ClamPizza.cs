using System;

namespace Factory
{
    public class ClamPizza : Pizza
    {
        public ClamPizza(IPizzaIngredientFactory pizzaIngredientFactory) :
            base(pizzaIngredientFactory)
        {
        }
    }

}
