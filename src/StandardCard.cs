using System;

namespace PlayingCardsExtensions
{
    public class StandardCard : Card
    {
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
