namespace Factory1
{
    public class NYCheesePizza : Pizza
    {
        public NYCheesePizza()
        {
            dough = "Extra Thick Crust dough";
            sauce = "Plum Tomato Sauce";

            Toppings.Add(Factory1.Toppings.Cheese);
            Toppings.Add(Factory1.Toppings.Onion);
        }

        public override void Cut()
        {
            System.Console.WriteLine("Cutting pizza into square pieces");
        }

        
    }
}
