using System;
using System.Collections.Generic;

namespace PeopleSorting
{
    public class BubbleSort
    {
        /// <summary>
        /// Method that is sorting an Isortable list
        /// </summary>
        /// <param name="list"></param>
        public void Sort(List<ISortable>list)
        {
            ISortable temp;
            for (int j = 0; j <= list.Count -2; j++)
            {
                for (int i = 0; i <= list.Count - 2; i++)
                {
                    if (list[i].Id > list[i + 1].Id)
                    {
                        temp = list[i+1];
                        list[i + 1] = list[i];
                        list[i] = temp;
                    }
                }
            }
        }

        public static void PrintSortedList(List<ISortable> list)
        {
            foreach (var item in list)
            {
                Console.WriteLine(item.Id);
            }
        }
    }
}