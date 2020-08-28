using System.Collections.Generic;

namespace GenericSorting
{
    public class EmployeesQSort : QuickSortFirstName
    {
        private QuickShort<Employee> _quickSortMethod;
        public EmployeesQSort(QuickShort<Employee> quickSortMethod)
        {
            _quickSortMethod = quickSortMethod;
        }
        public new IEnumerable<Employee> Sort()
        {
            return _quickSortMethod.Sort();
        }
    }
}