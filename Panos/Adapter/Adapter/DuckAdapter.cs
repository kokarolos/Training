namespace Adapter
{
    partial class Program
    {
        public class DuckAdapter : Turkey
        {
            Duck Duck; 

            public DuckAdapter(Duck duck)
            {
                Duck = duck;
            }

            public void fly()
            {
                Duck.Fly();
            }

            public void Gobble()
            {
                Duck.Quack();
            }
        }
    }
}
