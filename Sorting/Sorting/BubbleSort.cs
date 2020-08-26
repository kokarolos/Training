namespace Sorting
{
    public class BubbleSort : ISortingMethod
    {
        public void Sort(ISortable[] sortables)
        {
            ISortable temp;
            for (int j = 0; j < sortables.Length -2; j++)
            {
                for (int i = 0; i <= sortables.Length -2 ; i++)
                {
                    if(sortables[i].Id > sortables[i + 1].Id)
                    {
                        temp = sortables[i + 1];
                        sortables[i + 1] = sortables[i];
                        sortables[i] = temp;
                    }
                }
            }
        }
    }
}
