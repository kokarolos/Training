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
            GumballMachine gumballMachine = new GumballMachine(2);

            gumballMachine.dispense();
            gumballMachine.InsertQuarter();
            gumballMachine.dispense();
            gumballMachine.InsertQuarter();
            gumballMachine.dispense();
            gumballMachine.InsertQuarter();
            gumballMachine.dispense();
            gumballMachine.TurnCrank();
            gumballMachine.dispense();
            gumballMachine.TurnCrank();
           
            //gumballMachine.dispense();
            //gumballMachine.dispense();
        }
    }
}
