namespace DucksProject
{
    public class ScoterDuck : Duck
    {
        public ScoterDuck(IFlyable flyingMethod, IQuackable quackingMethod) : base(flyingMethod, quackingMethod)
        {
        }

        public override float Weight { get => 0.1f; }
    }
}
