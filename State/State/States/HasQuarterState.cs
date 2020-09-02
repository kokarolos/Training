using System;

namespace State
{
    public class HasQuarterState : IState
    {
        private GumballMachina _machina;
        private Random _randomWinner = new Random();
        public HasQuarterState(GumballMachina machina)
        {
            _machina = machina;
        }

        public void Dispense()
        {
            Console.WriteLine("No Gumball Dispensed");
        }

        public void EjectQuarter()
        {
            Console.WriteLine("Quarter returned");
            _machina.SetState(_machina.GetNoQuarterState());
        }

        public void InsertQuarter()
        {
            Console.WriteLine("You cant insert another quarter");
        }

        public void TurnCrank()
        {
            Console.WriteLine("You turned...");
            var winner = _randomWinner.Next(1, 10);
            if (winner == 10 && _machina.GetCount() > 1)
            {
                _machina.SetState(_machina.GetWinnerState());
            }
            else
            {
                _machina.SetState(_machina.GetSoldOutState());
            }
        }
    }
}
