using System;

// IPaymentReceipt


namespace Payment_Proxy
{
    public class Receipt
    {
        public Guid OrderId { get; set; }
        public decimal AmountPaid { get; set; }
        public DateTime DatePaid { get; set; }
        public string Confirmation { get; set; }
    }
}