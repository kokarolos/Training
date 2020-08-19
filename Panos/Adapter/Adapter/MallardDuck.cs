using System;

namespace Adapter
{
    public class MallardDuck : Duck
    {
        public void Fly()
        {
            Console.WriteLine("Quack");
        }
        public void Quack()
        {
            Console.WriteLine("Im flying");
        }
    }
}
