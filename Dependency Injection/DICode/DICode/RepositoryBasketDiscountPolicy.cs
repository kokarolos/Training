namespace DICode
{
    public class RepositoryBasketDiscountPolicy : BasketDiscountPolicy
    {
        private DiscountRepository _discountRepository;
        public RepositoryBasketDiscountPolicy(DiscountRepository discountRepository)
        {
            _discountRepository = discountRepository;
        }
        public override void Apply()
        {
            throw new System.NotImplementedException();
        }
    }
}
