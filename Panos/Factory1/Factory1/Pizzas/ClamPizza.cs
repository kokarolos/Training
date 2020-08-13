using Factory1.IngredientFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory1.Pizzas
{
    class ClamPizza : Pizza
    {
        PizzaIngredientFactory ingredientFactory;

        public ClamPizza(PizzaIngredientFactory ingredientFactory)
        {
            this.ingredientFactory = ingredientFactory;
        }

        public override void Prepare()
        {
            Console.WriteLine($"Preparing {Name}");
            Dough = ingredientFactory.CreateDough();
            Sauce = ingredientFactory.CreateSauce();
        }
    }


}
