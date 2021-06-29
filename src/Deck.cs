using System;
using System.Collections.Generic; 

namespace PlayingCardsExtensions
{
    public class Deck<T> where T : Card
    {
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

        public T Draw()
        {
            T card = Cards[0];
            Cards.RemoveAt(0);
            return card;
        }

        public List<T> Draw(int quantity = 1)
        {
            List<T> cards = Cards.GetRange(0, quantity);
            Cards.RemoveRange(0, quantity);
            return cards;
        }

        public (IEnumerable<T> top, IEnumerable<T> bottom) Slice()
        {
            int mid = (int)Math.Floor((double)Cards.Count / 2);
            return Slice(mid);
        }

        public (IEnumerable<T> top, IEnumerable<T> bottom) Slice(int index)
        {
            return (Cards.GetRange(0, index), Cards.GetRange(index + 1, Cards.Count - 1));
        }

        public void AddCard(T card, int index = 0)
        {
            Cards.Insert(index, card);
        }

        public void AddCards(IEnumerable<T> cards, int index = 0)
        {
            Cards.InsertRange(index, cards);
        }
    }
}
