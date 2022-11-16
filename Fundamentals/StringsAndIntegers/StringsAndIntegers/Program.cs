using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsAndIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entering a try/catch block...");
            try
            {
                //Array of integers to be divided
                List<int> myNums = new List<int> { 99, 98, 97, 96, 95 };
                Console.WriteLine("Choose a number to divide other numbers by:");
                int num = Convert.ToInt32(Console.ReadLine());
                //applies division to the integers
                for (int i = 0; i < myNums.Count; i++)
                {
                    myNums[i] = myNums[i] / num;
                    Console.WriteLine(myNums[i]);
                }
                Console.ReadLine();
            }
            //catch statements for errors
            catch (FormatException)
            {
                Console.WriteLine("Please enter integers.");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Please don't divide by 0.");
            }
            catch (Exception)
            {
                Console.WriteLine("Something went wrong");
            }
            Console.WriteLine("Out of try/catch");
            Console.ReadLine();
        }
    }
}
