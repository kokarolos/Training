using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {

            GumballMachine gumballMachine = new GumballMachine(10);
            GumballMonitor gumballMonitor = new GumballMonitor(gumballMachine);

            gumballMonitor.Report();

        }
    }
}