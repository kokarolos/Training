namespace Factory
{
    public class CheesePizza : Pizza
    {
        public CheesePizza(IPizzaIngredientFactory pizzaIngredientFactory) :
            base(pizzaIngredientFactory)
        {
        }
    }
}
