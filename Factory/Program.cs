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

}
