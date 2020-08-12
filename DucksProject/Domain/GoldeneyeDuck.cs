namespace DucksProject
{
    public class GoldeneyeDuck : Duck
    {
        public GoldeneyeDuck(IFlyable flyingMethod, IQuackable quackingMethod) : base(flyingMethod, quackingMethod)
        {

        }

        public override float Weight { get => 1.2f; }
    }
}
