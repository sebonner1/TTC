using System;

namespace methodsexample
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = GetName();
            SayHello(name + ", welcome to our addition app.");
            int num1 = getNumbers();
            int num2 = getNumbers();
            Console.WriteLine("You entered {0} and {1}", num1, num2);
            Swap(num1, num2);
            Console.WriteLine("After swap -- you entered {0} and {1}", num1, num2);
            int sum = GetSum(num1, num2);
            Console.WriteLine("The sum of your two numbers = " + sum);
        }

        static void Swap(int x, int y)
        {
            int temp = x;
            x = y;
            y = temp;

            Console.WriteLine("inside the method -- you entered {0} and {1}", x, y);
        }
        static void SayHello(string message)
        {
            Console.WriteLine("Hello " + message);
        }
        static string GetName()
        {
            Console.WriteLine("Please enter your name.");
            // string name = Console.ReadLine();
            // return name;
            return Console.ReadLine();
        }
        static int GetSum(int num1, int num2)
        {
            return num1 + num2;
        }
        static int getNumbers()
        {
            Console.WriteLine("Please type a number.");
            int number = int.Parse(Console.ReadLine());
            return number;
        }
    }
}
