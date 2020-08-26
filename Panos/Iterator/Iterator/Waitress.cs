namespace Iterator
{
    public class Waitor
    {
        PanCakeHouseMenu PanCakeHouseMenu;
        DinerMenu DinerMenu;

        public Waitor(PanCakeHouseMenu panCakeHouseMenu, DinerMenu dinerMenu)
        {
            PanCakeHouseMenu = panCakeHouseMenu;
            DinerMenu = dinerMenu;
        }

        public void PrintMenu()
        {
            Iterator pancakeIterator = PanCakeHouseMenu.CreateIterator();
            Iterator dinnerIterator = DinerMenu.CreateIterator();
            System.Console.WriteLine($"BREAKFAST\n\n\n\n");
            PrintMenu(pancakeIterator);
            System.Console.WriteLine("DINNER");
            PrintMenu(dinnerIterator);
        }

        private void PrintMenu(Iterator iterator)
        {
            while (iterator.HasNext())
            {
                MenuItem menuItem = (MenuItem)iterator.Next();
                System.Console.WriteLine(menuItem.GetName() + ", ");
                System.Console.WriteLine(menuItem.GetPrice() + " -- ");
                System.Console.WriteLine(menuItem.GetDescription());
            }
        }
    }
}
