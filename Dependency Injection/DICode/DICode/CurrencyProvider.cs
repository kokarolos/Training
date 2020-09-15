namespace DICode
{
    public abstract class CurrencyProvider
    {
        public abstract Currency GetCurrency(string currencyCode);
    }
}
