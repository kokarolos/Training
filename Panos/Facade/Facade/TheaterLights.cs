using System;

namespace Facade
{
    public class TheaterLights
    {
        public void Dim(int v)
        {
            Console.WriteLine($"Dim Theaterlights {v}");
        }

        public void On()
        {
            Console.WriteLine($"theaterLights On");
        }
    }
}