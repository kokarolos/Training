namespace DICode
{
    public class BasketService : BasketRepository, IBasketService
    {
        private BasketRepository _basketRepository;
        private BasketDiscountPolicy _basketDiscountPolicy;

        public BasketService(BasketRepository basketRepository, BasketDiscountPolicy basketDiscountPolicy)
        {
            _basketRepository = basketRepository;
            _basketDiscountPolicy = basketDiscountPolicy;
        }

        public override void AddToBasket()
        {
            _basketRepository.AddToBasket();
        }

        public override void Empty()
        {
            _basketRepository.Empty();
        }

        public override void GetBasketFor()
        {
            _basketRepository.GetBasketFor();
        }
    }
}
