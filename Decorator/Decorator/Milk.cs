using Decorator;

public class Milk : CondimentDecorator
{
    private Beverage _beverage;

    public Milk(Beverage beverage)
    {
        _beverage = beverage;
    }

    public override decimal Cost()
    {
        return _beverage.Cost() + 0.15M;
    }
}
