using System;

namespace GenericSorting
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeesQSort employeesBSort = new EmployeesQSort(new QuickSortFirstName());
            var sorted = employeesBSort.Sort();
            foreach (var item in sorted)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}