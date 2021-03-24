using System;

namespace inheritancenotes
{
    public class Student : Person
    {
        public string Year {get; set;}
        public double Gpa {get; set;}

        public override string ToString()
        {
            return $"Hi, my name is {Name} and I am a {Year}";
        }

        public void TakeExam()
        {
            Console.WriteLine("I am happily taking a test.");
        }

        public override void SayHello() // virtual in og and override in subclass; polymorphism class
        {
            Console.WriteLine("Howdy!");
        }
    }
}