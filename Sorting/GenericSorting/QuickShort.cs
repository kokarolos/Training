using System.Collections.Generic;
using System.Linq;

namespace GenericSorting
{
    public abstract class QuickShort<T>
    {
        protected abstract IComparer<T> GetComparer();
        protected abstract IEnumerable<T> GetSource();

        public IEnumerable<T> Sort()
        {
            T[] array = GetSource().ToArray();
            var comparer = GetComparer();
            Sort(array, 0, array.Length - 1, comparer);
            return array;
        }

        private void Sort(T[] array, int left, int right, IComparer<T> comparer)
        {
            int i = left;
            int j = right;
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
}