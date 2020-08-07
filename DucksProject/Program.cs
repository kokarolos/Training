namespace DucksProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Duck d1 = new GoldeneyeDuck();
            d1.SetQuackingMethod(new QuackingFast());
            d1.SetFlyingMethod(new FlyingWithWings());
            d1.Quack();
            d1.Fly();

            Duck d2 = new DuckCall();
            d2.SetQuackingMethod(new QuackingLoud());
            d2.SetFlyingMethod(new FlyNoWay());
            d2.Quack();
            d2.Fly();
        }

        public class DuckCall : Duck
        {
            public override float Weigth => 2.5f;
        }
    }
}
