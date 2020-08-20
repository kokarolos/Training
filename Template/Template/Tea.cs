using System;

namespace Template
{
    public class Tea : CaffeineBeverage
    {
        public override void AddCondiment()
        {
            Console.WriteLine("Adding the lemon");
        }

        public override void Brew()
        {
            Console.WriteLine("Steeping the tea");
        }
    }
}
