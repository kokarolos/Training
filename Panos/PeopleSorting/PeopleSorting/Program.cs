using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleSorting
{
    class Program
    {
        static void Main(string[] args)
        {
            // Generate Employes
            Employe e1 = new Employe(1,"Panos", "Rizos");
            Employe e2 = new Employe(2,"Nick", "Zouridis");
            Employe e3 = new Employe(3,"John", "Papadopoulos");
            Employe e4 = new Employe(4,"Mark", "George");
            Employe e5 = new Employe(5,"Mary", "Georgiou");

            BubbleSort sort = new BubbleSort();

            // Generate Children
            Child c1 = new Child(5);
            Child c2 = new Child(8);
            Child c3 = new Child(2);

            //sorting Employees
            List<ISortable> Employes = new List<ISortable> { e3, e2, e1, e5, e4 };
            sort.Sort(Employes);
            BubbleSort.PrintSortedList(Employes);

            //sorting Children
            List<ISortable> Children = new List<ISortable> { c1, c2, c3 };
            sort.Sort(Children);
            BubbleSort.PrintSortedList(Children);

            // Sorting Both of Concrete Classes Together
            List<ISortable> ChildrenAndEmployees = new List<ISortable> { c1, c2, c3, e3, e2, e1, e5, e4 };
            sort.Sort(ChildrenAndEmployees);
            BubbleSort.PrintSortedList(ChildrenAndEmployees);

        }
    }
}