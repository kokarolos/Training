using System;
using System.Collections.Generic;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }

    public class Menu : MenuComponent
    {
        private List<MenuComponent> _menuComponents = new List<MenuComponent>();
        private string _name;
        private string _description;

        public Menu(string name, string description)
        {
            _name = name;
            _description = description;
        }

        public override void Add(MenuComponent menuComponent)
        {
            _menuComponents.Add(menuComponent);
        }

        public override MenuComponent GetChild(int i) => _menuComponents[i];

        public override void Remove(MenuComponent menuComponent)
        {
            _menuComponents.Remove(menuComponent);
        }

        public override string GetDescription()
        {
            return _description;
        }

        public override string GetName()
        {
            return _name;
        }

        public override double GetPrice()
        {
            throw new NotImplementedException();
        }

        public override bool IsVegetarian()
        {
            throw new NotImplementedException();
        }

        public override void Print()
        {
            Console.Write($"{GetName()}");
            Console.WriteLine($", {GetDescription()}");
            Console.WriteLine($"---------------------------");
        }
    }

    public class MenuItem : MenuComponent
    {
        private string _name;
        private string _description;
        private bool _vegetarian;
        private double _price;

        public MenuItem(string name, string description, bool vegetarian, double price)
        {
            _name = name;
            _description = description;
            _vegetarian = vegetarian;
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

        public override string GetDescription()
        {
            throw new NotImplementedException();
        }

        public override string GetName()
        {
            throw new NotImplementedException();
        }

        public override double GetPrice()
        {
            throw new NotImplementedException();
        }

        public override bool IsVegetarian()
        {
            throw new NotImplementedException();
        }

        public override void Print()
        {
            Console.Write($"{GetName()}");
            if (IsVegetarian())
                Console.WriteLine("(V)");
            Console.WriteLine($"{GetPrice()}");
            Console.WriteLine($"  ----------  {GetDescription()}");
        }

        public override void Remove(MenuComponent menuComponent)
        {
            throw new NotImplementedException();
        }
    }

    public abstract class MenuComponent
    {
        public abstract void Add(MenuComponent menuComponent);
        public abstract void Remove(MenuComponent menuComponent);
        public abstract MenuComponent GetChild(int i);

        public abstract string GetName();
        public abstract string GetDescription();
        public abstract double GetPrice();
        public abstract bool IsVegetarian();
        public abstract void Print();
    }
}