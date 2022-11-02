using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    public class Player
    {
        public Player(string name, int beginningBalance) //constructor; assigns input arguments to create a player
        {
            Hand = new List<Card>();
            Balance = beginningBalance;
            Name = name;
        }
        private List<Card> _hand = new List<Card>(); // instatiates an initial list to be added to
        public List<Card> Hand { get { return _hand; } set { _hand = value; } } //accesses provate _hand
        public int Balance { get; set; }
        public string Name { get; set; }
        public bool isActivelyPlaying { get; set; }
        public bool Stay { get; set; }
        public Guid Id { get; set; }
        public bool Bet(int amount)
        {
            if (Balance - amount < 0)
            {
                Console.WriteLine("You do not have enough chips to place a bet that size.");
                return false;
            }
            else
            {
                Balance -= amount;
                return true;
            }
        }

        
        public static Game operator+ (Game game, Player player) //operator overload to add player
        {
            game.Players.Add(player);
            return game;
        }
        public static Game operator- (Game game, Player player) //operator overload to remove player
        {
            game.Players.Remove(player);
            return game;
        }
    }
}
