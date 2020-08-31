using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator2
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeCollection employeeCollection = new EmployeeCollection();
            employeeCollection.Add(new Employee() { ID = 0, Name = "Stathis0" });
            employeeCollection.Add(new Employee() { ID = 1, Name = "Stathis1" });
            employeeCollection.Add(new Employee() { ID = 2, Name = "Stathis2" });

            var result = employeeCollection.Where(x => x.ID == 1);
            foreach (var item in result)
            {

            }
            var malakas = employeeCollection.WhereMalakas(x => x.ID == 2);
            var removed = employeeCollection.Remove(x => x.ID.Equals(2));
            foreach (var item in removed)
            {

            }
        }
    }

    public static class MyEnumerableExtensions
    {
        public static IEnumerable<T> WhereMalakas<T>(this IEnumerable<T> source, Predicate<T> predicate)
        {
            foreach (var item in source)
            {
                if (predicate(item))
                    yield return item;
            }
        }
        public static IEnumerable<T> Remove<T>(this IEnumerable<T> source,Predicate<T> predicate)
        {
            List<T> sourceList = new List<T>();
            foreach (var item in source)
            {
                sourceList.Add(item);
                if (predicate(item))
                {
                    sourceList.Remove(item);
                }
            }
            return sourceList;
        }
    }


    public class Employee
    {
        public int ID { get; set; }
        public string Name
        {
            get; set;
        }
    }

    public class EmployeeCollection : IEnumerable<Employee>
    {
        private Employee[] data;
        private int index = 0;
        public EmployeeCollection()
        {
            this.data = new Employee[4];
        }

        public void Add(Employee employee)
        {
            data[index] = employee;
            index++;
        }

        public IEnumerator<Employee> GetEnumerator()
        {
            for (int i = 0; i < index; i++)
            {
                yield return data[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    public class EmployeeCollectionEnumerator : IEnumerator<Employee>
    {
        readonly Employee[] employees;
        private int index;
        public EmployeeCollectionEnumerator(Employee[] employees)
        {
            this.employees = employees;
            this.index = -1;
        }

        public Employee Current => employees[index];
        object IEnumerator.Current => this.Current;

        public void Dispose()
        {

        }

        public bool MoveNext()
        {
            if (index > this.employees.Length - 1)
                return false;
            index++;
            return true;
        }

        public void Reset()
        {
            index = 0;
        }
    }
}
