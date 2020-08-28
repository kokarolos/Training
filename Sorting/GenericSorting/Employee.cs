namespace GenericSorting
{
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