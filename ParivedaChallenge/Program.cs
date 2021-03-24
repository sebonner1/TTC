using System;

namespace ParivedaChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            int userPoints = 0;
            IntroScroll();
            if(userPoints > 250)
            {
                PlansToR2D2();
            }

        }
        static void IntroScroll()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("                Welcome to Star Wars Study      ");
            Console.WriteLine("            Long ago, in a galaxy far, far away...  ");
            Console.WriteLine("            Princess Leia needs to get plans to R2.");
            Console.WriteLine("            Help Princess Leia by getting questions");
            Console.WriteLine("            correct while studying. If you earn over");
            Console.WriteLine("            250 Force Points, Leia will deliver the ");
            Console.WriteLine("           plans successfully. If not, the Rebellion");
            Console.WriteLine("           will not recieve the plans. Do you accept");
            Console.WriteLine("             the mission? Press any key to accept. \n\n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadKey();
        }
        static void PlansToR2D2()
        {
            Console.WriteLine("                    .==.");
            Console.WriteLine("                   ()''()-.");
            Console.WriteLine("        .---.       ;--; /");
            Console.WriteLine("      .'_:___"+". _..'.  __'.");
            Console.WriteLine("      |__ --==|'-''' \'...;");
            Console.WriteLine("      [  ]  :[|       |---\\");
            Console.WriteLine("      |__| I=[|     .'    '.");
            Console.WriteLine("      / / ____|     :       '._");
            Console.WriteLine("     |-/.____.'      | :       :");
            Console.WriteLine("snd /___\\ /___\\      '-'._----'");
            Console.WriteLine("Art by Shanaka Dias");
            Console.WriteLine("\n\nCongrats, you know your stuff! You helped get Princess Leia to R2 D2! Good luck on your school work.\n");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("May the force be with you.\n");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
