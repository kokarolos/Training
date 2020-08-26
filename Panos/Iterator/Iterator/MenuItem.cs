namespace Iterator
{
    public class MenuItem 
    {
        string Name;
        string description;
        bool vegeterian;
        double price;

        public MenuItem(string name, string description, bool vegeterian, double price)
        {
            Name = name;
            this.description = description;
            this.vegeterian = vegeterian;
            this.price = price;
        }

        public string GetName()
        {
            return this.Name;
        }

        public string GetDescription()
        {
            return this.description;
        }

        public double GetPrice()
        {
            return price;
        }

        public bool IsVegetarian()
        {
            return vegeterian;
        }

    }
}
