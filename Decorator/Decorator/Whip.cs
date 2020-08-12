using System;
using Decorator;

public class Whip : BeverageDecorator
{
    private Beverage _beverage;

    public Whip(Beverage beverage)
    {
        _beverage = beverage;
        _description = "Whip ";
    }

    public override decimal Cost()
    {
        return _beverage.Cost() + 1.25M;
    }
    public override string GetDescription()
    {
        return _beverage.GetDescription() + _description;
    }
}
