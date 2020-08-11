using Decorator;
using System;

public class Milk : BeverageDecorator
{
    private Beverage _beverage;

    public Milk(Beverage beverage)
    {
        _beverage = beverage;
        Console.WriteLine($"{GetDescription()} added");
    }

    public override decimal Cost()
    {
        return _beverage.Cost() + 0.15M;
    }
}
