using System;

namespace Template
{
    public class Coffee : CaffeineBeverage
    {
        public override void AddCondiment()
        {
            Console.WriteLine("Adding Sugar and Milk");
        }

        public override void Brew()
        {
            Console.WriteLine("Dripping Coffee through filter");
        }
    }
}
