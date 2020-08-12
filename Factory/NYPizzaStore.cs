using System;

namespace Factory
{
    public class NYPizzaStore : PizzaStore
    {
        public override Pizza CreatePizza(Type type)
        {
            return Activator.CreateInstance(type) as Pizza;
        }
    }
}
