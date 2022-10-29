using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackjackGame
{
    interface IWalkAway //able to be inherited as a second inheritance; always start with an 'I'
    {
        void WalkAway(Player player); //method MUST be implemented in interfaces, similar to abstract
    }
}
