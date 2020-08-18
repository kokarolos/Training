using System;

namespace Command
{
    public class Hottub : ISwitchable
    {
        public void Off()
        {
            Console.WriteLine("Hottub turned off");
        }

        public void On()
        {
            Console.WriteLine("Hottub turned on");
        }
    }
}
