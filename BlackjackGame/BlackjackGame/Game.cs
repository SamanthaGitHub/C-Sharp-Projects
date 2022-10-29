using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackjackGame
{
    public abstract class Game
    {
        public List<string> Players { get; set; }
        public string Name { get; set; }
        public string Dealer { get; set; }

        public abstract void Play(); //the 'abstract' creates a neccessary field for every instance of the class

        public virtual void ListPlayers() //virtual methods exist inside abstract classes; this method gets inherited (by BlackjackGame) but it can override it
        {
            foreach (string player in Players)
            {
                Console.WriteLine(player);
            }
        }
    }
}
