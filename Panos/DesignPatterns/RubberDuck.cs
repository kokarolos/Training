using System;
namespace DesignPatterns
{
    class RubberDuck : Duck,IQuackable
    {

        public void Quackk()
        {
            Console.WriteLine("I can quack");
        }
    }

}
