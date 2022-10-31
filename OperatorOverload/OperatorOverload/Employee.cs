using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverload
{
    public class Employee
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        //public bool isEqual { get; set; }


        //overoading "=="
        public static bool operator == (Employee emp1, Employee emp2) //checks for equality
        {
            if (emp1.ID == emp2.ID)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator != (Employee emp1, Employee emp2) //checks for inequality
        {
            //bool isEqual = emp1.ID != emp2.ID;
            //return Console.WriteLine(isEqual);
            if (emp1.ID != emp2.ID)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
