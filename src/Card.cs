namespace PlayingCardsExtensions
{
    /// <summary>
    /// Base class for defining a Card object
    /// </summary>
    public abstract class Card
    {
        /// <summary>
        /// Returns a string with relevant information to recognize the specified card
        /// </summary>
        /// <returns></returns>
        public virtual string GetName()
        {
            return "";
        }
    }
}
