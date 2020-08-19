namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            WildTurkey turkey = new WildTurkey();
            IDuck turkeyAdapter = new TurkeyAdapter(turkey);
            turkey.Gobble();
            turkey.Fly();
            turkeyAdapter.Quack();
            turkeyAdapter.Fly();
        }
    }
}
