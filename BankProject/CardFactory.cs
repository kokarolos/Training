using System;

namespace BankProject
{
    public class CardFactory
    {
        public static ICard Create(Type CardType)
        {
            return Activator.CreateInstance(CardType) as ICard;
        }
    }
}
