
namespace Factory
{
    public class VeggiePizza : Pizza
    {
        public VeggiePizza(IPizzaIngredientFactory pizzaIngredientFactory) 
            : base(pizzaIngredientFactory)
        {
        }
    }
}