using System;

namespace Factory
{
    public class NYPizzaStore : PizzaStore
    {
        public override Pizza CreatePizza(string type)
        {
            switch (type)
            {
                case "cheese":
                    return new NyStyleCheesePizza();
                case "clam":  
                    return new NyStyleClamPizza();
                case "veggie": 
                    return new NyStyleVeggiePizza();
                case "pepperoni":
                    return new NyStylePepperoniPizza();
            }
            throw new InvalidOperationException();
        }
    }
}
