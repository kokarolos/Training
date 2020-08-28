using System;
using System.Collections.Generic;
using System.Linq;

namespace GenericSorting
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = new List<Employee>
            {
                new Employee() { ID = 0, Firstname = "Karol0", Lastname = "Koniewicz0" },
                new Employee() { ID = 1, Firstname = "Karol1", Lastname = "Koniewicz1" },
                new Employee() { ID = 9, Firstname = "Karol9", Lastname = "Koniewicz9" },
                new Employee() { ID = 3, Firstname = "Karol3", Lastname = "Koniewicz3" },
                new Employee() { ID = 8, Firstname = "Karol8", Lastname = "Koniewicz8" },
                new Employee() { ID = 7, Firstname = "Karol7", Lastname = "Koniewicz7" },
                new Employee() { ID = 6, Firstname = "Karol6", Lastname = "Koniewicz6" },
                new Employee() { ID = 5, Firstname = "Karol5", Lastname = "Koniewicz5" },
                new Employee() { ID = 4, Firstname = "Karol4", Lastname = "Koniewicz4" },
                new Employee() { ID = 2, Firstname = "Karol2", Lastname = "Koniewicz2" },
                new Employee() { ID = 10, Firstname = "Karol10", Lastname = "Koniewicz10" },
            };

            var template = new SortTemplate<Employee>();
            var sorted = template.Sort(array.AsEnumerable(), SortingMethodEnum.QuickSort, ComparerEnum.Id);
            sorted.ToList().ForEach(x => Console.WriteLine(x.ToString()));
        }
    }
}