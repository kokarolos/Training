namespace BankProject
{
    public interface ICard
    {
        string Type { get; }
        void Withdraw(decimal amount);
        void Deposit(decimal amount);
    }
}
