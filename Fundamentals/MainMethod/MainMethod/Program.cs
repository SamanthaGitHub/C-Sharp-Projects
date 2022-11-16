using System;


namespace MainMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            // Multiply by 3 method
            Multiply multi1 = new Multiply(); //instatiating the class
            Console.WriteLine("What does 4 multiplied by 3 equal?");
            int myNum = multi1.MathMethod(4);
            Console.WriteLine(myNum); //prints result 12
            Console.ReadLine();

            // Divide by 2 method
            Console.WriteLine("What does 7 divided by 2 equal?");
            decimal myNum2 = multi1.MathMethod(7m, 0m);
            Console.WriteLine(myNum2); //prints result 3.5
            Console.ReadLine();

            // String conversion method
            Console.WriteLine("What does 11 plus 2 equal?");
            int myNum3 = Convert.ToInt32(multi1.MathMethod("11")); //converts to integer
            Console.WriteLine(myNum3); //prints result 13
            Console.ReadLine();
        }
    }
}
