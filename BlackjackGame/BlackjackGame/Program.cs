
using System;
using Casino;
using Casino.BlackjackGame;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data.SqlClient;

namespace Blackjack //renamed from BlackjackGame to make program runnable
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine("Welcome to Clams Casino! Please enter your name:");
            string playerName = Console.ReadLine();

            bool validAnswer = false;
            int bank = 0;
            while (!validAnswer)
            {
                Console.Write("How much money will you be betting today ?\n$");
                validAnswer = int.TryParse(Console.ReadLine(), out bank);
                if (!validAnswer) Console.WriteLine("Please enter digits only, no decimals.");
            }


            Console.WriteLine("Hello, {0}, would you like to join a game of Blackjack? (y/n)", playerName);
            string answer = Console.ReadLine().ToLower();

            if (answer == "y")
            {
                Player player = new Player(playerName, bank);
                player.Id = Guid.NewGuid(); //Globally Unique IDentifier
                using (StreamWriter file = new StreamWriter(@"C:\Users\saman\Desktop\BlackjackGameLog.txt", true)) //'true' appends to the file
                {
                    file.WriteLine(player.Id);
                }
                Game game = new BlackjackGame(); //polymorphism to inherit Game properties
                game += player; //player added to game
                player.isActivelyPlaying = true;
                while (player.isActivelyPlaying && player.Balance > 0)
                {
                    try
                    {
                        game.Play();
                    }
                    catch (FraudException)
                    {
                        Console.WriteLine("Hands behind your back! You're outta here, ya cheater!");
                        Console.ReadLine();
                        return;
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Oops, an error occured. Contact your system administrator.");
                        Console.ReadLine();
                        return;
                    }
                    
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

        //updating database with exception catches
        private static void UpdateDbWithException(Exception ex) //will catch all exceptions; polymorphism
        {
            string connectionString = @"Data Source=(localdb)\ProjectsV13;Initial Catalog=BlackjackGame;Integrated Security=True;
                                        Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;
                                        MultiSubnetFailover=False";

            string queryString = @"INSERT INTO Exceptions (ExceptionType, ExceptionMessage, TimeStamp) VALUES
                (@ExceptionType, @ExceptionMessage, @TimeStamp)"; //placeholders to be sub with actual values; protects datatype of SQL injections 

            using (SqlConnection connection = new SqlConnection(connectionString)) //'using' helps with managing and controlling memory
            {
                SqlCommand command = new SqlCommand(queryString, connection);
            }
        }
    }
}

// you stopped at 6:40 on step 395, but rewatch video
