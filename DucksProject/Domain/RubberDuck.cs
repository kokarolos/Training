namespace DucksProject
{
    public class RubberDuck : Duck
    {
        public RubberDuck(IFlyable flyingMethod, IQuackable quackingMethod) : base(flyingMethod, quackingMethod)
        {
        }

        public override float Weight { get => 1.0f; }
    }
}
