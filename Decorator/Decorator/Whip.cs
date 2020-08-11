using Decorator;

public class Whip : CondimentDecorator
{
    private Beverage _beverage;

    public Whip(Beverage beverage)
    {
        _beverage = beverage;
    }

    public override decimal Cost()
    {
        return _beverage.Cost() + 1.25M;
    }
}
