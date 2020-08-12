namespace BankProject
{
    public class CreditCard : Card, ICard, ILoanable
    {
        public CreditCard()
        {

        }

        public void Loan(decimal amount)
        {
            Funds += amount;
        }
    }
}
