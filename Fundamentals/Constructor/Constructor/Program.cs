using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            const string casinoName = "Clams Casino"; //Part 1: my const variable
            var otherCasinos = new List<string>();//Part 2: my var variable
        }
        
        public class Person //Part 3: chaining constructors
        {
            public string FirstName;
            public string LastName;
            public int Age;

            public Person() : this("Marsha", "Brady", 15) { } //chaining constructors

            public Person(string FirstName, string LastName, int Age)
            {
                this.FirstName = FirstName;
                this.LastName = LastName;
                this.Age = Age;
            }
        }
    }
}
