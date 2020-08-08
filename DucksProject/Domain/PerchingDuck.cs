namespace DucksProject
{
    public class PerchingDuck : Duck
    {
        public PerchingDuck(IFlyable flyingMethod, IQuackable quackingMethod) : base(flyingMethod, quackingMethod)
        {

        }

        public override float Weigth { get => 0.2f; }
    }
}
