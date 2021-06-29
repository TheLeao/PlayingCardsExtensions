namespace PlayingCardsExtensions.Games.Uno
{
    public class UnoCard : Card
    {
        public UnoCard(int value, CardColor color)
        {
            Value = value;
            Color = color;
        }

        public int Value { get; }
        public CardColor Color { get; }

        public override string GetName()
        {
            return $"{GetColor()} {GetValue()}";
        }

        public string GetValue() => Value switch
        {
            10 => "Skip",
            11 => "Reverse",
            12 => "Draw Two",
            13 => "Wild",
            14 => "Wild Draw Four",
            _ => Value.ToString()
        };

        public string GetColor()
        {
            return System.Enum.GetName(this.Color.GetType(), this.Color);
        }
    }
}
