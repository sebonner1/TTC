using System;

namespace decisionstructuresexample
{
    class Program
    {
        static void Main(string[] args)
        {
            // int num1 = GetNumber();
            // int num2 = GetNumber();
            int grade = GetNumber();
            string letterGrade = "NA";
            // range checking
            if(grade >= 90 && grade <=100)
            {
                letterGrade = "A";
            } 
            else 
            {
                if(grade >= 80)
                {
                    letterGrade = "B";
                }
                else 
                {
                    if(grade >= 70)
                    {
                        letterGrade = "C";
                    }
                    else
                    {
                        letterGrade = "Not passing.";
                    }
                }
            }
            // writing a switch ~flip flip~
            switch(letterGrade)
            {
                case "A":
                    Console.WriteLine("Outstanding job");
                    break;
                case "B":
                    Console.WriteLine("Very good");
                    break;
                case "C":
                    Console.WriteLine("You passed but keep trying");
                    break;
                default: 
                    Console.WriteLine("Study harder next time!");
                    break;
            }
            Console.WriteLine("That is a {0}", letterGrade);

            // if (num1 > num2)
            // {
            //     Console.WriteLine("The first number you entered is bigger");
            // }
            // else
            // {
            //     Console.WriteLine("The first number you entered was smaller.");
            // }
            // if(4 < 5)
            // {
            //     Console.WriteLine("The first number is bigger.");
            //     Console.WriteLine("Which is what I thought would happen.");
            // }
        }
        static int GetNumber()
        {
            Console.WriteLine("Please enter a number");
            return int.Parse(Console.ReadLine()); // string turned into a number
        }
    }
}
