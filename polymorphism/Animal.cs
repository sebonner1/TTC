using System;
using System.IO;

namespace polymorphism
{
    public class Animal
    {
        public string Name {get; set;}

        public virtual void Speak()
        {
            Console.WriteLine($"Hello, my name is {Name}.");
        }
    }
}