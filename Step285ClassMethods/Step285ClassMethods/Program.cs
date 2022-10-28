using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step285ClassMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Divide DivNum = new Divide(); //instatiation

            Console.WriteLine("Please enter a number to divide by two:"); //user inputs num
            int input = Convert.ToInt32(Console.ReadLine());

            DivNum.ByTwo(input); //calls the method to divide by two
            Console.ReadLine();

            //method called with output parameters
            int sum;
            int product;
            MyOutputMethod(2, 5, out  sum, out  product);  

            Console.WriteLine("Sum of 2 and 5 equals {0} and product equals {1}", sum, product);
            Console.ReadLine();

            //overloading a method
            Divide Overload = new Divide();
            Overload.MethodOverload("Cats "); //calls string version
            Overload.MethodOverload(7); //cals int version
            Console.ReadLine();
        }

        public static void MyOutputMethod(int int1, int int2, out int sum, out int product) //output parameters method; this class is static
        {
            sum = int1 + int2;
            product = int1 * int2;
        }
    }
}
