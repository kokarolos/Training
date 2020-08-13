using System.Collections.Generic;

namespace Factory
{
    public interface IChicagoIngredientFactory
    {
        Cheese CreateCheese();
        Clam CreateClam();
        Dough CreateDough();
        Pepperoni CreatePepperoni();
        Sauce CreateSauce();
        List<Vegetable> CreateVegetables();
    }

}
