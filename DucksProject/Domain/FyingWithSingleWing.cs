using System;
namespace DucksProject
{
    public class FyingWithSingleWing : IFlyable
    {
        public void Fly()
        {
            Console.WriteLine(GetType().Name);
        }
    }
}
