namespace Factory1
{
    public abstract class PizzaStore 
    {
        public Pizza OrderPizza(string type)
        {
            Pizza pizza;
            pizza = this.CreatePizza(type);
            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();
            return pizza;
        }
        protected abstract Pizza CreatePizza(string type);
    }


}
