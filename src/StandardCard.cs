using System;

namespace PlayingCardsExtensions
{
    /// <summary>
    /// A standard 52-card deck card / French-suited playing card
    /// </summary>
    public class StandardCard : Card
    {
        /// <summary>
        /// Initialize a standard 52-card deck card / French-suited playing card. Jokers, when any, assume the values of 0 for score and suit.
        /// </summary>
        /// <param name="score"></param>
        /// <param name="suit"></param>
        public StandardCard(int score, Suit suit)
        {
            Score = score;
            Suit = suit;
        }

        public int Score { get; }
        public Suit Suit { get; }

        public override string GetName()
        {
            Type suitType = Suit.GetType();
            
            return Score > 0
                ? $"{GetScore()} of {Enum.GetName(suitType, this.Suit)}"
                : GetScore();
        }

        /// <summary>
        /// Returns a string with the score value of the card, identifying it by the figure name instead of the number value
        /// </summary>
        /// <returns></returns>
        public string GetScore() => Score switch
        {
            0 => "Joker",
            1 => "Ace",
            11 => "Jack",
            12 => "Queen",
            13 => "King",
            _ => Score.ToString()
        };
    }
}
