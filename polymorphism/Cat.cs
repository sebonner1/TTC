using System;
using System.IO;

namespace polymorphism
{
    public class Cat : Animal // if no suitable method to override, you forgot to extend
    {
        public override void Speak()
        {
            Console.WriteLine($"Hello, my name is {Name}. Meow");
        }
    }
}