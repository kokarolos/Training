namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            //MenuComponent pancakeMenu = new Menu("PancakeHouse Menu", "Breakfast");
            //MenuComponent dinnerMenu = new Menu("Diner Menu", "Lunch");
            //MenuComponent cafeMenu = new Menu("Cafe Menu", "Dinner");
            //MenuComponent dessertMenu = new Menu("Desert Menu", "Dessert of course?");
            //MenuComponent allMenus = new Menu("ALL MENUS", "ALL menus combined!");

            //allMenus.Add(pancakeMenu);
            //allMenus.Add(dinnerMenu);
            //allMenus.Add(cafeMenu);
            //allMenus.Add(dessertMenu);

            //dinnerMenu.Add(new MenuItem("Pasta", "Spaghetti with marinara Sauce, and a slice of sourdough bread", true, 3.89M));
            //dinnerMenu.Add(dessertMenu);
            //dessertMenu.Add(new MenuItem("Apple pie", "Apple pie with a flakey crust, topped with vanilla icecream", true, 1.59M));

            //var waitress = new Waitress(allMenus);
            //waitress.Print();
            var dot = new Dot(1.5f, 2.5f);
            var dot1 = new Dot(2.5f, 212.5f);
            var dot2 = new Dot(71.5f, 225.5f);
            var dot3 = new Dot(21.5f, 5f);
            var ellipse = new Ellipse(102.0f, 195.2f);
            var compositeGraphic = new CompositeGraphic();

            compositeGraphic.Add(dot);
            compositeGraphic.Add(dot1);
            compositeGraphic.Add(dot2);
            compositeGraphic.Add(dot3);
            compositeGraphic.Add(ellipse);


            var painter = new Painter(compositeGraphic);
            painter.Paint();


        }

    }
}
