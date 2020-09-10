using System.Collections.Generic;

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

        public override void AddToBasket()
        {
            throw new System.NotImplementedException();
        }

        public override void Empty()
        {
            throw new System.NotImplementedException();
        }

        public override void GetBasketFor()
        {
            throw new System.NotImplementedException();
        }
    }

    public abstract class BasketRepository
    {
        public abstract void AddToBasket();
        public abstract void Empty();
        public abstract void GetBasketFor();
    }
}
