using System;
using System.Linq;
using System.Reflection;

namespace BankProject
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var cards = Assembly.GetExecutingAssembly()
                                    .GetTypes()
                                    .Where(t =>
                                    {
                                        return typeof(ICard).IsAssignableFrom(t) && t.IsClass && (!t.IsAbstract);
                                    })
                                    .ToArray();
                var c1 = CardFactory.Create(cards[1]) as DebitCard;
                c1.Deposit(500);
                c1.Withdraw(250);

                Console.WriteLine($"{c1.Type} {c1.Funds}");
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
