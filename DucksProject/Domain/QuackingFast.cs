using System;


namespace DucksProject
{
    public class QuackingFast : IQuackable
    {
        public void Quack()
        {
            Console.WriteLine(GetType().Name);
        }
    }
}
