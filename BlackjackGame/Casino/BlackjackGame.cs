using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Casino.Interfaces;

namespace Casino.BlackjackGame
{
    public class BlackjackGame : Game, IWalkAway // ':' signifies inheritance from Game class
    {
        public BlackjackDealer Dealer { get; set; }

        public override void Play() //plays one hand [override is used to satisfy the transfer of the absract class Play() in Game class]
        {
            Dealer = new BlackjackDealer();
            foreach (Player player in Players)
            {
                player.Hand = new List<Card>();
                player.Stay = false;
            }
            Dealer.Hand = new List<Card>();
            Dealer.Stay = false;
            Dealer.Deck = new Deck();
            Dealer.Deck.Shuffle(3); //shuffles deck X3

            foreach (Player player in Players)
            {
                bool validAnswer = false;
                int bet = 0;
                while (!validAnswer)
                {
                    Console.WriteLine("Place your bet!");
                    validAnswer = int.TryParse(Console.ReadLine(), out bet);
                    if (!validAnswer) Console.WriteLine("Please enter digits only, no decimals");
                }
                if (bet < 0)
                {
                    throw new FraudException("Security! Kick this person out!");
                }
                bool successfullyBet = player.Bet(bet);
                if (!successfullyBet)
                {
                    return; //return ends the method; doesn't continue down, and retarts at place your bet
                }
                Bets[player] = bet; //adds the entry into the dictionary
            }

            for (int i = 0; i < 2; i++) 
            {
                Console.WriteLine("Dealing...");
                foreach (Player player in Players) //deals 2 cards to each player
                {
                    Console.Write("{0}: ", player.Name);
                    Dealer.Deal(player.Hand); //passes in the player hand and adds a card
                    if (i==1) //checks for Blackjack after second card is dealt
                    {
                        bool blackjack = BlackjackRules.CheckForBlackjack(player.Hand);
                        if (blackjack)
                        {
                            Console.WriteLine("Blackjack! {0} wins {1}", player.Name, Bets[player]);
                            player.Balance += Convert.ToInt32((Bets[player] * 1.5) + Bets[player]); //winner gets 1.5*bet PLUS their OG bet back
                            return;
                        }
                    }
                }
                Console.Write("Dealer: ");
                Dealer.Deal(Dealer.Hand);
                if (i == 1) //after two cards are dealt
                {
                    bool blackjack = BlackjackRules.CheckForBlackjack(Dealer.Hand); //checks if dealer has blackjack
                    if (blackjack)
                    {
                        Console.WriteLine("Dealer has Blackjack! Everyone loses!");
                        foreach (KeyValuePair<Player, int> entry in Bets)
                        {
                            Dealer.Balance += entry.Value; //dealer collects all the bets
                        }
                        return;
                    }
                }
            }
            foreach (Player player in Players)
            {
                while (!player.Stay)
                {
                    Console.WriteLine("Your cards are: ");
                    foreach (Card card in player.Hand)
                    {
                        Console.Write("{0} ",card.ToString()); //displays cards in player's hand
                    }
                    Console.WriteLine("\n\nHit or Stay?");
                    string answer = Console.ReadLine().ToLower();
                    if (answer == "stay")
                    {
                        player.Stay = true; //once the player stays, while this loop breaks 
                        break; 
                    }
                    else if (answer == "hit")
                    {
                        Dealer.Deal(player.Hand);
                    }
                    bool busted = BlackjackRules.IsBusted(player.Hand);
                    if (busted)
                    {
                        Dealer.Balance += Bets[player];
                        Console.WriteLine("{0} busted! You lose your bet of {1}. Your balance is now {2}.", player.Name, Bets[player], player.Balance);
                        Console.WriteLine("Would you like to play again? (y/n)");
                        answer = Console.ReadLine().ToLower();
                        if (answer == "y")
                        {
                            player.isActivelyPlaying = true;
                        }
                        else player.isActivelyPlaying = false;
                        return;
                    }
                }
            }
            Dealer.isBusted = BlackjackRules.IsBusted(Dealer.Hand);
            Dealer.Stay = BlackjackRules.ShouldDealerStay(Dealer.Hand);
            while (!Dealer.Stay && !Dealer.isBusted) //will break once one of these conditions is false
            {
                Console.WriteLine("Dealer is hitting...");
                Dealer.Deal(Dealer.Hand);
                Dealer.isBusted = BlackjackRules.IsBusted(Dealer.Hand);
                Dealer.Stay = BlackjackRules.ShouldDealerStay(Dealer.Hand);
            }
            if (Dealer.Stay)
            {
                Console.WriteLine("Dealer is staying.");
            }
            if (Dealer.isBusted) //pays out if dealer busts
            {
                Console.WriteLine("Dealer busted!");
                foreach (KeyValuePair<Player, int> entry in Bets) //displays players' winnnings
                {
                    Console.WriteLine("{0} won {1}!", entry.Key.Name, entry.Value); //accessing dictionary KVP
                    Players.Where(x => x.Name == entry.Key.Name).First().Balance += (entry.Value * 2);
                    Dealer.Balance -= entry.Value;
                }
                return;
            }
            foreach (Player player in Players) //compares hands of dealer and player
            {
                bool? playerWon = BlackjackRules.CompareHands(player.Hand, Dealer.Hand); //null-able boolean with [bool?]
                if (playerWon == null)
                {
                    Console.WriteLine("Push! No one wins");
                    player.Balance += Bets[player];
                }
                else if (playerWon == true)
                {
                    Console.WriteLine("{0} won {1}", player.Name, Bets[player]);
                    player.Balance += (Bets[player] * 2);
                    Dealer.Balance -= Bets[player];
                }
                else
                {
                    Console.WriteLine("Dealer wins {0}", Bets[player]);
                    Dealer.Balance += Bets[player];
                }

                Console.WriteLine("Play again? (y/n)");
                string answer = Console.ReadLine().ToLower();
                if (answer == "y")
                {
                    player.isActivelyPlaying = true;
                }
                else
                {
                    player.isActivelyPlaying = false;
                }
            }
            
        }

        public override void ListPlayers()
        {
            Console.WriteLine("Blackjack Players:");
            base.ListPlayers(); //lists players
        }

        public void WalkAway(Player player) //implementing the interface; must be void/match 'mother' method return type
        {
            throw new NotImplementedException();
        }
    }
}
