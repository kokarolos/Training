namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            PizzaStore nyStore = new NYPizzaStore();
            PizzaStore chicagoStore = new ChicagoPizzaStore();
            nyStore.OrderPizza("Cheese");
            chicagoStore.OrderPizza("Veggie");
            chicagoStore.OrderPizza("Clam");
            chicagoStore.OrderPizza("Veggie");
        }
    }

    public abstract class Clam
    {

    }
    public class FreshClam : Clam
    {

    }
    public abstract class Dough
    {

    }
    public class ThickCrustDough : Dough
    {

    }
    public class ThinCrustDough : Dough { }
    public abstract class Sauce
    {

    }
    public class MarinaraSauce : Sauce
    {

    }
    public class PlumTomatoSauce : Sauce
    {

    }
    public abstract class Cheese
    {

    }
    public class MozzarellaCheese : Cheese
    {

    }
    public class ReggianoCheese : Cheese
    {

    }
    public class ParmesanCheese : Cheese
    {

    }
    public abstract class Vegetable
    { }
    public class BlackOlive : Vegetable
    {

    }
    public class Spinach : Vegetable
    {

    }
    public class Mushroom : Vegetable { }
    public class Eggplant : Vegetable
    {

    }
    public class RedPepper : Vegetable
    {

    }
    public class Onion : Vegetable
    {

    }
    public abstract class Pepperoni
    {

    }
    public class Garlic : Vegetable
    {

    }
    public class SlicedPepperoni : Pepperoni
    {

    }

}
