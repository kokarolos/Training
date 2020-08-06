using System;

namespace BankProject
{
    public class CardFactory
    {
        public static ICard Create(Type CardType)
        {
            ICard card = Activator.CreateInstance(CardType) as ICard;
            return card;
        }
    }
}
