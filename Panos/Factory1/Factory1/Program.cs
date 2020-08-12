using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory1
{
    class Program
    {
        static void Main(string[] args)
        {
            PizzaStore NyStore = new NYStylePizzaStore();
            PizzaStore ChiStore = new ChicagoStylePizzaStore();

            
            Pizza pizza = NyStore.OrderPizza(PizzaType.Cheese);
            System.Console.WriteLine($"ethen ordered a {pizza.GetType().Name}");

            Pizza pizza2 = ChiStore.OrderPizza(PizzaType.Veggie);



        }
    }
}
