namespace PeopleSorting
{
    public class Child : ISortable
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Child(int id)
        {
            Id = id;
        }
    }
}