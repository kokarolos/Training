using System;
using System.Collections.Generic;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            PizzaStore nyStore = new NYPizzaStore();
            PizzaStore chicagoStore = new ChicagoPizzaStore();
            var p = nyStore.OrderPizza("Cheese");
            var p1 = chicagoStore.OrderPizza("Veggie");
            var p2 = chicagoStore.OrderPizza("Clam");
            var p3 = chicagoStore.OrderPizza("Veggie");

            List<Pizza> pizzas = new List<Pizza>()
            {
                p,
                p1,
                p2,
                p3
            };

            foreach (var pizza in pizzas)
            {
                Console.WriteLine($"{pizza.Name}" +
                    $"{pizza.Sauce.GetType().Name}" +
                    $"{pizza.Dough.GetType().Name}" +
                    $"{pizza.Cheese.GetType().Name}");
            }
        }
    }
}
