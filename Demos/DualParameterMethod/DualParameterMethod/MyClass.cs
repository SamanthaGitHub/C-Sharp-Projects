using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DualParameterMethod
{
    class MyClass
    {
        public int MyMethod(int int1, int int2 = 1) //optional second parameter
        {
            int result = (int1 + 3) * int2;
            return result;
        }
    }
}
