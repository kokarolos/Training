using System;

namespace State
{
    public class GumballMonitor
    {
        private GumballMachina _gumballMachine;

        public GumballMonitor(GumballMachina gumballMachina)
        {
            _gumballMachine = gumballMachina;
        }

        public void Report()
        {
            Console.WriteLine($"Gumball Machine {_gumballMachine.GetLocation()}");
            Console.WriteLine($"Current Inventory {_gumballMachine.GetCount()} gumballs");
            Console.WriteLine($"Current State {_gumballMachine.ToString()}");
        }
    }

}