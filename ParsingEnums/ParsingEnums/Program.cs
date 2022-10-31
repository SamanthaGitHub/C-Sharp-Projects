using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParsingEnums
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter today's day of the week:");
                string input = Console.ReadLine();
                DaysOfWeek userInput = (DaysOfWeek)Enum.Parse(typeof(DaysOfWeek), input); //parses enum
                Console.WriteLine(userInput);
                Console.ReadLine();
            }
            
            catch (ArgumentException) //catches non-days
            {
                Console.WriteLine("Please enter an actual day of the week.");
                Console.ReadLine();
            }
            
        }

        public enum DaysOfWeek //days of the week enum
        {
            Sunday,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday
        }
    }
}
