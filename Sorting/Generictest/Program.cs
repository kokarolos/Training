using System;

namespace Generictest
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }

    public abstract class Person<T> : IComparable<T>
    {
        public Person()
        {

        }
        public int ID { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }

        public int CompareTo(T other)
        {
            return CompareTo(other);
        }

        public override string ToString()
        {
            return $"ID:{ID}, FN:{Firstname}, LN:{Lastname}";
        }
    }
    public class Employee<T> : Person<T>
    {

    }
    public class Manager<T> : Person<T>
    {

    }

    public class CompareId<T> 
        where T : IComparable<T>
    {
        public int Compare(Person<T> left,Person<T> right)
        {
            return left.ID.CompareTo(right.ID);
        }
    }

    public class CompareFirstName<T> 
        where T : IComparable
    {
        public int Compare(Person<T> left, Person<T> right)
        {
            return left.Firstname.CompareTo(right.Firstname);
        }
    }

    public class CompareLastName<T>
        where T : IComparable
    {
        public int Compare(Person<T> left, Person<T> right)
        {
            return left.Firstname.CompareTo(right.Firstname);
        }
    }
}
