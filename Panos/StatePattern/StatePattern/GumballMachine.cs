using System;

namespace StatePattern
{
    public class GumballMachine
    {
        State soldOutState;
        State soldState;
        State hasQuarterState;
        State noQuarterState;
        State state;
        State WinnerState;

        int count = 0;

        public GumballMachine(int numberGumBalls)
        {
            soldOutState = new SoldOutState(this);
            soldState = new SoldState(this);
            hasQuarterState = new HasQuarterState(this);
            noQuarterState = new NoQuartersState(this);
            this.count = numberGumBalls;
            if (numberGumBalls>0)
            {
                state = noQuarterState;
            }
            else
            {
                state = soldOutState;
            }
        }


        public void ReleaseBall()
        {
            Console.WriteLine("A GumBall comes rolling out the slot");
            if (count!=0)
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
            return new SoldOutState(this);
        }

        public State GetSoldState()
        {
            return new SoldState(this);
        }

        public State GethasQuarterState()
        {
            return new HasQuarterState(this);

        }

        public int GetCount()
        {
            return count;
        }


    }
}
