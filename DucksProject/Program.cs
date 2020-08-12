using System.Net.Http.Headers;

namespace DucksProject
{
    partial class Program
    {
        static void Main(string[] args)
        {
            Duck d1 = new GoldeneyeDuck(new FlyingWithWings(),new QuackingLoud());
            d1.Quack();
            d1.Fly();
            DuckCall d2 = new DuckCall();
            d2.Quack();
            
        }
    }
}
