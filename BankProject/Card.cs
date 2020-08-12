using System;

namespace BankProject
{
    public abstract class Card 
    {
        public string Type => GetType().Name;
        public int Csv { get; set; }
        public string CardHolder { get; set; }
        public string Number { get; set; }
        public DateTime DueTo { get; set; }
        public decimal Funds { get; protected set; }

        /// <summary>
        /// Decreasing user's Funds
        /// </summary>
        /// <param name="amount"></param>

        public void Withdraw(decimal amount)
        {
            if (amount > Funds)
            {
                Console.WriteLine("Insufficient Funds Please refill");
            }
            else
            {
                Funds -= amount;
            }
        }

        /// <summary>
        /// Increasing user's Funds
        /// </summary>
        /// <param name="amount"></param>

        public void Deposit(decimal amount)
        {
            Funds += amount;
        }
    }
}
