using System;

namespace inheritancenotes
{
    public class Cat : ISpeakable // This means that I'll have a SayHello method. Could do "ISpeakable, IComparable" etc to have multiple
    {
        public void SayHello()
        {
            Console.WriteLine("Meow!");
        }
        // Technical interview question - we want loosely coupled code. In Interface, the only thing that ties us together is a method name
    }
}