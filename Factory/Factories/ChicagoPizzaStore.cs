using System;

namespace Factory
{
    public class ChicagoPizzaStore : PizzaStore
    {
        private ChicagoIngredientFactory _chicagoIgredientFactory = new ChicagoIngredientFactory();
        public override Pizza CreatePizza(string type)
        {
            switch (type)
            {
                case "cheese":
                        return new CheesePizza(_chicagoIgredientFactory);
                case "clam":
                    return new ClamPizza(_chicagoIgredientFactory);
                case "veggie":
                    return new VeggiePizza(_chicagoIgredientFactory);
                case "pepperoni":
                    return new PepperoniPizza(_chicagoIgredientFactory);
            }
            throw new InvalidOperationException();
        }
    }

}
