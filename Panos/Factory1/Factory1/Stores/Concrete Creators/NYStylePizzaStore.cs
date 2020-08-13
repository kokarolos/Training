namespace Factory1
{
    public class NYStylePizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string type)
        {
            Pizza pizza = null;

            if (type.Equals("Cheese")) { pizza = new NYCheesePizza(); }
            else if (type.Equals("Peperoni")) { pizza = new NYPepperoniPizza(); }
            else if (type.Equals("Clam")) { pizza = new NYClamPizza(); }
            else if (type.Equals("Veggie")) { pizza = new NYVeggiePizza(); }
            return pizza;
            
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
