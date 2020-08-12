using System;

namespace Factory
{
    public class ChicagoStyleClamPizza : Pizza
    {
        public ChicagoStyleClamPizza()
        {
            Name = "Chicago Style Deep Dish Clam Pizza";
            Dough = "Extra Double Thick Crust Dough";
            Sauce = "Plum Double Tomato Sauce";
            Toppings.Add("Shredded Mozzarella Cheese");
            Toppings.Add("Mushrooms");
            Toppings.Add("Shredded Reggato Cheese");
        }
        public new void Cut()
        {
            Console.WriteLine($"Cutting the pizza into triangle slices");
        }
    }

}
