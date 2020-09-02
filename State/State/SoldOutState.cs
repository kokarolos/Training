using System;

namespace State
{
    public class SoldOutState : IState
    {
        private GumballMachina _machina;
        public SoldOutState(GumballMachina machina)
        {
            _machina = machina;
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
            _machina.SetState(_machina.GetHasQuarterState());
        }

        public void TurnCrank()
        {
            Console.WriteLine("You haven't inserted a quarter");
        }
    }
}
