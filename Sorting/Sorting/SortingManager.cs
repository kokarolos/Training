namespace Sorting
{
    public class SortingManager
    {
        public static void Sort(ISortable[] sortables,ISortingMethod sortingMethod)
        {
            sortingMethod.Sort(sortables);
        }
    }
}
