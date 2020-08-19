using System;

namespace Adapter
{
    public class MalarDuck : IDuck
    {
        public void Fly()
        {
            Console.WriteLine("I am Flying");
        }
        public void Quack()
        {
            Console.WriteLine("Quack");
        }
    }
}
