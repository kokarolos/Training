using System;

namespace DICode
{
    //Assuming we are on ASP.NET Framework
    public class BasketController
    {
        private readonly IBasketService _basketService;
        private readonly CurrencyProvider _currencyProvider;

        public BasketController(IBasketService basketService, CurrencyProvider currencyProvider)
        {
            _basketService = basketService ?? throw new ArgumentNullException("BasketService ís null");
            _currencyProvider = currencyProvider ?? throw new ArgumentException("CurrencyProvider is null");
        }
    }
}
