using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoWhileAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Animal guessing 'game'
            Console.WriteLine("Guess what animal I'm thinking of...");
            string animal = Console.ReadLine();
            // Animal to guess is "cat"
            bool isGuessed = animal == "cat";

            do
            {
                // Switch to catch different user inputs
                switch (animal)
                {
                    case "dog":
                        Console.WriteLine("Nope. Try again, perhaps the opposite...");
                        Console.WriteLine("Guess what animal I'm thinking of...");
                        animal = Console.ReadLine();
                        break;
                    case "cat":
                        Console.WriteLine("You got it!");
                        isGuessed = true;
                        break;
                    default:
                        Console.WriteLine("Try again.");
                        Console.WriteLine("Guess what animal I'm thinking of...");
                        animal = Console.ReadLine();
                        break;
                }
            } 
            while (!isGuessed);
            Console.Read();

            // Congrats after 'game' is over
            while (animal == "cat")
            {
                Console.Clear();
                Console.WriteLine("CONGRATS");
                Console.ReadLine();
            }
        }
    }
}
