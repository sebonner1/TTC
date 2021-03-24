using System;

namespace inheritancenotes
{
    public class Person : ISpeakable
    {
        public string Name {get; set;}
        public int Age {get; set;}

        public override string ToString()
        {
            return $"Hi, my name is {Name} and I am {Age} years old.";
        }

        public virtual void SayHello() // Polymorphism example - have different things do the same thing
        {
            Console.WriteLine("Hi");
        }
    }
}