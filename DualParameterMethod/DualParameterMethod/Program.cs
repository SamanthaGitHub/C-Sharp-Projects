using System;

namespace DualParameterMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass Class = new MyClass(); //instatiate class

            try
            {
                Console.WriteLine("Please select a number:"); //first number
                int int1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("If you would like to, enter a second number:"); //second number
                string int2 = Console.ReadLine();

                if (int2 != "")
                {
                    int opint = Convert.ToInt32(int2);
                    Console.WriteLine(Class.MyMethod(int1, opint)); //runs with two parameters
                }
                else
                {
                    Console.WriteLine(Class.MyMethod(int1)); //runs with one parameter
                }
            }

            catch (FormatException) //format error handling
            {
                Console.WriteLine("Please enter a valid integer");
            }

            finally
            {
                Console.ReadLine();
            }

        }
    }
}