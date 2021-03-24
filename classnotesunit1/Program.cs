using System;

namespace repetitionstructureexample
{
    class Program
    {
        static void Main(string[] args)
        {
        for(int h=0; h<= 12; h++)
        {
            for(int m=0; m< 59; m++)
            {
                Console.WriteLine(h + ":" +m);
                for(int s=0; s< 59; s++)
                {
                    s++;
                }
            }
        }
        
        // while grade
        //    for(int i=1; i <= 100; i+=2)
        //    {
        //        Console.WriteLine(i);
        //        i++;
        //    }
        // condition controlled loops- while and for
        }
        // static int GetGrade()
        // {
        //     Console.WriteLine("Please enter a grade: ");
        //     int userInput = int.Parse(Console.ReadLine());
        //     while(userInput < -1 || userInput > 100)
        //     {
        //         Console.WriteLine("Invalid grade.");
        //         Console.WriteLine("Please enter a grade: ");
        //         userInput = int.Parse(Console.ReadLine());
        //     }
            
        //     return userInput;
    }
}


//     int currency2 = int.Parse(Console.ReadLine());
        //     if(currency1 == 1) // User is exchanging from Canadian Dollars
        //     {
        //         amountInAmericanDollars = amountExchanged/CANADIAN_DOLLARS;
	    //         if(currency2 == 2)
		//             { 
        //                 amountInAmericanDollars * EURO;
        //             }
	    //         else if(currency2 == 3)
	    //         	{
        //                 amountInAmericanDollars*INDIAN_RUPEE;
        //             }
        //         else if(currency2 == 4)
        //         {
        //             amountInAmericanDollars*JAPANESE_YEN;
        //         }
	    //         else if(currency2 == 5)
	    //         	{
        //                 amountInAmericanDollars*MEXICAN_PESO;
        //             }
	    //         else if(currency2 == 6)
		//             {
        //                 amountInAmericanDollars*BRITISH_POUND;
        //             }
        //         else if(currency2 == 7)
        //         {
        //             Console.WriteLine(amountInAmericanDollars);
        //         }
        //     }
        //     if(currency1 == 2) // User is exchanging from Euro *SIDE NOTE: should this be an else if? and how many equal signs?
        //     {
        //         amountInAmericanDollars = amountExchanged / EURO;
        //         if(currency2 == 1)
        //         {
        //             amountInAmericanDollars*CANADIAN_DOLLAR;
        //         }
        //         else if(currency2 == 3)
        //         {
        //             amountInAmericanDollars*INDIAN_RUPEE;
        //         }
        //         else if(currency2 == 4)
        //         {
        //             amountInAmericanDollars*JAPANESE_YEN;
        //         }
        //         else if(currency2 == 5)
        //         {
        //             amountInAmericanDollars*MEXICAN_PESO;
        //         }
        //         else if(currency2 == 6)
		//         {
        //             amountInAmericanDollars*BRITISH_POUND;
        //         }
        //         else if(currency2 == 7)
        //         {
        //             Console.WriteLine(amountinAmericanDollars);
        //         }
        //     }
        //     if(currency1 == 3) // User is exchanging from Indian Rupee
        //     {
        //         amountInAmericanDollars = amountExchanged / JAPANESE_YEN;
        //         if(currency2 == 1)
        //         {
        //             amountInAmericanDollars*CANADIAN_DOLLAR;
        //         }
        //         else if(currency2 == 2)
        //         {
        //             amountInAmericanDollars*EURO;
        //         }
        //         else if(currency2 == 4)
        //         {
        //             amountInAmericanDollars*JAPANESE_YEN;
        //         }
        //         else if(currency2 == 5)
        //         {
        //             amountInAmericanDollars*MEXICAN_PESO;
        //         }
        //         else if(currency2 == 6)
		//         {
        //             amountInAmericanDollars*BRITISH_POUND;
        //         }
        //         else if(currency2 == 7)
        //         {
        //             Console.WriteLine(amountinAmericanDollars);
        //         }
        //     }
        //     if(currency1 == 4) // User is exchanging from Japanese Yen
        //     {
        //         amountInAmericanDollars = amountExchanged/JAPANESE_YEN;
        //         if(currency2 == 1)
        //         {
        //             amountInAmericanDollars*CANADIAN_DOLLAR;
        //         }
        //         else if(currency2 == 2)
        //         {
        //             amountInAmericanDollars*EURO;
        //         }
        //         else if(currency2 == 3)
        //         {
        //             amountInAmericanDollars*INDIAN_RUPEE;
        //         }
        //         else if(currency2 == 4)
        //         {
        //             amountInAmericanDollars*JAPANESE_YEN;
        //         }
        //         else if(currency2 == 5)
        //         {
        //             amountInAmericanDollars*MEXICAN_PESO;
        //         }
        //         else if(currency2 == 6)
		//         {
        //             amountInAmericanDollars*BRITISH_POUND;
        //         }
        //         else if(currency2 == 7)
        //         {
        //             Console.WriteLine(amountinAmericanDollars);
        //         }
        //     }
        //     if(currency1 = 5)
        //     {
        //         amountInAmericanDollars = amountExchanged/MEXICAN_PESO;
        //         if(currency2 = 1)
        //         {
        //             amountInAmericanDollars*CANADIAN_DOLLAR;
        //         }
        //         else if(currency2 = 2)
        //         {
        //             amountInAmericanDollars*EURO;
        //         }
        //         else if(currency2 = 3)
        //         {
        //             amountInAmericanDollars*INDIAN_RUPEE;
        //         }
        //         else if(currency2 = 4)
        //         {
        //             amountInAmericanDollars*JAPANESE_YEN;
        //         }
        //         else if(currency2 = 6)
		//         {
        //             amountInAmericanDollars*BRITISH_POUND;
        //         }
        //         else if(currency2 = 7)
        //         {
        //             Console.WriteLine(amountinAmericanDollars);
        //         }
        //     }
        //     if(currency1 = 6) // User is exchanging from British Pound
        //     {
        //         amountInAmericanDollars = amountExchanged/BRITISH_POUND;
        //         if(currency2 = 1)
        //         {
        //             amountInAmericanDollars*CANADIAN_DOLLAR;
        //         }
        //         else if(currency2 = 2)
        //         {
        //             amountInAmericanDollars*EURO;
        //         }
        //         else if(currency2 = 3)
        //         {
        //             amountInAmericanDollars*INDIAN_RUPEE;
        //         }
        //         else if(currency2 = 4)
        //         {
        //             amountInAmericanDollars*JAPANESE_YEN;
        //         }
        //         else if(currency2 = 5)
        //         {
        //             amountInAmericanDollars*MEXICAN_PESO;
        //         }
        //         else if(currency2 = 7)
        //         {
        //             Console.WriteLine(amountinAmericanDollars);
        //         }
        //     }
        //     if(currency1 = 7) // User is exchanging from American Dollars
        //     {
        //         if(currency2 = 1)
        //         {
        //             amountInAmericanDollars*CANADIAN_DOLLAR;
        //         }
        //         else if(currency2 = 2)
        //         {
        //             amountInAmericanDollars*EURO;
        //         }
        //         else if(currency2 = 3)
        //         {
        //             amountInAmericanDollars*INDIAN_RUPEE;
        //         }
        //         else if(currency2 = 4)
        //         {
        //             amountInAmericanDollars*JAPANESE_YEN;
        //         }
        //         else if(currency2 = 5)
        //         {
        //             amountInAmericanDollars*MEXICAN_PESO;
        //         }