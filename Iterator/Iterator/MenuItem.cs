namespace Iterator
{
    public class MenuItem
    {
        private string _name;
        private string _description;
        private bool _vegeterian;
        private double _price;

        public MenuItem(string name, string description, bool isVegeterian, double price)
        {
            _name = name;
            _description = description;
            _vegeterian = isVegeterian;
            _price = price;
        }
        public string GetName()
        {
            return _name;
        }

        public string GetDescription()
        {
            return _description;
        }

        public double GetPrice()
        {
            return _price;
        }

        public bool IsVegeterian()
        {
            return _vegeterian;
        }
    }
}
