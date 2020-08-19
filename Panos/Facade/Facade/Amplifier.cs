using System;

namespace Facade
{
    public class Amplifier
    {
        public void On()
        {
            Console.WriteLine("Amplifier is on");
        }

        public void SetDvd(DvdPlayer dvd)
        {
            Console.WriteLine($"{dvd} is in");
        }

        public void setSurroundSound()
        {
            Console.WriteLine("Sourround Sound is set");
        }

        public void Off()
        {
            Console.WriteLine("Amplifier is Off");
        }
    }
}
