using System;
using System.Collections.Generic;

namespace Factory
{
    public abstract class Pizza
    {
        public string Name { get; set; }
        public string Dough { get; set; }
        public string Sauce { get; set; }
        public List<string> Toppings { get; set; } = new List<string>();

        public void Prepare()
        {
            Console.WriteLine($"Preparing {GetType().Name} pizza... ");
            Console.WriteLine("Tossing Dough.... ");
            Console.WriteLine("Adding Sauce....");
            Console.WriteLine("Adding toppings....");
            foreach (var topping in Toppings)
            {
                Console.WriteLine($"{topping} added..");
            }
        }
        public void Bake()
        {
            Console.WriteLine($"Baking {GetType().Name} fore 25 minutes at 350C");
        }
        public void Cut()
        {
            Console.WriteLine($"Cutting {GetType().Name} into diagonal slices");
        }
        public void Box()
        {
            Console.WriteLine($"Placing {GetType().Name} in official PizzaStore box");
        }
    }
}
