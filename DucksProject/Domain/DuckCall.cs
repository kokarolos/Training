namespace DucksProject
{
    //Device that makes duck sounds
    public class DuckCall : IQuackable
    {
        private IQuackable _quackingMethod;

        public DuckCall()
        {
            _quackingMethod = new QuackingLoud(); //Tight Coupling : Because we know that DuckCall Quacking wont change (?)
        }

        public void Quack()
        {
            _quackingMethod.Quack();
        }
    }
}
