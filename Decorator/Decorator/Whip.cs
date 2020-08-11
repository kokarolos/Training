using System;
using Decorator;

public class Whip : BeverageDecorator
{
    private Beverage _beverage;

    public Whip(Beverage beverage)
    {
        _beverage = beverage;
        Console.WriteLine($"{GetDescription()} added");
    }

    public override decimal Cost()
    {
        return _beverage.Cost() + 1.25M;
    }
}
