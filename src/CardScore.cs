namespace PlayingCardsExtensions
{
    public struct CardScore
    {
        public CardScore(short value)
        {
            Value = value;
        }

        public short Value { get; }

        public static implicit operator CardScore(short value)
        {
            return new CardScore(value);
        }
    }
}
