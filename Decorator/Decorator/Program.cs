using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Beverage beverage = new Espresso();
            beverage = new Milk(beverage);
            beverage = new Whip(beverage);
            beverage = new Whip(beverage);
            Console.WriteLine(beverage.Cost());
        }
    }
}


