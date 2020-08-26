namespace PeopleSorting
{
    public class Employe : ISortable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName{get; set;}

        public Employe(int id, string name, string lastName)
        {
            Id = id;
            Name = name;
            LastName = lastName;
        }
    }
}