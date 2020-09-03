// IPaymentReceipt


namespace Payment_Proxy
{
    public interface IpaymentReceipt
    {
        Order Order { get; set; }
        Receipt Receipt { get; set; }
    }
}