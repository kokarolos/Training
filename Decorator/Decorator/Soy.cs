using System;
using Decorator;

public class Soy : BeverageDecorator
{
    private Beverage _beverage;

    public Soy(Beverage beverage)
    {
        _beverage = beverage;
        Console.WriteLine($"{GetDescription()} added");
    }

    public override decimal Cost()
    {
        return _beverage.Cost() + 0.55M;
    }
}