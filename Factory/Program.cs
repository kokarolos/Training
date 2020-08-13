namespace Factory
{
    class Program
    {
        //Abstract Factory Pattern Implementation example
        static void Main(string[] args)
        {
            PizzaStore nyStore = new NYPizzaStore();
            PizzaStore chicagoStore = new ChicagoPizzaStore();
            var p = nyStore.OrderPizza("Cheese");
            var p1 = chicagoStore.OrderPizza("Veggie");
            var p2 = chicagoStore.OrderPizza("Clam");
            var p3 = chicagoStore.OrderPizza("Veggie");
        }
    }
}
