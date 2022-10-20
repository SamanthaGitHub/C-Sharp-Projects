using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            //divide by 2
            Console.WriteLine("Enter a number to be divided by two:");
            int input = Convert.ToInt32(Console.ReadLine());
            decimal divide2 = Maths.DivideByTwo(input);
            Console.WriteLine(divide2);
            

            //multiply by 2
            Console.WriteLine("Enter a number to be multiplied by two:");
            int input2 = Convert.ToInt32(Console.ReadLine());
            int multiply2 = Maths.MultiplyByTwo(input2);
            Console.WriteLine(multiply2);

            //add to 2
            Console.WriteLine("Enter a number to be added to two:");
            int input3 = Convert.ToInt32(Console.ReadLine());
            int add2 = Maths.AddTwo(input3);
            Console.WriteLine(add2);
            Console.ReadLine();
        }
    }
}
