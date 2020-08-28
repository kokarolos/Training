using System;
using System.Collections.Generic;

namespace GenericSorting
{
    public class ComparerFactory<T>
    {
        public static IComparer<T> Create(string type)
        {
            if (type.ToLower().Equals("id"))
            {
                return new EmployeeCompareWithID() as IComparer<T>;
            }
            if (type.ToLower().Equals("firstname"))
            {
                return new EmployeeCompareWithFirstName() as IComparer<T>;
            }
            if (type.ToLower().Equals("lastname"))
            {
                return new EmployeeCompareWithLastName() as IComparer<T>;
            }
            throw new InvalidOperationException();
        }
    }
}