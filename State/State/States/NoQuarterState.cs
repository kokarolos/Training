using System;

namespace State
{
    public class NoQuarterState : IState
    {
        private GumballMachina _machina;
        public NoQuarterState(GumballMachina machina)
        {
            _machina = machina;
        }

        public void Dispense()
        {
            throw new NotImplementedException();
        }

        public void EjectQuarter()
        {
            throw new NotImplementedException();
        }

        public void InsertQuarter()
        {
            Console.WriteLine("Inserted Coin");
            _machina.SetState(_machina.GetHasQuarterState());
        }

        public void TurnCrank()
        {
            throw new NotImplementedException();
        }
    }
}
