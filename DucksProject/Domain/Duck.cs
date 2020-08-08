namespace DucksProject
{
    public abstract class Duck
    {
        public abstract float Weigth { get; }
        public IQuackable _quackingMethod;
        public IFlyable _flyingMethod;

        public Duck(IFlyable flyingMethod, IQuackable quackingMethod)
        {
            _quackingMethod = quackingMethod;
            _flyingMethod = flyingMethod;

        }

        public void Quack()
        {
            _quackingMethod.Quack();
        }
        public void Fly()
        {
            _flyingMethod.Fly();
        }

    }
}
