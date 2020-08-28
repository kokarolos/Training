using System.Collections.Generic;
using System.Linq;
namespace SorttingEmployees
{
    public abstract class QuickSort<T>
    {
        protected abstract IComparer<T> GetComparer();
        protected abstract IEnumerable<T> GetSource();

        public IEnumerable<T> Sort()
        {
            T[] array = GetSource().ToArray();
            return QuickSortMethod(array, 0, array.Length - 1);
        }

        private IEnumerable<T> QuickSortMethod(T[] array, int left, int right)
        {
            IComparer<T> comparer = GetComparer();
            int i = left;
            int j = right;
            var pivot = array[(left + right) / 2];
            while (i <= j)
            {
                while (comparer.Compare(array[i], pivot) < 0)
                {
                    i++;
                }
                while (comparer.Compare(array[j], pivot) > 0)
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
                QuickSortMethod(array, left, i);
            }
            if (i < right)
            {
                QuickSortMethod(array, i, right);
            }
            return array;
        }


        public static IComparer<Employee> SelectComparison(CompareWith option)
        {
            switch (option)
            {
                case CompareWith.FirstName:
                    return new EmployeeCompareWithFirstName();

                case CompareWith.LastName:
                    return new EmployeeCompareWithLastName();

                case CompareWith.Id:
                    return new EmployeeCompareWithID();
            }

            throw new System.InvalidOperationException();
        }

    }
}