using System;

namespace Sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            ISortable[] employees = new Employee[]
            {
                new Employee(1,"Karol","Koniewicz"),
                new Employee(3,"Panos","Rizos"),
                new Employee(6,"Takis","Makis"),
                new Employee(8,"Giannis","Paris"),
                new Employee(2,"Giannis","Paris"),
                new Employee(4,"Aris","Papadopoulos"),
                new Employee(5,"Maria","Sakellariou"),
            };
            SortingManager.Sort(employees,new BubbleSort());
            foreach (var employee in employees)
            {
                Console.WriteLine(employee.Id);
            }
        }
    }
}
