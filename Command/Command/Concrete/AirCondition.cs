using System;

namespace Command
{
    public class AirCondition : ISwitchable
    {
        public void On()
        {
            Console.WriteLine($"Ac On");
        }

        public void Off()
        {
            Console.WriteLine($"Ac Off");
        }
    }
}
