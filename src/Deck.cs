using System;
using System.Collections.Generic; 

namespace PlayingCardsExtensions
{
    public class Deck<T> where T : Card
    {

        /// <summary>
        /// Initialize an empty deck of T cards
        /// </summary>
        public Deck()
        {
            Cards = new List<T>();
        }

        /// <summary>
        /// Initialize a deck with a predefined set of cards
        /// </summary>
        /// <param name="cards"></param>
        public Deck(List<T> cards)
        {
            Cards = cards;
        }

        public List<T> Cards { get; }

        /// <summary>
        /// Shuffle the current cards in the deck
        /// </summary>
        public void Shuffle()
        {
            var rng = new Random();
            var n = Cards.Count;
            while (n > 1)
            {
                n--;
                var k = rng.Next(n + 1);
                T value = Cards[k];
                Cards[k] = Cards[n];
                Cards[n] = value;
            }
        }

        /// <summary>
        /// Returns the card at position 0 of the deck and removes it
        /// </summary>
        /// <returns></returns>
        public T Draw()
        {
            T card = Cards[0];
            Cards.RemoveAt(0);
            return card;
        }

        /// <summary>
        /// Return a list of cards from the deck beginning at position 0
        /// </summary>
        /// <param name="quantity"></param>
        /// <returns></returns>
        public List<T> Draw(int quantity = 1)
        {
            List<T> cards = Cards.GetRange(0, quantity);
            Cards.RemoveRange(0, quantity);
            return cards;
        }

        /// <summary>
        /// Returns two sets of cards, corresponding to the top and bottom parts of the deck where it has been sliced.
        /// </summary>
        /// <returns></returns>
        public (IEnumerable<T> top, IEnumerable<T> bottom) Slice()
        {
            int mid = (int)Math.Floor((double)Cards.Count / 2);
            return Slice(mid);
        }

        /// <summary>
        /// Returns two sets of cards, corresponding to the top and bottom parts of the deck where it has been sliced.
        /// </summary>
        /// <param name="index">The dividing point to the make the slice</param>
        /// <returns></returns>
        public (IEnumerable<T> top, IEnumerable<T> bottom) Slice(int index)
        {
            return (Cards.GetRange(0, index), Cards.GetRange(index + 1, Cards.Count - 1));
        }

        /// <summary>
        /// Insert a card into the deck
        /// </summary>
        /// <param name="card"></param>
        /// <param name="index">The position to insert the card into</param>
        public void AddCard(T card, int index = 0)
        {
            Cards.Insert(index, card);
        }

        /// <summary>
        /// Inserts a set of cards into the deck
        /// </summary>
        /// <param name="cards"></param>
        /// <param name="index">The position to insert the cards into</param>
        public void AddCards(IEnumerable<T> cards, int index = 0)
        {
            Cards.InsertRange(index, cards);
        }
    }
}
