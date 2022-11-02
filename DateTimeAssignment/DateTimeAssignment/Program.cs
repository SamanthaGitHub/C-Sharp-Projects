using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime rightNow = DateTime.Now; //time and date now
            Console.WriteLine(rightNow);
            //Console.Read();

            Console.WriteLine("Enter a number to add to the hour:");
            int input = Convert.ToInt32(Console.ReadLine()); //user input

            DateTime later = rightNow.AddHours(input); //adds input to rightNow
            Console.WriteLine(later);
            Console.Read();
        }
    }
}
