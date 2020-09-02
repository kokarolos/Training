using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            GumballMachine gumballMachine = new GumballMachine(40);


            gumballMachine.dispense();
            gumballMachine.InsertQuarter();
            gumballMachine.dispense();
            gumballMachine.TurnCrank();
        }
    }

    public class WinnerState : State
    {
        public void Dispense()
        {
            throw new System.NotImplementedException();
        }

        public void EjectQuarter()
        {
            throw new System.NotImplementedException();
        }

        public void InsertQuarter()
        {
            throw new System.NotImplementedException();
        }

        public void TurnCrank()
        {
            throw new System.NotImplementedException();
        }
    }
}
