using System;
using System.Collections.Generic;

namespace inheritancenotes
{
    class Program
    {
        static void Main(string[] args)
        {
            Person normalPerson = new Person(){Name = "Jeff", Age = 142};
            Student studentPerson = new Student(){Name = "Kera", Gpa = 4.0, Year = "Junior"};
            // Console.WriteLine(normalPerson.ToString());
            // Console.WriteLine(studentPerson.ToString());

            // studentPerson.TakeExam();
            // normalPerson.SayHello();
            // studentPerson.SayHello();

            List<ISpeakable> myPeople = new List<ISpeakable>();
            myPeople.Add(normalPerson);
            myPeople.Add(studentPerson);
            myPeople.Add(new Student(){Name = "Emma", Year = "Senior"});
            myPeople.Add(new TA(){Name = "Ryland"});

            Cat myCat = new Cat();
            myPeople.Add(myCat); // Cat is not a person... so we extend the interface. 

            foreach(ISpeakable p in myPeople)
            {
                p.SayHello();
            }
        }
    }
}
