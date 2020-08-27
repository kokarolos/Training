using System;
using System.Collections.Generic;
using System.Linq;

namespace PeopleSorting
{
    public abstract class BubbleSort<T>
    {
        protected abstract IComparer<T> GetComparer();
        protected abstract IEnumerable<T> GetSource();
        public IEnumerable<T> Sort()
        {
            T[] emps = GetSource().ToArray();
            T temp;
            for (int j = 0; j <= emps.Length - 2; j++)
            {
                for (int i = 0; i <= emps.Length - 2; i++)
                {
                    IComparer<T> comparer = this.GetComparer();
                    if (comparer.Compare(emps[i], emps[i + 1]) == 1)
                    {
                        temp = emps[i + 1];
                        emps[i + 1] = emps[i];
                        emps[i] = temp;
                    }
                }
            }
            return emps;
        }
    }
}