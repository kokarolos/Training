using Factory1.IngredientFactory;
using System;
using System.Collections.Generic;

namespace Factory1
{
    public abstract class Pizza
    {
        public string Name => GetType().Name;
        protected Dough Dough;
        protected Sauce Sauce;
        protected Veggies[]Veggies;
        protected Cheese Cheese;
        protected Pepperoni Pepperoni;
        protected Clams Clam;

        public abstract void Prepare();

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
