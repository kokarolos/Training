namespace State
{
    public class GumballMachina
    {
        private IState _state;
        private IState _soldOutState;
        private IState _noQuarterState;
        private IState _hasQuarterState;
        private IState _soldState;
        private int _count = 0;

        public GumballMachina(int numberOfGumballs)
        {
            _soldOutState = new SoldOutState(this);
            _noQuarterState = new NoQuarterState(this);
            _hasQuarterState = new HasQuarterState(this);
            _soldState = new SoldState(this);
            if (numberOfGumballs > 0)
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
    }
}