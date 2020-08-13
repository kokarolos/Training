
﻿namespace Factory1
{
    public class ChicagoStylePizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string type)
        {
            Pizza pizza = null;

            if (type.Equals("Cheese")) { pizza = new CHICheesePizza(); }
            else if (type.Equals("Peperoni")) { pizza = new CHIPepperoniPizza(); }
            else if (type.Equals("Clam")) { pizza = new CHIClamPizza(); }
            else if (type.Equals("Veggie")) { pizza = new CHIVeggiePizza(); }
            return pizza;
        }
    }

namespace Factory1
{
    public class ChicagoStylePizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(PizzaType type)
        {
            switch (type) 
            {
                case PizzaType.Cheese:
                    return new CHICheesePizza();
                case PizzaType.Clam:
                    return new CHIClamPizza();
                case PizzaType.Peperoni:
                    return new CHIPepperoniPizza();
                case PizzaType.Veggie:
                    return new CHIVeggiePizza();
            }

            throw new System.InvalidOperationException();
        }
    }
}
