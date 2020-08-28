using System;
using System.Collections.Generic;

namespace GenericSorting
{
    public class ComparerFactory<T>
    {
        public static IComparer<T> Create(ComparerEnum type)
        {
            if (type == ComparerEnum.Id)
            {
                return new EmployeeCompareWithID() as IComparer<T>;
            }
            if (type == ComparerEnum.FirstName)
            {
                return new EmployeeCompareWithFirstName() as IComparer<T>;
            }
            if (type == ComparerEnum.LastName)
            {
                return new EmployeeCompareWithLastName() as IComparer<T>;
            }
            throw new InvalidOperationException();
        }
    }
}