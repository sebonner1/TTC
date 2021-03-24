using System;

namespace TAsSec2
{
    public abstract class TA
    {
        public string Name {get; set;}

        public abstract void Grade();

        public void WorkOfficeHours()
        {
            Console.WriteLine("I am in Office Hours.");
        }

        // public IGrade GradeBehavior {get; set;}

        // public TA()
        // {
        //     GradeBehavior = new Grade();
        // }
    }
}