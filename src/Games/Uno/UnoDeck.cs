namespace PlayingCardsExtensions.Games.Uno
{
    public class UnoDeck : Deck<UnoCard>
    {
        public UnoDeck()
        {
            for (int i = 1; i < 5; i++)
            {
                CardColor color = (CardColor)i;

                //One zero of each color
                for (int j  = 0; j < 4; j++)
                {
                    Cards.Add(new UnoCard(0, color));
                }

                //two of the other numbers and action cards
                for (int j = 1; j < 13; j++)
                {
                    Cards.Add(new UnoCard(j, color));
                    Cards.Add(new UnoCard(j, color));
                }

                //Four of each Wild card (normal and Draw Four)
                Cards.Add(new UnoCard(13, CardColor.Wild));
                Cards.Add(new UnoCard(14, CardColor.Wild));
            }
        }
    }
}
