using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Casino
{
    public abstract class Game
    {
        private List<Player> _players = new List<Player>(); //creates an intial empty list; instatiates it
        private Dictionary<Player, int> _bets = new Dictionary<Player, int>();

        public List<Player> Players { get { return _players; } set { _players = value; } } //accesses private _players list; value is from K'Value'P
        public string Name { get; set; }
        public Dictionary<Player, int> Bets { get { return _bets; } set { _bets = value; } } //Key: player | Value: amount/bet ; tracks players' balances
        
        public abstract void Play(); //the 'abstract' creates a neccessary field for every instance of the class

        public virtual void ListPlayers() //virtual methods exist inside abstract classes; this method gets inherited (by BlackjackGame) but it can override it
        {
            foreach (Player player in Players)
            {
                Console.WriteLine(player.Name);
            }
        }
    }
}
