namespace Factory1
{
    class CHICheesePizza : Pizza
    {
        public CHICheesePizza()
        {
            dough = "Thin and Crust";
            sauce = "Marinara sauce";

            Toppings.Add(Factory1.Toppings.Cheese);
        }

    }
}
