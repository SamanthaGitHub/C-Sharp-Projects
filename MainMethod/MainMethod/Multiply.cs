﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethod
{
    class Multiply
    {
        // My First Method: multiply
        public static int MathMethod(int input1) // *3
        {
            int result1 = input1 * 3;
            return result1;
        }

        // My Second Method: divide
        public static decimal MathMethod(decimal input2, decimal nothing = 0) // /2
        {
            decimal result2 = input2 / 2;
            return result2;
        }

        // My Third Method: string conversion
        public static string MathMethod(string input)
        {
            int input3 = Convert.ToInt32(input);
            int result3 = input3 + 2;
            string result = Convert.ToString(result3);
            return result;
        }
    }
}
