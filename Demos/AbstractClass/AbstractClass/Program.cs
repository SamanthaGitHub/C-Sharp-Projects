using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee worker = new Employee(); //instatiation
            worker.firstName = "Sample";
            worker.lastName = "Student";
            worker.SayName(); //calls inherited method
            Console.ReadLine();
        }
    }
}
