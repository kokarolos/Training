using System.Collections.Generic;

namespace GenericSorting
{
    public class EmployeeCompareWithLastName : IComparer<Employee>
    {
        public int Compare(Employee x, Employee y)
        {
            return x.Lastname.CompareTo(y.Lastname);
        }
    }
}