namespace Adapter
{
    public class TurkeyAdapter : Duck
    {
        Turkey Turkey;

        public TurkeyAdapter(Turkey turkey)
        {
            Turkey = turkey;
        }

        public void Quack()
        {
            Turkey.Gobble();
        }

        public void Fly()
        {
            for (int i = 0; i < 5; i++)
            {
                Turkey.fly();
            }
        }
    }
}
