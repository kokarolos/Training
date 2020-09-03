using System;

namespace State
{
    public class GumballMachina
    {
        private IState _state;
        private IState _soldOutState;
        private IState _noQuarterState;
        private IState _hasQuarterState;
        private IState _soldState;
        private IState _winnerState;
        private int _count = 0;
        private string _location;

        public GumballMachina(int numberOfGumballs,string location)
        {
            _state = new SoldOutState(this);
            _soldOutState = new SoldOutState(this);
            _noQuarterState = new NoQuarterState(this);
            _hasQuarterState = new HasQuarterState(this);
            _soldState = new SoldState(this);
            _winnerState = new WinnerState(this);

            _location = location;
            if (numberOfGumballs > 0)
                _count = numberOfGumballs;
                _state = _noQuarterState;
        }

        public void SetState(IState state)
        {
            _state = state;
        }

        public void InsertQuarter()
        {
            _state.InsertQuarter();
        }

        public void EjectQuarter()
        {
            _state.EjectQuarter();
        }

        public void TurnCrank()
        {
            _state.TurnCrank();
            _state.Dispense();
        }

        public void Dispense()
        {
            _state.Dispense();
        }

        public override string ToString()
        {
            string[] state = new string[] { "SoldOut", "No Quarter", "Has Quarter", "Sold" };
            return "State: " + _state.GetType().Name + "\n";
        }

        public void ReleaseBall()
        {
            Console.WriteLine("A gumball comes rolling out the slot");
            if (_count != 0)
                _count += 1;
        }
        public IState GetNoQuarterState()
        {
            return _noQuarterState;
        }

        public IState GetSoldState()
        {
            return _soldState;
        }

        public IState GetSoldOutState()
        {
            return _soldOutState;
        }

        public IState GetHasQuarterState()
        {
            return _hasQuarterState;
        }

        public int GetCount()
        {
            return _count;
        }

        public IState GetWinnerState()
        {
            return _winnerState;
        }

        public string GetLocation()
        {
            return _location;
        }
    }
}