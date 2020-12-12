using System;
using System.Collections.Generic;

namespace CardGame
{
    class Program
    {
        static void Main(string[] args)
        {

            Poker cards = new Poker();

            var hand = cards.DealCard();

            foreach (var card in hand)
            {
                Console.WriteLine($"{card.Suit.ToString() } {card.Value.ToString()}");
            }


            Console.ReadLine();
           
           
        }
    }
}
