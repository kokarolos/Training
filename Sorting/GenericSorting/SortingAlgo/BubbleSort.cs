using System.Collections.Generic;
using System.Linq;

namespace GenericSorting
{
    public class BubbleSort<T> : ISortingMethod<T>
    {
        public IEnumerable<T> Sort(IEnumerable<T> array, IComparer<T> comparer)
        {
            T[] genericArray = array.ToArray();
            T temp;
            for (int j = 0; j <= genericArray.Length - 2; j++)
            {
                for (int i = 0; i <= genericArray.Length - 2; i++)
                {
                    if (comparer.Compare(genericArray[i], genericArray[i + 1]) == 1)
                    {
                        temp = genericArray[i + 1];
                        genericArray[i + 1] = genericArray[i];
                        genericArray[i] = temp;
                    }
                }
            }
            return genericArray;
        }
    }
}
