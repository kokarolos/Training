using System;

// IPaymentReceipt
namespace Payment_Proxy
{
    public class PaymentReceipt : IpaymentReceipt
    {
        public Order Order { get; set; }
        public Receipt Receipt
        {
            get { return GetReceipt(); }
        }

        private Receipt GetReceipt()
        {
            Receipt receipt = new Receipt();
            receipt.OrderId = Order.OrderId;
            receipt.AmountPaid = Order.Amount;
            receipt.Confirmation = "AG436757FG";
            receipt.DatePaid = DateTime.Now;

            return receipt;
        }
    }
}