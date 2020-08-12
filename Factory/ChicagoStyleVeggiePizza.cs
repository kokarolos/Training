namespace Factory
{
    public class ChicagoStyleVeggiePizza : Pizza
    {
        public ChicagoStyleVeggiePizza()
        {
            Name = "Chicago Style Vegan Pizza";
            Dough = "Carrot Dough";
            Sauce = "Plum Double Tomato Sauce";
            Toppings.Add("Extra Onnions");
        }
    }

}
