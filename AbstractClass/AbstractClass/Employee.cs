using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    class Employee : Person //inheritance
    {
        public override void SayName()
        {
            Console.WriteLine("Name: {0} {1}", firstName, lastName); //outputs full name
        }
        
    }
}
