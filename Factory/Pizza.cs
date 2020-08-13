using System;
using System.Collections.Generic;

namespace Factory
{
    public abstract class Pizza 
    {
        public string Name { get; set; }
        public IDough Dough { get; set; }
        public ISauce Sauce { get; set; }
        public List<IVegetable> Veggies { get; set; } = new List<IVegetable>();
        public ICheese Cheese { get; set; }
        public IClam Clam { get; set; }

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
