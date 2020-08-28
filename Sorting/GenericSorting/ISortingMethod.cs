using System.Collections.Generic;

namespace GenericSorting
{
    public interface ISortingMethod<T>
    {
        IEnumerable<T> Sort();
    }
}