using System;
using System.Collections.Generic;

namespace Factory
{
    public abstract class Pizza 
    {
        public string Name { get; set; }
        public Dough Dough { get; set; }
        public Sauce Sauce { get; set; }
        public List<Vegetable> Veggies { get; set; } = new List<Vegetable>();
        public Cheese Cheese { get; set; }
        public Clam Clam { get; set; }

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

        public abstract void Prepare();
    }
}
