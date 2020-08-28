using System.Collections.Generic;
namespace SorttingEmployees
{
    public class EmployeesQuickSort : QuickSort<Employee>
    {
        protected override IComparer<Employee> GetComparer()
        {
            return SelectComparison(CompareWith.Id);
        }
        protected override IEnumerable<Employee> GetSource()
        {
            return new List<Employee>()
            {
                 new Employee() { ID = 0, Firstname = "Efstathios0", Lastname ="Chrysikos0"},
                 new Employee() { ID = 1, Firstname = "Efstathios1", Lastname ="Chrysikos1"},
                 new Employee() { ID = 9, Firstname = "afstathios9", Lastname ="Chrysikos9"},
                 new Employee() { ID = 3, Firstname = "Efstathios3", Lastname ="Chrysikos3"},
                 new Employee() { ID = 8, Firstname = "vfstathios8", Lastname ="Chrysikos8"},
                 new Employee() { ID = 7, Firstname = "cfstathios7", Lastname ="Chrysikos7"},
                 new Employee() { ID = 6, Firstname = "dfstathios6", Lastname ="Chrysikos6"},
                 new Employee() { ID = 5, Firstname = "Efstathios5", Lastname ="Chrysikos5"},
                 new Employee() { ID = 4, Firstname = "Efstathios4", Lastname ="Chrysikos4"},
                 new Employee() { ID = 2, Firstname = "Efstathios2", Lastname ="Chrysikos2"},
            };
        }
    }


}