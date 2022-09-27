using System;

namespace MathOperqationsAssn
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            // Person 1 salary details
            Console.WriteLine("Person 1:\nWhat is your hourly rate?");
            string rate1 = Console.ReadLine();
            decimal hourlyRate1 = Convert.ToDecimal(rate1);
            Console.WriteLine("How many hours do you work a week?");
            string hours1 = Console.ReadLine();
            decimal weekHours1 = Convert.ToDecimal(hours1);

            //Person 2 salary details
            Console.WriteLine("Person 2:\nWhat is your hourly rate?");
            string rate2 = Console.ReadLine();
            decimal hourlyRate2 = Convert.ToDecimal(rate2);
            Console.WriteLine("How many hours do you work a week?");
            string hours2 = Console.ReadLine();
            decimal weekHours2 = Convert.ToDecimal(hours2);

            // Display and compare person 1 and 2 annual salary
            decimal salary1 = (hourlyRate1 * weekHours1) * 52;
            decimal salary2 = (hourlyRate2 * weekHours2) * 52;
            Console.WriteLine("Annual Salary of Person 1: " + salary1);
            Console.WriteLine("Annual Salary of Person 2: " + salary2);
            Console.ReadLine();
            // Comparison
            Console.WriteLine("Does Person 1 make more money than Person 2?");
            bool versus = salary1 > salary2;
            Console.WriteLine(versus);
            Console.ReadLine();
        }
    }
}
