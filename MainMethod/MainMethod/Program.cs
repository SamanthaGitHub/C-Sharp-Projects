using System;


namespace MainMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            // Multiply by 3 method
            new Multiply(); //instatiating the class
            Console.WriteLine("What does 4 multiplied by 3 equal?");
            int myNum = Multiply.MathMethod(4);
            Console.WriteLine(myNum); //prints result 12
            Console.ReadLine();

            // Divide by 2 method
            new Multiply(); //instatiating the class
            Console.WriteLine("What does 7 divided by 2 equal?");
            decimal myNum2 = Multiply.MathMethod(7, 0);
            Console.WriteLine(myNum2); //prints result 3.5
            Console.ReadLine();

            // String conversion method
            new Multiply(); //instatiating the class
            Console.WriteLine("What does 11 plus 2 equal?");
            int myNum3 = Convert.ToInt32(Multiply.MathMethod("11")); //converts to integer
            Console.WriteLine(myNum3); //prints result 13
            Console.ReadLine();
        }
    }
}
