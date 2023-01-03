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
            // PART ONE
            //my animal array and getting user input
            string[] animalArray = { "kitty ", "cat ", "puppy ", "dog ", "zebra " };
            Console.WriteLine("Please write a word that relates to animals.");
            string userInput = Console.ReadLine();
          
            //appends user input to array items
            for (int i = 0; i < animalArray.Length; i++)
            {
                animalArray[i] = animalArray[i] + userInput;}

            //prints off updated array
            for (int i = 0; i < animalArray.Length; i++)
            {
                Console.WriteLine(animalArray[i]);
            }
            Console.ReadLine();



            // PART TWO
            // inifnite loop; fixed by setting animals to false
            bool animals = false;
            while (animals)
            {
                Console.WriteLine("ANIMALS");
            }



            // PART THREE
            //comparison using <
            for (int a = 0; a < 0; a++)
            {
                Console.WriteLine("This won't print");
                Console.ReadLine();
            }
            //comparison using <=
            for (int b = 1; b <= 1; b++)
            {
                Console.WriteLine("This will print");
                Console.ReadLine();
            }



            // PART FOUR
            //list of unique fruits
            List<string> listOfFruits = new List<string>();
            listOfFruits.Add("Banana.");
            listOfFruits.Add("Apple.");
            listOfFruits.Add("Cherry.");
            listOfFruits.Add("Kiwi.");

            //asks user for fruit input
            Console.WriteLine("Enter a fruit to search for it in the list:");
            string fruitInput = Console.ReadLine();

            //iterates thru list to find match and displays index if matched; else, keeps asking
            bool found = false;
            foreach (string fruit in listOfFruits)
            {
                if (listOfFruits.Contains(fruitInput))
                {
                    found = true;
                    int fruitIndex = listOfFruits.IndexOf(fruitInput);
                    Console.WriteLine(fruitIndex);
                    break;
                }
                else
                {
                    Console.WriteLine("Your input is not part of the list.");
                    Console.WriteLine("Enter a fruit to search for it in the list:");
                    fruitInput = Console.ReadLine();
                }
                Console.ReadLine();
            }



            // PART FIVE
            //list of not so unique vegetables
            List<string> listOfVeg = new List<string> { "mushroom", "mushroom", "celery", "tomato" };
            Console.WriteLine("Enter a vegetable to see if it matches my list:");
            string vegInput = Console.ReadLine();

            //iterate thru list to display indicies of matches
            for (int v = 0; v < listOfVeg.Count; v++)
            {
                if (vegInput == listOfVeg[v])
                {
                    Console.WriteLine(v); 
                }
            }
            if (!listOfVeg.Contains(vegInput))
            {
                Console.WriteLine("Your veg wasn't on the list");
            }
            Console.ReadLine();



            // PART SIX
            // list of strings with at least two identical
            List<string> cheeses = new List<string> { "cheddar", "blue", "swiss", "blue" };
            List<string> extraCheese = new List<string>();

            //checks for duplicates in cheeses
            foreach (string cheese in cheeses)
            {
                if (!extraCheese.Contains(cheese))
                {
                    Console.WriteLine(cheese + " - this item is unique");
                }
                else
                {
                    Console.WriteLine(cheese + " - this item is a duplicate");
                }
                extraCheese.Add(cheese); //adds cheese after checking
            }
            Console.ReadLine();
        }
    }
}
