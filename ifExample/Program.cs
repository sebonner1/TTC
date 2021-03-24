using System;

namespace ifExample
{
    class Program
    {
        static void Main(string[] args)
        {
            string grade = GetGrade();
            switch(grade){
                case "A":
                Console.WriteLine("Great job!");
                break;

                case "B":
                Console.WriteLine("Good job!");
                break;

                case "C":
                Console.WriteLine("You made it.");
                break;

                default:
                Console.WriteLine("Oh no...");
                break;
            }
        //     if(grade >= 90)
        //     {
        //         Console.WriteLine("Your grade is an A. Great job!");
        //     }
        //     if(grade >= 80 && grade < 90){
        //         Console.WriteLine("Good job!");
        //     }
        //     if((grade > 100 || grade < 80) && grade != -15) {
        //         Console.WriteLine("That can't be... try again!");
        //     }
            Console.WriteLine("Goodbye!");
        }
        static string GetGrade() {
            Console.WriteLine("Please enter the grade: ");
            return Console.ReadLine();
        }
    }
}
/* Notes:
-in an "and" you do the thing most likely to fail first. in "or" you do the thing most likely to pass first.

*/