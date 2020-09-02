using System;
namespace StatePattern
{
    public class HasQuarterState : State
    {
        private GumballMachine gumballMachine;

        public HasQuarterState(GumballMachine gumballMachine)
        {
            this.gumballMachine = gumballMachine;
        }


        public void EjectQuarter()
        {
            Console.WriteLine("Quarter returned");
            gumballMachine.SetState(gumballMachine.GetNoQuarterState());
        }

        public void InsertQuarter()
        {
            Console.WriteLine("You cant insert another quarter");
        }

        public void TurnCrank()
        {
            Console.WriteLine("You turned...");
            gumballMachine.SetState(gumballMachine.GetSoldState());
        }

        public void Dispense()
        {
            Console.WriteLine("No gumball dispensed");
        }
    }
}
