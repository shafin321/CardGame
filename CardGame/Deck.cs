using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CardGame
{
  public abstract class Deck
    {
        public  List<PlayingCard> fullDeck = new List<PlayingCard>();
        public List<PlayingCard> drawPile = new List<PlayingCard>();// take card from the deck 
        public List<PlayingCard> discardPile = new List<PlayingCard>();

        public  void CreateDeck()
        {
            for(int suit =0; suit<4; suit++)
            {
                for(int val=0; val<13; val++)
                {

                    fullDeck.Add(new PlayingCard { Suit = (CardSuite)suit, Value = (CardValue)(val) }); //casting int to enum value
                }
                             
            }

                                              

        }

        public void ShuffleDeck()
        {
            var rnd = new Random();
            drawPile = fullDeck.OrderBy(x => rnd.Next()).ToList();
        }

        public abstract List<PlayingCard> DealCard();
       

        public PlayingCard RequestCard()
        {
            PlayingCard card = drawPile.Take(1).First();
            drawPile.Remove(card);

            return card;
        }

        
    }

    public class Poker : Deck
    {
        public Poker()
        {
            CreateDeck();
            ShuffleDeck();
        }
        public override List<PlayingCard> DealCard()
        {
            List<PlayingCard> cards = new List<PlayingCard>();

            for(int i=0; i < 4; i++)
            {
                cards.Add(RequestCard());
            }

            return cards;
        }
    }

    public class BlackJack : Deck
    {
        public override List<PlayingCard> DealCard()
        {
            List<PlayingCard> cards = new List<PlayingCard>();

            for(int i=0; i<2; i++)
            {
                cards.Add(RequestCard());
            }

            return cards;
            
            
        }
    }
}
