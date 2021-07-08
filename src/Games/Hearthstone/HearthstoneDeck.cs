using System.Collections.Generic;
using System.Text.Json;

namespace PlayingCardsExtensions.Games.Hearthstone
{
    public class HearthstoneDeck : Deck<HearthstoneCard>
    {
        public HearthstoneDeck()
        {

        }

        public HearthstoneDeck(string deckJson)
        {
            Cards = JsonSerializer.Deserialize<List<HearthstoneCard>>(deckJson);
        }

        public string Class { get; set; }
        public string Format { get; set; }
        public string Year { get; set; }
        public string DeckString { get; set; }
    }
}
