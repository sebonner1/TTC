using System;

namespace repetitionstructureexample
{
    class Program
    {
        static void Main(string[] args)
        {
           double totalSalary = 0;
           double salary = GetSalary(); // priming read
           int count = 0;
           while(salary != -1)
           {
               totalSalary += salary;
               count++;
               salary = GetSalary(); // update read
           }
            Console.WriteLine("The total salary was {0}. The average salary was {1}.", totalSalary, (totalSalary/count));
        }
       
        static double GetSalary()
        {
            Console.WriteLine("Enter your salary amount. -1 to stop.");
            return double.Parse(Console.ReadLine());
        }
    }
}
