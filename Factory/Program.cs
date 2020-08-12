namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            PizzaStore nyStore = new NYPizzaStore();
            PizzaStore chicagoStore = new ChicagoPizzaStore();
            nyStore.OrderPizza(typeof(NyStyleClamPizza));
            chicagoStore.OrderPizza(typeof(NyStyleVeggiePizza));
            chicagoStore.OrderPizza(typeof(NyStylePepperoniPizza));
            chicagoStore.OrderPizza(typeof(NyStylePepperoniPizza));
        }
    }
}
