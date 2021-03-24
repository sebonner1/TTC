using System;
using System.IO;

namespace polymorphism
{
    public class Dog : Animal
    {
        public override void Speak()
        {
            Console.WriteLine($"Hello, my name is {Name}. Woof woof");
        }
    }
}