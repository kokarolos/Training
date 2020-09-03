using System;

namespace Proxy
{
    public partial class GumballMachine
    {
        State soldOutState;
        State soldState;
        State hasQuarterState;
        State noQuarterState;
        State state;
        State WinnerState;
        private string location; // DPS
        int count = 0;

        public GumballMachine(int numberGumBalls)
        {
            soldOutState = new SoldOutState(this);
            soldState = new SoldState(this);
            hasQuarterState = new HasQuarterState(this);
            noQuarterState = new NoQuartersState(this);
            state = new SoldOutState(this);
            WinnerState = new WinnerState(this);
            this.count = numberGumBalls;
            if (numberGumBalls > 0)
                state = noQuarterState;
        }

        public void ReleaseBall()
        {
            Console.WriteLine("A GumBall comes rolling out the slot");
            if (count != 0)
            {
                count = count - 1;
            }
        }

        public void dispense()
        {
            state.Dispense();
        }
        public void SetState(State state)
        {
            this.state = state;
        }

        public void InsertQuarter()
        {
            state.InsertQuarter();
        }
        public void Ejectquarter()
        {
            state.EjectQuarter();
        }
        public void TurnCrank()
        {
            state.TurnCrank();
            state.Dispense();
        }

        public State GetNoQuarterState()
        {
            return new NoQuartersState(this);
        }

        public State GetsoldOutState()
        {
            return soldOutState;
        }

        public State GetSoldState()
        {
            return soldState;
        }
        public State GethasQuarterState()
        {
            return hasQuarterState;
        }
        public State GetWinnerState()
        {
            return WinnerState;
        }

        public int GetCount()
        {
            return count;
        }

        public string GetLocation()
        {
            return location;
        }

        public State GetState()
        {
            return state;
        }

    }
}