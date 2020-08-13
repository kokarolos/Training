using Factory1.IngredientFactory;
using Factory1.Pizzas;
namespace Factory1
{
    public class ChicagoStylePizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(PizzaType type)
        {
            PizzaIngredientFactory pizzaIngredientFactory = new ChicagoPizzaingredientsFactory();
            switch (type)
            {
                case PizzaType.Cheese:
                    return new CheesePizza(pizzaIngredientFactory);
                case PizzaType.Clam:
                    return new ClamPizza(pizzaIngredientFactory);
                case PizzaType.Peperoni:
                    return new PepperoniPizza(pizzaIngredientFactory);
                case PizzaType.Veggie:
                    return new VeggiePizza(pizzaIngredientFactory);
            }

            throw new System.InvalidOperationException();
        }
    }
}
