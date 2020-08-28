using System.Collections.Generic;
using System.Linq;

namespace GenericSorting
{
    public class QuickShort<T> : ISortingMethod<T>
    {
        public IEnumerable<T> Sort(IEnumerable<T> array, IComparer<T> comparer)
        {
            Sort(array, 0, array.Count() - 1, comparer);
            return array;
        }

        private void Sort(IEnumerable<T> arrayEnum, int left, int right, IComparer<T> comparer)
        {
            int i = left;
            int j = right;
            T[] array = arrayEnum.ToArray();
            T pivot = array[left + (right - left) / 2];

            while (i <= j)
            {
                while (comparer.Compare(array[i], pivot) == -1)
                {
                    i++;
                }

                while (comparer.Compare(array[j], pivot) == 1)
                {
                    j--;
                }

                if (i <= j)
                {
                    var temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;

                    i++;
                    j--;
                }
            }
            if (left < j)
            {
                Sort(array, left, j, comparer);
            }
            if (i < right)
            {
                Sort(array, i, right, comparer);
            }
        }
    }
}
