using System;

namespace Factory
{
    public abstract class PizzaStore
    {
        public Pizza OrderPizza(Type type)
        { 
            var pizza = CreatePizza(type);
            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();
            return pizza;
        }
        public abstract Pizza CreatePizza(Type type);
    }
}

