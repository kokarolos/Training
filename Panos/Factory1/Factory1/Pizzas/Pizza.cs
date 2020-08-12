using System;
using System.Collections.Generic;

namespace Factory1
{
    public abstract class Pizza
    {
        public string Name => GetType().Name;
        protected string dough;
        protected string sauce;
                
        protected List<Toppings> Toppings = new List<Toppings>();

        public void Prepare()
        {
            Console.WriteLine($"Pizza {Name} is preparing");
            Console.WriteLine($"Tossing dough");
            Console.WriteLine($"Adding sause");
            Console.WriteLine($"Adding Toppings : ");
            foreach (var topping in Toppings)
            {
                Console.WriteLine($"\t{topping}  ");
            }


        }
        public void Bake()
        {
            Console.WriteLine("Pizza is baking for 25 minutes at 350");
        }

        public virtual void Cut()
        {
            Console.WriteLine("Pizza is cut in diagonal pieces");
        }

        public void Box()
        {
            Console.WriteLine("Pizza is boxing");
        }

        public string Getname() => GetType().Name;
      

    }
}
