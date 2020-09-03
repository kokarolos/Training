using System;

namespace Proxy
{
    public class SoldOutState : State
    {
        private GumballMachine gumballMachine;

        public SoldOutState(GumballMachine gumballMachine)
        {
            this.gumballMachine = gumballMachine;
        }

        public void Dispense()
        {
            Console.WriteLine("No gumball dispenced");
        }

        public void EjectQuarter()
        {
            Console.WriteLine("You can't eject a quarter,you havent inserted a quartered yet");
        }

        public void InsertQuarter()
        {
            Console.WriteLine("You can't insert a quarter, the machine is sold out");
        }

        public void TurnCrank()
        {
            Console.WriteLine("You turned but there is no gumballs");
        }
    }

}
