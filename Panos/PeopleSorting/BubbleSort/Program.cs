﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace SorttingEmployees
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeesSort employeesSort = new EmployeesSort();
            var emps = employeesSort.Sort();
            Console.WriteLine("Print Sort");
            foreach (var item in emps)
            {
                Console.WriteLine(item.ToString());
            }
            Console.ReadLine();
        }
    }
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
    public class EmployeesSort : BubbleSort<Employee>
    {
        protected override IComparer<Employee> GetComparer()
        {
            return new EmployeeCompareWithLastName();
        }
        protected override IEnumerable<Employee> GetSource()
        {
            return new List<Employee>()
            {
                 new Employee() { ID = 0, Firstname = "Efstathios0", Lastname ="Chrysikos0"},
                 new Employee() { ID = 1, Firstname = "Efstathios1", Lastname ="Chrysikos1"},
                 new Employee() { ID = 9, Firstname = "Efstathios9", Lastname ="Chrysikos9"},
                 new Employee() { ID = 3, Firstname = "Efstathios3", Lastname ="Chrysikos3"},
                 new Employee() { ID = 8, Firstname = "Efstathios8", Lastname ="Chrysikos8"},
                 new Employee() { ID = 7, Firstname = "Efstathios7", Lastname ="Chrysikos7"},
                 new Employee() { ID = 6, Firstname = "Efstathios6", Lastname ="Chrysikos6"},
                 new Employee() { ID = 5, Firstname = "Efstathios5", Lastname ="Chrysikos5"},
                 new Employee() { ID = 4, Firstname = "Efstathios4", Lastname ="Chrysikos4"},
                 new Employee() { ID = 2, Firstname = "Efstathios2", Lastname ="Chrysikos2"},
            };
        }
    }
    public class EmployeeCompareWithID : IComparer<Employee>
    {
        public int Compare(Employee x, Employee y)
        {
            return x.ID.CompareTo(y.ID);
        }
    }
    public class EmployeeCompareWithFirstName : IComparer<Employee>
    {
        public int Compare(Employee x, Employee y)
        {
            return x.Firstname.CompareTo(y.Firstname);
        }
    }
    public class EmployeeCompareWithLastName : IComparer<Employee>
    {
        public int Compare(Employee x, Employee y)
        {
            return x.Lastname.CompareTo(y.Lastname);
        }
    }
    public class Employee
    {
        public Employee()
        {
        }
        public int ID { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public override string ToString()
        {
            return $"ID:{ID}, FN:{Firstname}, LN:{Lastname}";
        }
    }
}