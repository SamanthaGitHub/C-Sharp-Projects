using System;

namespace VariablesAndDataTypesProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            // Print "The Tech Academy"
            Console.WriteLine("The Tech Academy\nStudent Daily Report");
            // Ask name
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();

            // Ask course
            Console.WriteLine("What course are you on?");
            string course = Console.ReadLine();

            // Ask page number
            Console.WriteLine("What page number?");
            string num = Console.ReadLine();
            byte pagenum = Convert.ToByte(num);

            // Ask if help needed
            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\".");
            string help = Console.ReadLine();
            bool needhelp = Convert.ToBoolean(help);

            // Ask about positive experiences
            Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics.");
            string exp = Console.ReadLine();

            // Ask about feedback
            Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
            string feedback = Console.ReadLine();

            // Ask name
            Console.WriteLine("How many hours did you study today?");
            string hours = Console.ReadLine();
            byte studyhours = Convert.ToByte(num);

            // End of program
            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
            Console.ReadLine();
        }
    }
}
