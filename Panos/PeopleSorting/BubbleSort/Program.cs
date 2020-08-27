using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace SorttingEmployees
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeesBubbleSort employeesBubbleSort = new EmployeesBubbleSort();
            EmployeesQuickSort employeesQuickSort = new EmployeesQuickSort();

            var empsBubbleSorted = employeesBubbleSort.Sort();
            var empsQuickSorted = employeesQuickSort.Sort();
            Console.WriteLine("Print Sort");

            Print(empsBubbleSorted.ToArray());
            Print(empsQuickSorted.ToArray());
        }

        /// <summary>
        /// Generic method for flexible printing
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="array"></param>
        public static void Print<T>(T[] array)
        {
            foreach (var item in array)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}