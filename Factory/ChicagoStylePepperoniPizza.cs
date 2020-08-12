namespace Factory
{
    public class ChicagoStylePepperoniPizza : Pizza
    {
        public ChicagoStylePepperoniPizza()
        {
            Name = "Chicago Style Pepperoni Pizza";
            Dough = "Philadelphia Double Thick Crust Dough";
            Sauce = "Plum Double Tomato Sauce";
            Toppings.Add("Extra Chili Cheese");
        }
    }

}
