using Decorator;

public class Soy : BeverageDecorator
{
    private Beverage _beverage;

    public Soy(Beverage beverage)
    {
        _beverage = beverage;
        _description = "Soy, ";
    }

    public override decimal Cost()
    {
        return _beverage.Cost() + 0.55M;
    }
    public override string GetDescription()
    {
        return _beverage.GetDescription() + _description;
    }
}