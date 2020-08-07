namespace DucksProject
{
    public abstract class Duck
    {
        public abstract float Weigth { get; }
        public IQuackable _quackingMethod;
        public IFlyable _flyingMethod;

        public void SetQuackingMethod(IQuackable quackingMethod)
        {
            _quackingMethod = quackingMethod;
        }
        public void SetFlyingMethod(IFlyable flyingMethod)
        {
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
