using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_QuickSort
{
    class Program
    {
        static void Main(string[] args)
        {

            EmployeesSort employeesSort = new EmployeesSort();
            var emps = employeesSort.GetSource().ToArray();
            employeesSort.QuickSortMethod(emps, 0, emps.Length-1);

            Console.WriteLine("Print Employees");
            foreach (var item in emps)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
    public abstract class QuickSort<T>
    {
        public abstract IEnumerable<T> GetSource();
        public abstract IComparer<T> GetComparer();

        public int Partition(T[] emps, int low, int high)
        {
            emps = GetSource().ToArray();
            
            T pivot = emps[high];
            T temp;
            T temp1;
            int i = (low - 1);
            for (int j = low; j < high; j++)
            {
                IComparer<T> comparer = GetComparer();
                if (comparer.Compare( emps[j] , pivot)==-1)
                {
                    i++;
                    temp = emps[i];
                    emps[i] = emps[j];
                    emps[j] = temp;
                }
            }
            temp1 = emps[i + 1];
            emps[i + 1] = emps[high];
            emps[high] = temp1;

            return i + 1;
        }

        public IEnumerable<T> QuickSortMethod(T[]emps, int low, int high) 
        {
            if (low<high)
            {
                int pi = Partition(emps, low, high);
                QuickSortMethod(emps, low, high);
                QuickSortMethod(emps, pi + 1, high);
            }
            return emps;
        }
    }

    public class EmployeesSort : QuickSort<Employee>
    {
        public override IComparer<Employee> GetComparer()
        {
            return new EmployeeCompareWithLastName();
        }
        public override IEnumerable<Employee> GetSource()
        {
            return new List<Employee>()
            {
                 new Employee() { ID = 0, Firstname = "Efstathios0", Lastname ="Chrysikos0"},
                 new Employee() { ID = 1, Firstname = "Efstathios1", Lastname ="Chrysikos1"},
                 new Employee() { ID = 9, Firstname = "Efstathios9", Lastname ="Chrysikos9"},
                 new Employee() { ID = 3, Firstname = "Efstathios3", Lastname ="Chrysikos3"},
                 new Employee() { ID = 8, Firstname = "Efstathios8", Lastname ="Chrysikos8"},
                 new Employee() { ID = 7, Firstname = "Efstathios7", Lastname ="Chrysikos7"},
                 new Employee() { ID = 6, Firstname = "Efstathios6", Lastname ="Chrysikos6"},
                 new Employee() { ID = 5, Firstname = "Efstathios5", Lastname ="Chrysikos5"},
                 new Employee() { ID = 4, Firstname = "Efstathios4", Lastname ="Chrysikos4"},
                 new Employee() { ID = 2, Firstname = "Efstathios2", Lastname ="Chrysikos2"},
            };
        }
    }
    public class EmployeeCompareWithID : IComparer<Employee>
    {
        public int Compare(Employee x, Employee y)
        {
            return x.ID.CompareTo(y.ID);
        }
    }
    public class EmployeeCompareWithFirstName : IComparer<Employee>
    {
        public int Compare(Employee x, Employee y)
        {
            return x.Firstname.CompareTo(y.Firstname);
        }
    }
    public class EmployeeCompareWithLastName : IComparer<Employee>
    {
        public int Compare(Employee x, Employee y)
        {
            return x.Lastname.CompareTo(y.Lastname);
        }
    }
    public class Employee
    {
        public Employee()
        {
        }
        public int ID { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public override string ToString()
        {
            return $"ID:{ID}, FN:{Firstname}, LN:{Lastname}";
        }
    }
}
