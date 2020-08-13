using System;

namespace Factory
{
    public class NYPizzaStore : PizzaStore
    {
        private NYPizzaIngredientFactory _nyPizzaIngredientFactory = new NYPizzaIngredientFactory();
        public override Pizza CreatePizza(string type)
        {
            switch (type)
            {
                case "cheese":
                    return new CheesePizza(_nyPizzaIngredientFactory);
                case "clam":  
                    return new ClamPizza(_nyPizzaIngredientFactory);
                case "veggie": 
                    return new VeggiePizza(_nyPizzaIngredientFactory);
                case "pepperoni":
                    return new PepperoniPizza(_nyPizzaIngredientFactory);
            }
            throw new InvalidOperationException();
        }
    }
}
