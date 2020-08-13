namespace DesignPatterns
{
    public class DecoyDuck :Duck
    {
        public DecoyDuck(IFlyable flyable,IQuackable quackable)
        {
            this.flyable = flyable;
            this.quackable = quackable;
        }
    }
}
