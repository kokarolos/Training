using System;

// IPaymentReceipt


namespace Payment_Proxy
{
    public class Order
    {
        public Guid OrderId { get; set; }
        public int CustomerId { get; set; }
        public decimal Amount { get; set; }
        public DateTime OrderDate { get; set; }
        public string CreditCard { get; set; }
        public string Expriration { get; set; }
    }
}