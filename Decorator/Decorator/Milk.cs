using Decorator;
using System;

public class Milk : BeverageDecorator
{
    private Beverage _beverage;

    public Milk(Beverage beverage)
    {
        _beverage = beverage;
        _description = "Milk, ";
    }

    public override decimal Cost()
    {
        return _beverage.Cost() + 0.15M;
    }

    public override string GetDescription()
    {
        return _beverage.GetDescription() + _description;
    }
}
