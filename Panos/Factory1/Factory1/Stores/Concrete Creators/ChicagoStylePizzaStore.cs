using System.CodeDom;

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
