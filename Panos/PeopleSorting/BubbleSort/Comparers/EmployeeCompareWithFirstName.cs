using System.Collections.Generic;
namespace SorttingEmployees
{
    public class EmployeeCompareWithFirstName : IComparer<Employee>
    {
        public int Compare(Employee x, Employee y)
        {
            return x.Firstname.CompareTo(y.Firstname);
        }
    }
}