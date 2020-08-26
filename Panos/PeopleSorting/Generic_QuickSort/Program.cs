using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_QuickSort
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }


    public abstract class QuickSort<T>
    {
        public abstract IEnumerable<T> GetSource();
        public abstract IComparer<T> GetComparer();

        public int Partition(T[] emps, int low, int high)
        {
            emps = GetSource().ToArray();
            
            T pivot = emps[high];
            T temp;
            T temp1;
            int i = (low - 1);
            for (int j = low; j < high; j++)
            {
                IComparer<T> comparer = GetComparer();
                if (comparer.Compare( emps[j] , pivot)==-1)
                {
                    i++;
                    temp = emps[i];
                    emps[i] = emps[j];
                    emps[j] = temp;
                }
            }
            temp1 = emps[i + 1];
            emps[i + 1] = emps[high];
            emps[high] = temp1;

            return i + 1;
        }

        public IEnumerable<T> QuickSortMethod(T[] emps, int low, int high) 
        {
            if (low<high)
            {
                int pi = Partition(emps, low, high);
                QuickSortMethod(emps, low, high);
                QuickSortMethod(emps, pi + 1, high);

            }
            return emps;
        }
    }
}
