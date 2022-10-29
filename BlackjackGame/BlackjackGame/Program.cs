
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackjackGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //Game game = new BlackjackGame(); <- polymorphism example
            BlackjackGame game = new BlackjackGame();
            game.Players = new List<string>() { "Janet", "Jackie", "Lydia" };
            game.ListPlayers();
            Console.ReadLine();

            Deck deck = new Deck();
            deck.Shuffle(3);

            foreach (Card card in deck.Cards) //displays cards, card count, and times shuffled
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }
            Console.WriteLine(deck.Cards.Count);
            Console.ReadLine();
        }
    }
}
