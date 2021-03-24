using System;

namespace PA2
{
    class Program
    {
        static void Main(string[] args)
        {
            // My Extras: Exchanging to and from currencies in ExchangeRate(), still owed feature in RestarauntPOS()
            // Declare supported currency exchange rates as constants
            MainMenu(); // Calling the main menu screen method
        }
        static void MainMenu() // Welcoming the user and asking them to choose 1, 2, or 3 to navigate
        { 
            Console.WriteLine("Welcome to the Main Menu. Press 1 to Convert Currencies. Press 2 for Restaraunt POS. Press 3 to Exit.");
            int selection = int.Parse(Console.ReadLine());
            
            switch(selection)
            {
                // Switch statement for the Main Menu options
                case 1:
                    Console.WriteLine("You have selected Convert Currencies.");
                    ExchangeRate();
                    break;
                case 2:
                    Console.WriteLine("You have selected Restaraunt POS.");
                    RestarauntPOS();
                    break;
                case 3:
                    Console.WriteLine("You have selected Exit. Thank you for using the program.");
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("You have entered an invalid selection.");
                    MainMenu();
                    break;
            }
        }
        static void ExchangeRate() // EXTRA FOR BONUS POINTS: All currencies are exchangable!
        {

        // // variables are camelCase and methods are PascelCase

            // Displaying the currencies and Exchange Rate calculator.
            Console.WriteLine("Welcome to the Exchange Rate calculator. Choose a supported currency from the menu below:");
            Console.WriteLine("Press 1 for Canadian Dollar");
            Console.WriteLine("Press 2 for Euro");
            Console.WriteLine("Press 3 for Indian Rupee");
            Console.WriteLine("Press 4 for Japanese Yen");
            Console.WriteLine("Press 5 for Mexican Peso");
            Console.WriteLine("Press 6 for British Pound");
            Console.WriteLine("Press 7 for American Dollar");
            Console.WriteLine("What currency will you be exchanging from?");
            int currency1 = int.Parse(Console.ReadLine());
            Console.WriteLine("What amount would you like to exchange?");
            double amountExchanged = double.Parse(Console.ReadLine());
            Console.WriteLine("What currency would you like to exchange to?");
            int currency2 = int.Parse(Console.ReadLine());
            double userInputConverted = 0;
            ConvertedToUSD(currency1,amountExchanged, ref userInputConverted);
            ConvertedToDesiredCurrency(currency2,ref userInputConverted);
        }
        static void ConvertedToUSD(int currency1, double amountExchanged, ref double userInputConverted) // Taking the amount and the currency the user entered and converting it into USD
            {
                if(currency1 == 1)
                {
                    userInputConverted = CanadianToUS(amountExchanged);
                }
                else if(currency1 == 2)
                {
                    userInputConverted = EuroToUS(amountExchanged);
                }
                else if(currency1 == 3)
                {
                    userInputConverted = RupeeToUS(amountExchanged);
                }
                else if(currency1 == 4)
                {
                    userInputConverted = YenToUS(amountExchanged);
                }
                else if(currency1 == 5)
                {
                    userInputConverted = PesoToUS(amountExchanged);
                }
                else if(currency1 == 6)
                {
                    userInputConverted = PoundToUS(amountExchanged);
                }
                else if(currency1 == 7)
                {
                    userInputConverted = ToUSD(amountExchanged);
                }
            }
            static void ConvertedToDesiredCurrency(int currency2,ref double userInputConverted) // Multiplying the now converted amount by the second currency exchange rate
            {
                if(currency2 == 1)
                {
                    ToCanadian(ref userInputConverted);
                }
                else if(currency2 == 2)
                {
                    ToEuro(ref userInputConverted);
                }
                else if(currency2 == 3)
                {
                    ToRupee(ref userInputConverted);
                }
                else if(currency2 == 4)
                {
                    ToYen(ref userInputConverted);
                }
                else if(currency2 == 5)
                {
                    ToPeso(ref userInputConverted);
                }
                else if(currency2 == 6)
                {
                    ToPound(ref userInputConverted);
                }
                else if(currency2 == 7)
                {
                    Console.WriteLine("Your exchange amount is " + userInputConverted);
                }
            }
    // The following methods will turn the user's input into USD
        static double CanadianToUS(double amountExchanged) // If user begins in Canadian
        {
            double userInputConverted = amountExchanged/.9813;
            return userInputConverted;
        }
        static double EuroToUS(double amountExchanged) // If user begins in Euro
        {
            double userInputConverted = amountExchanged/.757;
            return userInputConverted;
        }
        static double RupeeToUS(double amountExchanged) // If user begins in Rupee
        {
            double userInputConverted = amountExchanged/52.53;
            return userInputConverted;
        }
        static double YenToUS(double amountExchanged) // If user begins in Yen
        {
            double userInputConverted = amountExchanged/80.92;
            return userInputConverted;
        }
        static double PesoToUS(double amountExchanged) // If user begins in Peso
        {
            double userInputConverted = amountExchanged/13.1544;
            return userInputConverted;
        }
        static double PoundToUS(double amountExchanged) // If user begins in Pound
        {
            double userInputConverted = amountExchanged/.6178;
            return userInputConverted;
        }
        static double ToUSD(double amountExchanged) // If user begins with USD
        {
            double userInputConverted = amountExchanged;
            return userInputConverted;
        }

// The following methods will take the now converted into USD amount and convert it into the second, desired currency.

        static void ToCanadian(ref double userInputConverted) // User would like to exchange to Canadian
        {
            double finalConversion = userInputConverted*.9813;
            Console.WriteLine("Your exchange amount is " + Math.Round(finalConversion,2));
        }
        static void ToEuro(ref double userInputConverted) // User would like to exchange to Euro
        {
            double finalConversion = userInputConverted*.757;
            Console.WriteLine("Your exchange amount is " + Math.Round(finalConversion,2));
        }
        static void ToRupee(ref double userInputConverted) // User would like to exchange to Rupee
        {
            double finalConversion = userInputConverted*52.53;
            Console.WriteLine("Your exchange amount is " + Math.Round(finalConversion,2));
        }
        static void ToYen(ref double userInputConverted)
        {
            double finalConversion = userInputConverted*80.92;
            Console.WriteLine("Your exchange amount is " + Math.Round(finalConversion,2));
        }
        static void ToPeso(ref double userInputConverted)
        {
            double finalConversion = userInputConverted*13.1544;
            Console.WriteLine("Your exchange amount is " + Math.Round(finalConversion,2));
        }
        static void ToPound(ref double userInputConverted)
        {
            double finalConversion = userInputConverted*.6178;
            Console.WriteLine("Your exchange amount is " + Math.Round(finalConversion,2));
        }

        static void RestarauntPOS()
        {
            // Declaring variables and processing variables
            double FoodTotal = GetFoodTotal();
            double AlcoholTotal = GetAlcoholTotal();
            double FoodAndAlcoholTotal = FoodTotal+AlcoholTotal;
            double TotalBill = FoodAndAlcoholTotal + (FoodAndAlcoholTotal*.09);
            double TotalAmountDue = TotalBill + (.18*FoodTotal);
            Console.WriteLine("Your total is {0}",Math.Round(TotalAmountDue,2));
            double amountPaid = GetAmountPaid();
            double amountLeftToPay = TotalAmountDue - amountPaid;
            double totalPaid = amountPaid;
            while(amountLeftToPay > 0) // Adding value by telling the user how much they still need to pay
            {
                Console.WriteLine("Error. Amount paid is less than total amount due.");
                Console.WriteLine("You still owe ${0}.",Math.Round(amountLeftToPay,2));
                Console.WriteLine("Please enter payment amount."); // If they underpaid, ask for the payment again. This will display the additional amount that should be paid to meet the total amount due.
                amountPaid = GetAmountPaid(); // Update read for the amount paid
                totalPaid+=amountPaid;
                amountLeftToPay -= amountPaid;
            }
            Console.WriteLine("Your change due is $" + Math.Round((totalPaid - TotalAmountDue),2));
            
        }
        static double GetFoodTotal() // Returns food total for Restaraunt POS
        {
            Console.WriteLine("Hello, please enter your food total.");
            return double.Parse(Console.ReadLine());
        }
        static double GetAlcoholTotal() // Returns alcohol total for Restaraunt POS
        {
            Console.WriteLine("Please enter your alcohol total.");
            return double.Parse(Console.ReadLine());
        }
        static double GetAmountPaid() // Asking the user how much they paid
        {
            Console.WriteLine("What was the amount paid?");
            return double.Parse(Console.ReadLine());
        }
    }
}
