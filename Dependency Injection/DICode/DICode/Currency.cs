namespace DICode
{
    public abstract class Currency
    {
        public abstract string Code { get; }
        public abstract decimal GetExchangeRateFor(string currencyCode);
    }
}
