using System;
using System.Collections.Generic;
using System.Linq;

namespace Sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            NumSorter numSorter = new NumSorter();
            var sorted = numSorter.Sort();
            foreach (var item in sorted)
            {
                Console.WriteLine(item);
            }

            StringSorter s = new StringSorter();
            var sortedString = s.Sort();
            foreach (var item in sortedString)
            {
                Console.WriteLine(item);
            }
        }

    }
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

        private static void Sort(T[] array, int left, int right, IComparer<T> comparer)
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

    public class NumSorter : QuickShort<int>
    {
        protected override IComparer<int> GetComparer()
        {
            return new NumberComparer();
        }

        protected override IEnumerable<int> GetSource()
        {
            return new int[] { 2, 5, -4, 11, 0, 18, 22, 67, 51, 1 };
        }

        public void PrintSorted<T>()
        {
            foreach (var item in GetSource())
            {
                Console.WriteLine(item);
            }
        }
    }
    public class StringSorter : QuickShort<string>
    {
        protected override IComparer<string> GetComparer()
        {
            return new StringComparer();
        }

        protected override IEnumerable<string> GetSource()
        {
            return new string[] { "Karol", "Panos", "Takis", "Akis" };
        }

        public void PrintSorted<T>()
        {
            foreach (var item in GetSource())
            {
                Console.WriteLine(item);
            }
        }
    }

    public class NumberComparer : IComparer<int>
    {
        public int Compare(int x, int y)
        {
            return x.CompareTo(y);
        }
    }
    public class StringComparer : IComparer<string>
    {
        public int Compare(string x, string y)
        {
            return x.CompareTo(y);
        }
    }

}
