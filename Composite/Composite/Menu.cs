using System;
using System.Collections.Generic;

namespace Composite
{
    public class Menu : MenuComponent
    {
        private List<MenuComponent> _menuComponents = new List<MenuComponent>();

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

        public override void Print()
        {
            Console.Write($"{_name}");
            Console.WriteLine($", {_description}");
            Console.WriteLine($"---------------------------");
            var iterator = _menuComponents.GetEnumerator();
            while (iterator.MoveNext())
            {
                var menuComponent = iterator.Current as MenuComponent;
                menuComponent.Print();
            }

        }
    }
}