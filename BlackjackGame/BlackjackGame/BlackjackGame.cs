﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackjackGame
{
    public class BlackjackGame : Game, IWalkAway // ':' signifies inheritance from Game class
    {
        public override void Play() //override is used to satisfy the transfer of the absract class Play() in Game class
        {
            throw new NotImplementedException();
        }
        public override void ListPlayers()
        {
            Console.WriteLine("Blackjack Players:");
            base.ListPlayers(); //autofill
        }
        public void WalkAway(Player player) //implementing the interface; must be void/match 'mother' method return type
        {
            throw new NotImplementedException();
        }
    }
}
