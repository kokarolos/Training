using System;

namespace DesignPatterns
{
    class FlyNoWay : IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("Duck can't Fly");
        }
    }


}
