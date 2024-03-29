﻿namespace PlayingCardsExtensions
{
    public class StandardDeck : Deck<StandardCard>
    {
        /// <summary>
        /// Initialize a standard 52-card deck
        /// </summary>
        /// <param name="jokers"></param>
        public StandardDeck(bool jokers = false)
        {
            for (int i = 1; i < 5; i++)
            {
                Suit suit = (Suit)i;
                
                for (int j = 1; j < 14; j++)
                {
                    Cards.Add(new StandardCard(j, suit));
                }
            }

            if (jokers)
            {
                Cards.Add(new StandardCard(0, 0));
                Cards.Add(new StandardCard(0, 0));
            }
        }
    }
}
