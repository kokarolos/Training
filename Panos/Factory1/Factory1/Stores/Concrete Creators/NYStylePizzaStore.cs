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
        }
    }


}
