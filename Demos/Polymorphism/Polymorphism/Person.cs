using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public abstract class Person //abstract class
    {
        public string firstName { get; set; }
        public string lastName { get; set; }

        public virtual void SayName()
        {
            return;
        }
    }
}
