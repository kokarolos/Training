using System;

namespace Factory
{
    public abstract class PizzaStore
    {
        public Pizza OrderPizza(string type)
        { 
            var pizza = CreatePizza(type.ToLower());
            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();
            return pizza;
        }
        public abstract Pizza CreatePizza(string type);
    }
}

