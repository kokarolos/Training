using System.Collections.Generic;
using System.Security.Principal;
using System.Threading;

namespace DICode
{
    class Program
    {
        static void Main(string[] args)
        {
          
        }
    }

    public class Basket
    {
        public string Owner { get; set; }
        public List<Extent> EvaluatedProducts { get; set; }

    }

    public class Extent
    {
        string Product { get; set; }
        public int Quantity { get; set; }
        public decimal Total { get; set; }
    }

    public abstract class BasketDiscountPolicy
    {
        public abstract void Apply();
    }

    public class BasketService : BasketRepository
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

    public abstract class BasketRepository
    {
        public abstract void AddToBasket();
        public abstract void Empty();
        public abstract void GetBasketFor();
    }

    public class DefaultProductDiscountPolicy : BasketDiscountPolicy
    {
        public override void Apply()
        {
            throw new System.NotImplementedException();
        }
    }
    public abstract class DiscountRepository
    {
        public abstract void GetDiscountedProducts();
    }

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
