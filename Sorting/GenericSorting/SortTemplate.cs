using System.Collections.Generic;

namespace GenericSorting
{
    public class SortTemplate<T> where T : Employee
    {
        private ISortingMethod<T> _sortingMethod;
        public SortTemplate()
        {

        }
        private SortTemplate(ISortingMethod<T> sortingMethod)
        {
            _sortingMethod = sortingMethod;
        }

        public IEnumerable<T> Sort(IEnumerable<T> array, SortingMethodEnum sortingMethod, ComparerEnum comparerEnum)
        {
            IComparer<T> comparer = ComparerFactory<T>.Create(comparerEnum);
            switch (sortingMethod)
            {
                case SortingMethodEnum.BubbleSort:
                    _sortingMethod = new BubbleSort<T>();
                    break;
                case SortingMethodEnum.QuickSort:
                    _sortingMethod = new QuickShort<T>();
                    break;
            }
            return _sortingMethod.Sort(array, comparer);
        }
    }
}