using System;

namespace GenericSorting
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeesBSort employeesBSort = new EmployeesBSort(new QuickSortFirstName());
            var sorted = employeesBSort.Sort();
            foreach (var item in sorted)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}