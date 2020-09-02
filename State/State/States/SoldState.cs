using System;

namespace State
{
    public class SoldState : IState
    {
        private GumballMachina _machina;
        public SoldState(GumballMachina machina)
        {
            _machina = machina;
        }

        public void Dispense()
        {
            _machina.ReleaseBall();
            if (_machina.GetCount() > 0)
            {
                _machina.SetState(_machina.GetNoQuarterState());
            }
            else
            {
                Console.WriteLine("Oops out of Gumballs");
                _machina.SetState(_machina.GetSoldOutState());
            }
        }

        public void EjectQuarter()
        {
            Console.WriteLine("Sorry you already turned the crank");
        }

        public void InsertQuarter()
        {
            Console.WriteLine("Please wait,we're already giving you a gumball");
        }

        public void TurnCrank()
        {
            Console.WriteLine("Turning twice doesn't get you another gumball");
        }
    }
}
