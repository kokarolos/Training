using System;


namespace DucksProject
{
    public class FlyNoWay : IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("Cant Fly");
        }
    }
}
