namespace Factory1
{
    public class NYStylePizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(PizzaType type)
        {
            switch (type)
            {
                case PizzaType.Cheese:
                    return new NYCheesePizza();
                case PizzaType.Clam:
                    return new NYClamPizza();
                case PizzaType.Peperoni:
                    return new NYPepperoniPizza();
                case PizzaType.Veggie:
                    return new NYVeggiePizza();
            }

            throw new System.InvalidOperationException();

        }
    }


}
