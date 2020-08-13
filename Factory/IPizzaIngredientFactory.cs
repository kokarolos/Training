using System.Collections.Generic;

namespace Factory
{
    public interface IPizzaIngredientFactory
    {
        Dough CreateDough();
        Sauce CreateSauce();
        Cheese CreateCheese();
        List<Vegetable> CreateVegetables();
        Pepperoni CreatePepperoni();
        Clam CreateClam();
    }

}
