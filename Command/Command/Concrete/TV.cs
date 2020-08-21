using System;

namespace Command
{
    public class TV : ISwitchable
    {
        public void On()
        {
            Console.WriteLine("Tv turned on");
        }

        public void Off()
        {
            Console.WriteLine("Tv turned off");
        }
    }
}
