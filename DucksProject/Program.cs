namespace DucksProject
{
    partial class Program
    {
        static void Main(string[] args)
        {
            Duck d1 = new GoldeneyeDuck();
            d1.SetQuackingMethod(new QuackingFast());
            d1.SetFlyingMethod(new FlyingWithWings());
            d1.Quack();
            d1.Fly();

            DuckCall d2 = new DuckCall();
            d2.Quack();
            
        }
    }
}
