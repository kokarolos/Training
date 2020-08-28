using System.Collections.Generic;

namespace GenericSorting
{
    public class EmployeesBSort : QuickSortFirstName
    {
        private QuickShort<Employee> _quickSortMethod;
        public EmployeesBSort(QuickShort<Employee> quickSortMethod)
        {
            _quickSortMethod = quickSortMethod;
        }
        public new IEnumerable<Employee> Sort()
        {
            return _quickSortMethod.Sort();
        }
    }
}