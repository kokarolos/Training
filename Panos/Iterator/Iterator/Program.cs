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
            List<Menu> menus = new List<Menu> { new DinerMenu(), new PanCakeHouseMenu(), new CafeMenu() };
            Waitor waitor = new Waitor(menus);
            waitor.PrintMenu();
        }
    }
}
