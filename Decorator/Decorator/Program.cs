using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Beverage beverage = new HouseBlend();
            beverage = new Milk(beverage);
            beverage = new Whip(beverage);
            beverage = new Whip(beverage);
            beverage = new Whip(beverage);
            beverage = new Whip(beverage);
            beverage = new Mocha(beverage);
            beverage = new Soy(beverage);
            Console.WriteLine($"{beverage.GetDescription()} {beverage.Cost()}");
        }
    }
}


