using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
<<<<<<< HEAD
            Beverage beverage2 = new HouseBlend();
            Console.WriteLine(beverage2.GetDescription() + " " + beverage2.Cost());

=======
            Beverage beverage2 = new Espresso();
>>>>>>> e123ccebe6330cd2f4e9354ad7523224d75d6888
            beverage2 = new Mocka(beverage2);

            Console.WriteLine(beverage2.GetDescription() + " " + beverage2.Cost()); 
        }
    }
}
