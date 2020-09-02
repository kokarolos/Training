using System;

namespace StatePattern
{
    public class WinnerState : State
    {
        GumballMachine GumballMachine;
        public WinnerState(GumballMachine gumballMachine)
        {
            this.GumballMachine = gumballMachine;
        }

        public void Dispense()
        {

            Console.WriteLine("You are a winner!Two balls for your quarter");
            GumballMachine.ReleaseBall();
            if (GumballMachine.GetCount() == 0)
            {
                GumballMachine.SetState(GumballMachine.GetsoldOutState());
            }
            else 
            {
                GumballMachine.ReleaseBall();
                if (GumballMachine.GetCount()>0)
                {
                    GumballMachine.SetState(GumballMachine.GetsoldOutState());
                }
                else
                {
                    Console.WriteLine("Out of balls");
                    GumballMachine.SetState(GumballMachine.GetsoldOutState());
                }
            }

        }

        public void EjectQuarter()
        {
            Console.WriteLine("You cant eject ");

        }

        public void InsertQuarter()
        {
            Console.WriteLine("Now you cant insert a quarter");
        }

        public void TurnCrank()
        {
            Console.WriteLine("Now you cant turn a crank");
        }
    }
}
