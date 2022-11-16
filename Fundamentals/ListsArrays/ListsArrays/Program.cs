using System;
using System.Collections.Generic;

namespace ListsArrays
{
    class Program
    {
        static void Main()
        {
            // String array
            string[] stringArray = { "I love", "to eat", "string cheese" };
            Console.WriteLine("Pick an index (0 thru 2) to display the corresponding string");
            int stringArrayChoice = Convert.ToInt32(Console.ReadLine());

            if (stringArrayChoice >= 0 && stringArrayChoice <= 2)
            {
                Console.WriteLine(String.Format("Your chosen string: " + stringArray[stringArrayChoice]));
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Index is out of range. Please choose a number in range.");
                Console.ReadLine();
            }

            // Integer array
            int[] intArray = { 2, 4, 8, 16};
            Console.WriteLine("Pick an index (0 thru 3) to display the corresponding integer");
            int intArrayChoice = Convert.ToInt32(Console.ReadLine());

            if (intArrayChoice >= 0 && intArrayChoice <= 3)
            {
                Console.WriteLine(String.Format("Your chosen integer: " + intArray[intArrayChoice]));
                Console.ReadLine();
            }
            else 
            {
                Console.WriteLine("Index is out of range. Please choose a number in range.");
                Console.ReadLine();
            }

            // List of strings
            List<string> stringList = new List<string> { "I also", "love cats", "and dogs" };
            Console.WriteLine("Pick an index (0 thru 2) to display the corresponding string");
            int stringListChoice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(stringList[stringListChoice]);
            Console.ReadLine();
        }
    }
}
