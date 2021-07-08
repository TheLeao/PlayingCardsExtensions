using System.Text.Json;

namespace PlayingCardsExtensions.Games.Hearthstone
{
    /// <summary>
    /// Represents a Hearthstone card, with properties based on hearthstonejson.com API
    /// </summary>
    public class HearthstoneCard : Card
    {
        public HearthstoneCard()
        {
            
        }

        public HearthstoneCard(string cardString)
        {
            HearthstoneCard self = JsonSerializer.Deserialize<HearthstoneCard>(cardString);

            #region Assigning properties
            Id = self.Id;
            DbfId = self.DbfId;
            Name = self.Name;
            Artist = self.Artist;
            Attack = self.Attack;
            CardClass = self.CardClass;
            Classes = self.Classes;
            Collectible = self.Collectible;
            Cost = self.Cost;
            Durability = self.Durability;
            Elite = self.Elite;
            Faction = self.Faction;
            Flavor = self.Flavor;
            Health = self.Health;
            Mechanics = self.Mechanics;
            Race = self.Race;
            Rarity = self.Rarity;
            ReferencedTags = self.ReferencedTags;
            Set = self.Set;
            SpellSchool = self.SpellSchool;
            TargetingArrowText = self.TargetingArrowText;
            TechLevel = self.TechLevel;
            Text = self.Text;
            Type = self.Type;
            #endregion
        }

        public string Id { get; set; }
        public int DbfId { get; set; }
        public string Name { get; set; }
        public string Artist { get; set; }
        public int Attack { get; set; }
        public string CardClass { get; set; }
        public string[] Classes { get; set; }
        public bool Collectible { get; set; }
        public int Cost { get; set; }
        public int Durability { get; set; }
        public bool Elite { get; set; }
        /// <summary>
        /// Alliance or Horde or none/custom
        /// </summary>
        public string Faction { get; set; }
        public string Flavor { get; set; }
        public int Health { get; set; }
        /// <summary>
        /// Whether the card has the "dragon mark" on top
        /// </summary>
        public string[] Mechanics { get; set; }
        /// <summary>
        /// Name of the minion 'type'
        /// </summary>
        public string Race { get; set; }
        public string Rarity { get; set; }
        public string[] ReferencedTags { get; set; }
        public string Set { get; set; }
        public string SpellSchool { get; set; }
        public int TargetingArrowText { get; set; }
        public int TechLevel { get; set; }
        public string Text { get; set; }
        /// <summary>
        /// Type of card (i.e Minion, Spell, Weapon, Hero)
        /// </summary>
        public string Type { get; set; }

        public override string GetName()
        {
            return Name;
        }        
    }
}
