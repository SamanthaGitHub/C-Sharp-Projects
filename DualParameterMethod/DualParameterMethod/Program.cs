using System;

namespace DualParameterMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass Class = new MyClass();

            try
            {
                Console.WriteLine("Please select a number:");
                int int1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("If you would like to, enter a second number:");
                string integer2 = Console.ReadLine();

                if (integer2 != "")
                {
                    int opint = Convert.ToInt32(integer2);
                    Console.WriteLine(Class.MyMethod(int1, opint));
                }
                else
                {
                    Console.WriteLine(Class.MyMethod(int1));
                }
            }

            catch (FormatException)
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