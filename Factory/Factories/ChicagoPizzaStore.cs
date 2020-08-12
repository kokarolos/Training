using System;

namespace Factory
{
    public class ChicagoPizzaStore : PizzaStore
    {

        public override Pizza CreatePizza(string type)
        {
            switch (type)
            {
                case "cheese":
                        return new ChicagoStyleCheesePizza();
                case "clam":
                    return new ChicagoStyleClamPizza();
                case "veggie":
                    return new ChicagoStyleVeggiePizza();
                case "pepperoni":
                    return new ChicagoStylePepperoniPizza();
            }
            throw new InvalidOperationException();
        }
    }

}
