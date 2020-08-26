using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    partial class Program
    {
        static void Main(string[] args)
        {
            var pancakeHouseMenu = new PancakeHouseMenu();
            var dinerMenu = new DinerMenu();
            var waitress = new Waitress(pancakeHouseMenu, dinerMenu);
            waitress.PrintMenu();
        }
    }
}
