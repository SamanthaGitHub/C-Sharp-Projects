using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Shipping quote for a package
namespace Branching
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            // Prompts user for package weight
            Console.WriteLine("Please provide package weight in pounds:");
            // Converts to decimal format
            decimal weight = Convert.ToInt32(Console.ReadLine());
            // Checks weight
            string weightResult = weight > 50 ? "Your package is too heavy." : "Package weight accepted. \"Enter\" to continue.";
            Console.WriteLine(weightResult);
            Console.ReadLine();
            if (weight <= 50)
            {
                // width
                Console.WriteLine("Please provide package width in inches:");
                decimal width = Convert.ToInt32(Console.ReadLine());

                // height
                Console.WriteLine("Please provide package height in inches:");
                decimal height = Convert.ToInt32(Console.ReadLine());

                // length
                Console.WriteLine("Please provide package length in inches:");
                decimal length = Convert.ToInt32(Console.ReadLine());

                // volume
                decimal volume = (width * height * length);

                // Checks package volume
                string volumeResult = volume > 50 ? "Your package is too big." : "Package size accepted.";
                Console.WriteLine(volumeResult);
                Console.ReadLine();

                if (volume <= 50)
                {
                    // Calculates quote
                    decimal calcQuote = volume * weight / 100;
                    decimal roundQuote = Math.Round(calcQuote, 2);
                    Console.WriteLine("Your estimated total is: $" + roundQuote);
                    Console.ReadLine();
                }
                else
                {
                    return;
                }
            }
            else
            {
                return;
            }
        }
    }
}
