using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    class Program
    {
        static void Main(string[] args)
        {
           // var machina = new GumballMachina(5); //Load it up with five gumballs total
           // Console.WriteLine(machina); //State of machine
           //
           // machina.InsertQuarter(); // Throw a quarter in..
           // machina.TurnCrank(); //Turn the crank; we should get our gumball.
           //
           // Console.WriteLine(machina); // State
           //
           // machina.InsertQuarter(); // throw a quearter in 
           // machina.EjectQuarter(); //Ask for it back
           // machina.TurnCrank(); //Turn the crank; we shouldnt get our gumball
           //
           // Console.WriteLine(machina); //State
           //
           // machina.InsertQuarter(); //Throw a quarter in
           // machina.TurnCrank(); //Turn the crank we should get our gumball
           // machina.InsertQuarter(); //Throw a quarter in
           // machina.TurnCrank(); //Turn the crank; we should get our gumball
           // machina.EjectQuarter(); //Ask for a quarter back we didn't put in.
           //
           // Console.WriteLine(machina);
           //
           // machina.InsertQuarter(); //Throw firs quarter
           // machina.InsertQuarter(); //Throw SECOND quarter
           // machina.TurnCrank(); //Turn the crank we should get our gumball
           // machina.InsertQuarter();
           // machina.TurnCrank();
           // machina.InsertQuarter();
           // machina.TurnCrank();
           //
           // Console.WriteLine(machina);



        }
    }

    public class SoldState : IState
    {
        private GumballMachina _machina;
        public SoldState(GumballMachina machina)
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
            throw new NotImplementedException();
        }

        public void TurnCrank()
        {
            throw new NotImplementedException();
        }
    }
    public class WinnerState : IState
    {
        private GumballMachina _machina;
        public WinnerState(GumballMachina machina)
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
            throw new NotImplementedException();
        }

        public void TurnCrank()
        {
            throw new NotImplementedException();
        }
    }

    public class HasQuarterState : IState
    {
        private GumballMachina _machina;
        public HasQuarterState(GumballMachina machina)
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
            throw new NotImplementedException();
        }

        public void TurnCrank()
        {
            throw new NotImplementedException();
        }
    }

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
            throw new NotImplementedException();
        }

        public void TurnCrank()
        {
            throw new NotImplementedException();
        }
    }
}
