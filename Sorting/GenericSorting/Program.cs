using System;
using System.Collections.Generic;
using System.Linq;

namespace GenericSorting
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployessQuickSort emps = new EmployessQuickSort();
            var toSort = emps.Sort();
            foreach (var item in toSort)
            {
                Console.WriteLine(item);
            }
        }
    }

    public abstract class BubbleSort<T>
    {
        protected abstract IComparer<T> GetComparer();
        protected abstract IEnumerable<T> GetSource();

        public IEnumerable<T> Sort()
        {
            T[] emps = GetSource().ToArray();
            T temp;
            for (int j = 0; j <= emps.Length - 2; j++)
            {
                for (int i = 0; i <= emps.Length - 2; i++)
                {
                    IComparer<T> comparer = GetComparer();
                    if (comparer.Compare(emps[i], emps[i + 1]) == 1)
                    {
                        temp = emps[i + 1];
                        emps[i + 1] = emps[i];
                        emps[i] = temp;
                    }
                }
            }
            return emps;
        }
    }

    public abstract class QuickShort<T>
    {
        protected abstract IComparer<T> GetComparer();
        protected abstract IEnumerable<T> GetSource();

        public IEnumerable<T> Sort()
        {
            T[] array = GetSource().ToArray();
            var comparer = GetComparer();
            Sort(array, 0, array.Length - 1, comparer);
            return array;
        }

        private static void Sort(T[] array, int left, int right, IComparer<T> comparer)
        {
            int i = left;
            int j = right;
            T pivot = array[left + (right - left) / 2];
            while (i <= j)
            {
                while (comparer.Compare(array[i], pivot) == -1)
                {
                    i++;
                }

                while (comparer.Compare(array[j], pivot) == 1)
                {
                    j--;
                }

                if (i <= j)
                {
                    var temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;

                    i++;
                    j--;
                }
                if (left < j)
                {
                    Sort(array, left, j, comparer);
                }
                if (i < right)
                {
                    Sort(array, i, right, comparer);
                }
            }
        }
    }

    public class EmployessQuickSort : QuickShort<Employee>
    {
        protected override IComparer<Employee> GetComparer()
        {
            return new EmployeeCompareWithID();
        }

        protected override IEnumerable<Employee> GetSource()
        {
            return new List<Employee>()
            {
                 new Employee() { ID = 1, Firstname = "Efstathios0", Lastname ="Chrysikos0"},
                 new Employee() { ID = 0, Firstname = "Efstathios1", Lastname ="Chrysikos1"},
                 new Employee() { ID = 3, Firstname = "Efstathios9", Lastname ="Chrysikos9"},
                 new Employee() { ID = 9, Firstname = "Efstathios3", Lastname ="Chrysikos3"},
                 new Employee() { ID = 8, Firstname = "Efstathios8", Lastname ="Chrysikos8"},
                 new Employee() { ID = 7, Firstname = "Efstathios7", Lastname ="Chrysikos7"},
                 new Employee() { ID = 6, Firstname = "Efstathios6", Lastname ="Chrysikos6"},
                 new Employee() { ID = 5, Firstname = "Efstathios5", Lastname ="Chrysikos5"},
                 new Employee() { ID = 4, Firstname = "Efstathios4", Lastname ="Chrysikos4"},
                 new Employee() { ID = 2, Firstname = "Efstathios2", Lastname ="Chrysikos2"},
            };
        }
    }

    public class EmployeesSort : BubbleSort<Employee>
    {
        protected override IComparer<Employee> GetComparer()
        {
            return new EmployeeCompareWithLastName();
        }
        protected override IEnumerable<Employee> GetSource()
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