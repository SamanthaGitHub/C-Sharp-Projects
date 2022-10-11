using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopsArraysStrings_assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] animalArray = { "kitty ", "cat ", "puppy ", "dog ", "zebra " };
            Console.WriteLine("Please write a word that relates to animals.");
            string userInput = Console.ReadLine();

            //appends user's text

            foreach (string animal in animalArray)
            {
                //NEED TO FIX

                //animal.ForEach(animalArray, Add(userInput);
                animal.Concat(userInput);
            }

            for (int i = 0; i < animalArray.Length; i++)
            {
                    Console.WriteLine(animalArray[i]);
            }
                //FIX END
                Console.ReadLine();
            //prints off updated array
        }
    }
}
