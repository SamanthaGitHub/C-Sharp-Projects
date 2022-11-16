using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step285ClassMethods
{
    class Divide
    {
        public void ByTwo(decimal input) //void method output integer / 2
        {
            decimal output = input / 2;
            Console.WriteLine(output);
        }

        public void MethodOverload(int integer)//method overloading
        {
            Console.WriteLine(integer++);
        }
        public void MethodOverload(string words)
        {
            Console.WriteLine(words + "are cool.");
        }
    }
}
