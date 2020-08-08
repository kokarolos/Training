using System;

namespace DesignPatterns
{
    class MuteQuack : IQuackable
    {
        public void Quackk()
        {
            Console.WriteLine("Silence");
        }
    }
}
