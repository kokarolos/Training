using System;

namespace Proxy
{
    public class GumballMonitor
    {
        GumballMachine machine;

        public GumballMonitor(GumballMachine machine)
        {
            this.machine = machine;
        }

        public void Report()
        {
            Console.WriteLine($"Gumball Machine:{machine.GetLocation()}");
            Console.WriteLine($"Gumball Inventory:{machine.GetCount()}");
            Console.WriteLine($"Gumball State:{machine.GetState()}");
        }
    }
}