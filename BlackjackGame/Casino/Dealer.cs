using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Casino
{
    public class Dealer
    {
        public string Name { get; set; }
        public Deck Deck { get; set; }
        public int Balance { get; set; }

        public void Deal(List<Card> Hand)
        {
            Hand.Add(Deck.Cards.First());
            string card = string.Format(Deck.Cards.First().ToString() + "\n");
            Console.WriteLine(card);
            //logs cards dealt and timestamp  to file
            using (StreamWriter file = new StreamWriter(@"C:\Users\saman\Desktop\BlackjackGameLog.txt", true)) //'true' appends to the file
            {
                file.WriteLine(DateTime.Now);
                file.WriteLine(card);
            } //using disposes memory
                Deck.Cards.RemoveAt(0);
        }
    }
}

// If it 'is a', you can inherit (Blackjack IS A game); can't do 'has a' (Dealer class won't inherit Deck because a dealer ISN'T a deck, but it fits well as a property)
