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
            Console.WriteLine("Guess what animal I'm thinking of...");
            string animal = Console.ReadLine();
            bool isGuessed = animal == "cat";

            do
            {
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

            while (animal == "cat")
            {
                Console.Clear();
                Console.WriteLine("CONGRATS");
                Console.ReadLine();
            }
        }
    }
}
