using System.Collections.Generic;
namespace SorttingEmployees
{
    public class EmployeeCompareWithID : IComparer<Employee>
    {
        public int Compare(Employee x, Employee y)
        {
            return x.ID.CompareTo(y.ID);
        }
    }
}