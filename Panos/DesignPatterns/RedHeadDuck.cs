using System;

namespace DesignPatterns
{
    class RedHeadDuck : Duck,IFlyable,IQuackable
    {

        public void Fly()
        {

            Console.WriteLine("I can fly");
        }

        public void Quackk()
        {
            Console.WriteLine("I can quack");
        }
    }

}
