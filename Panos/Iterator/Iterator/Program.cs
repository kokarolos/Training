using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            DinerMenu dinermenu = new DinerMenu();
            PanCakeHouseMenu panCakeHouseMenu = new PanCakeHouseMenu();
            Waitor waitor = new Waitor(panCakeHouseMenu,dinermenu);

            waitor.PrintMenu();

           
        }
    }
}
