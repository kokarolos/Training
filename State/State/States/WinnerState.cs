using System;

namespace State
{
    public class WinnerState : IState
    {
        private GumballMachina _machina;
        public WinnerState(GumballMachina machina)
        {
            _machina = machina;
        }

        public void Dispense()
        {
            Console.WriteLine("You are a winner! You get two gumballs for your quarter");
            _machina.ReleaseBall();
            if(_machina.GetCount() == 0)
            {
                _machina.SetState(_machina.GetSoldOutState());
            }
            else
            {
                _machina.ReleaseBall();
                if (_machina.GetCount() > 0)
                {
                    _machina.SetState(_machina.GetNoQuarterState());
                }
                else
                {
                    Console.WriteLine("OoOoOOoooooOps,out of gumballs");
                    _machina.SetState(_machina.GetSoldOutState());
                }
            }
        }

        public void EjectQuarter()
        {
            throw new NotImplementedException();
        }

        public void InsertQuarter()
        {
            throw new NotImplementedException();
        }

        public void TurnCrank()
        {
            throw new NotImplementedException();
        }
    }
}
