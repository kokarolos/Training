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
            PizzaStore chi = new ChicagoStylePizzaStore();



            NyStore.OrderPizza(PizzaType.Cheese);


            chi.OrderPizza(PizzaType.Cheese);

          

        }
    }
}
