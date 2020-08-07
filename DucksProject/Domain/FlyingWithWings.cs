using System;


namespace DucksProject
{
    public class FlyingWithWings : IFlyable
    {
        public void Fly()
        {
            Console.WriteLine(GetType().Name);
        }
    }
}
