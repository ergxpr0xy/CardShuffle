using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardShuffle
{
    class Program
    {
        public Program()
        {
            // constructor
        }

        static void Main(string[] args)
        {
            System.Random random = new Random();
            int randomValue;            

            string[] suites = new[] { "Spades", "Clubs", "Diamonds", "Hearts" };
            string[] faces = new[] { "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King", "Ace" };

            List<string> orderedDeck = new List<string>(52);
            foreach (string suite in suites)
            {
                foreach (string face in faces)
                {
                    orderedDeck.Add(face + " Of " + suite);
                   //Console.WriteLine("Adding "  + face + " Of " + suite);                 
                }                                  
            }

            //Console.WriteLine();
            //Console.WriteLine();

            //for (int i = 51; i >= 0; --i)
            //{
            //    randomValue = random.Next(0, i+1);
            //  //  randomValue = randomValue % orderedDeck.Count;
            //    System.Threading.Thread.Sleep(100);
            //    Console.WriteLine(orderedDeck[randomValue]);
            //    orderedDeck.Remove(orderedDeck[randomValue]);
            //}

            int end = 52;
            for (int j = 0; j < 52; ++j)
            {
                System.Threading.Thread.Sleep(100);
                randomValue = random.Next(0, end);
                Console.WriteLine("[" + j + "] " + orderedDeck[randomValue]);
                orderedDeck.Remove(orderedDeck[randomValue]);
                --end;
            }
            
            Console.Read();
        }         
    }
}
