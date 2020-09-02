using System;
namespace StatePattern
{
    public class NoQuartersState : State
    {

        GumballMachine GumballMachine;

        public NoQuartersState(GumballMachine gumballMachine)
        {
            this.GumballMachine = gumballMachine;

        }

        public void Dispense()
        {
            Console.WriteLine("You need to pay first");
        }

        public void EjectQuarter()
        {
            Console.WriteLine("You havent inserted a quarter");
        }

        public void InsertQuarter()
        {
            Console.WriteLine("You inserted a quarter");
            GumballMachine.SetState(GumballMachine.GethasQuarterState());
        }

        public void TurnCrank()
        {
            Console.WriteLine("You turned but there is no quarter");
        }
    }
}
