using System;


namespace DucksProject
{
    public class QuackingLoud : IQuackable
    {
        public void Quack()
        {
            Console.WriteLine(GetType().Name);
        }
    }
}
