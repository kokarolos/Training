
namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
           
        }
    }
    public abstract class Pizza
    {
    }

    public class CheesePizza : Pizza
    {

    }
    public class PepperoniPizza : Pizza
    {

    }
    public class ClamPizza : Pizza
    {

    }
    public class VeggiePizza : Pizza
    {

    }
    public class PizzaFactory
    {
        public Pizza CreatePizza(string type)
        {
            return new VeggiePizza();
        }
    }
    public abstract class PizzaStore
    {
        private PizzaFactory _pizzaFactory;
        public PizzaStore(PizzaFactory pizzaFactory)
        {
            _pizzaFactory = pizzaFactory;
        }
        public Pizza OrderPizza(string type)
        {
            Pizza p = _pizzaFactory.CreatePizza(type);
            return p;
        }

        public abstract Pizza CreatePizza(string type);
    }
    public class ChicagoPizzaFactory : PizzaFactory
    {

    }
    public class NYPizzaFactory : PizzaFactory
    {

    }
}
