using System.Collections.Generic;

namespace Factory
{
    public interface IPizzaIngredientFactory
    {
        IDough CreateDough();
        ISauce CreateSauce();
        ICheese CreateCheese();
        List<IVegetable> CreateVegetables();
        IPepperoni CreatePepperoni();
        IClam CreateClam();
    }

}
