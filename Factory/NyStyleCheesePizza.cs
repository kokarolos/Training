namespace Factory
{
    public class NyStyleCheesePizza :Pizza
    {
        public NyStyleCheesePizza()
        {
            Name = "Ny Style Sauce and CheesePizza";
            Dough = "Thin Crust Dough";
            Sauce = "Marinara Sauce";
            Toppings.Add("Grated Reggiano Cheese");
        }

    }
}
