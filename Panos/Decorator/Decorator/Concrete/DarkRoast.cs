namespace Decorator
{
    public class DarkRoast : Beverage
    {
        public DarkRoast()
        {
<<<<<<< HEAD
            Description = GetType().Name; 
=======
            description = "DarkRoast";
>>>>>>> e123ccebe6330cd2f4e9354ad7523224d75d6888
        }
        public override decimal Cost()
        {
            return 0.40m;
        }
    }
}
