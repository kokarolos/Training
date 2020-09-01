using System;

namespace Composite
{
    public class MenuItem : MenuComponent
    {
        public MenuItem(string name, string description, bool vegetarian, decimal price)
        {
            _name = name;
            _description = description;
            _isVegetarian = vegetarian;
            _price = price;
        }

        public override void Add(MenuComponent menuComponent)
        {
            throw new NotImplementedException();
        }

        public override MenuComponent GetChild(int i)
        {
            throw new NotImplementedException();
        }

        public override void Print()
        {
            Console.Write($"{_name}");
            if (_isVegetarian)
                Console.WriteLine("(V)");
            Console.WriteLine($"{_price}");
            Console.WriteLine($"  ----------  {_description}");
        }

        public override void Remove(MenuComponent menuComponent)
        {
            throw new NotImplementedException();
        }
    }
}