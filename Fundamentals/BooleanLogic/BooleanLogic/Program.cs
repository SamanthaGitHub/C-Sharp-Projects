using System;

namespace TEST
{
    class Program
    {
        static void Main(string[] args)
        {
            // Checks applicants age and prints to the console
            Console.WriteLine("Car Insurance Application\nWhat is your age?");
            string stringage = Console.ReadLine();
            byte age = Convert.ToByte(stringage);
            Console.WriteLine(age);

            // Checks applicants DUIs and prints to the console
            Console.WriteLine("True or False: Have you ever gotten a DUI?");
            string stringduis = Console.ReadLine();
            bool duis = Convert.ToBoolean(stringduis);
            Console.WriteLine(duis);

            // Checks applicants tickets and prints to the console
            Console.WriteLine("How many speeding tickets do you have?");
            string stringtickets = Console.ReadLine();
            byte tickets = Convert.ToByte(stringtickets);
            Console.WriteLine(tickets);

            // Displays whether or not applicannt is eligible based on above criteria
            Console.WriteLine("Qualified?");
            if (age >= 16 && duis == false && tickets <= 3)
            {
                bool qualified = true;
                Console.WriteLine(qualified);
                Console.ReadLine();
            }
            else
            {
                bool q = false;
                Console.WriteLine(q);
                Console.ReadLine();
            }

        }
    }
}