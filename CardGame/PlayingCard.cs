using System;
using System.Collections.Generic;
using System.Text;

namespace CardGame
{
   public class PlayingCard
    {
        public CardSuite Suit { get; set; }
        public CardValue Value { get; set; }
    }

    public enum CardSuite
    {
        Hearts,
        Clubs,
        Diamonds,
        Speades
    }
    public enum CardValue
    {
        Ace,
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nice,
        Ten,
        Jack,
        Queen,
        King

        
    }
}
