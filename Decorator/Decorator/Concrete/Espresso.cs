using Decorator;

public class Espresso : Beverage
{
    public override decimal Cost()
    {
        return 5.25M;
    }

    public override string GetDescription()
    {
        return "Esspresso, ";
    }
}