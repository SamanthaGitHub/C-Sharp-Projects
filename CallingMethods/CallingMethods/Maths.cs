using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethods
{
    public class Maths
    {
        //divides input by 2
        public static decimal DivideByTwo(decimal input)
        {
            decimal result = input / 2;
            return result;
        }

        //multiplies input by 2
        public static int MultiplyByTwo(int input2)
        {
            int result2 = input2 * 2;
            return result2;
        }

        //adds two to input
        public static int AddTwo(int input3)
        {
            int result3 = input3 + 2;
            return result3;
        }
    }
}
