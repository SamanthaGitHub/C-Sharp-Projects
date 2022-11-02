
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BlackjackGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Clams Casino! Please enter your name:");
            string playerName = Console.ReadLine();

            Console.Write("How much money will you be betting today?\n$");
            int bank = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Hello, {0}, would you like to join a game of Blackjack? (y/n)", playerName);
            string answer = Console.ReadLine().ToLower();

            if (answer == "y")
            {
                Player player = new Player(playerName, bank);
                Game game = new BlackjackGame(); //polymorphism to inherit Game properties
                game += player; //player added to game
                player.isActivelyPlaying = true;
                while (player.isActivelyPlaying && player.Balance > 0)
                {
                    game.Play();
                }
                game -= player;
                Console.WriteLine("Thanks for playing!");
            }

            Console.WriteLine("Feel free to look around the casino. Bye for now!");
            Console.Read();




            //Game game = new BlackjackGame();                               <-- polymorphism example

            //Game game = new BlackjackGame();
            //game.Players = new List<Player>();
            //Player player = new Player();
            //player.Name = "Spam";
            //game += player; //kinda like a method? returns a game          <-- operator overloading
            //game -= player;

            //Deck deck = new Deck();                                          <-- original code
            //deck.Shuffle(3);

            //foreach (Card card in deck.Cards) //displays cards, card count, and times shuffled
            //{
            //    Console.WriteLine(card.Face + " of " + card.Suit);
            //}
            //Console.WriteLine(deck.Cards.Count);
            //Console.ReadLine();
        }
    }
}
