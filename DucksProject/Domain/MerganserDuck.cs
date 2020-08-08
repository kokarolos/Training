namespace DucksProject
{
    public class MerganserDuck : Duck
    {
        public MerganserDuck(IFlyable flyingMethod, IQuackable quackingMethod) : base(flyingMethod, quackingMethod)
        {
        }

        public override float Weigth { get => 1.5f; }
    }
}
