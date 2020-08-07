using System;


namespace DucksProject
{
    public class SilentQuack : IQuackable
    {
        public void Quack()
        {
            Console.WriteLine("Cant Quack");
        }
    }
}
