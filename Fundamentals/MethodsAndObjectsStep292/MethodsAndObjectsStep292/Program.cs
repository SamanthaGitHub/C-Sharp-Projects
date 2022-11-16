using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjectsStep292
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee worker = new Employee(); //instatiation
            worker.FirstName = "Sample";
            worker.LastName = "Student";
            worker.SayName(); //calls inherited method
            Console.ReadLine();
        }
    }
}
