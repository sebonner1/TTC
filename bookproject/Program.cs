using System;
using System.Collections.Generic;

namespace bookproject
{
    class Program
    {
        static void Main(string[] args)
        {
            Card myCard = new Card(){Manufacturer = "tops", Player = "Pete Rose", Year = "1975"};
            Card yourCard = new Card() {Player = "Dale Murphy"};

            List<Card> myCards = new List<Card>();

            myCards.Add(myCard);
            myCards.Add(yourCard);
            myCards.Add(new Card(){Player = "Daryl Strawberry"});

            foreach (Card c in myCards)
            {
                Console.WriteLine(c.Player);
            }


            // List
            // List<int> myInts = new List<int>(){4,32,10,18};

            // myInts.Sort();

            // foreach (int number in myInts)
            // {
            //     Console.WriteLine(number);
            // }
            
            // TRY CATCH FINALLY
            /*
            int userInput = 0;
            while(userInput != 3)
            {
                try{
                    Console.WriteLine("Enter 1, 2, or 3 to quit.");
                    userInput= int.Parse(Console.ReadLine());
                    if(userInput <1 || userInput >3)
                    {
                        throw new Exception("Invalid input outside range.");
                    }
                }
                catch(Exception e) {
                    Console.WriteLine(e.Message);
                }
                finally{ // anytime I have code I want to always run, like reading in data from a file
                    Console.WriteLine("See, I told you I'd run.");
                }
            }
            */
        }
    }
}
