namespace Factory
{
    public class PepperoniPizza : Pizza
    {
        public PepperoniPizza(IPizzaIngredientFactory pizzaIngredientFactory) :
            base(pizzaIngredientFactory)
        {
        }
    }

}
