using Decorator;

public class Soy : CondimentDecorator
{
    private Beverage _beverage;

    public Soy(Beverage beverage)
    {
        _beverage = beverage;
    }

    public override decimal Cost()
    {
        return _beverage.Cost() + 0.55M;
    }
}