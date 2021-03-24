using System;

namespace exam1practice321
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            We make ducks! We make ducks of all sorts... Mallard, Redhead, Marbled, etc.
            All of our ducks quack. Create an application that allows us to create duck objects.
            Each duck should have a name and be able to quack. Each duck type should be it's own
            class to allow for differences not detailed here. To begin with we will only have Mallard,
            Redhead ducks, and Rubber ducks. 
            Oh... good point about the Rubber ducks. They squeak, they do not quack. Make sure your
            design handles that as well!
            */
            
            Duck myDuck = new RedHead();
            Duck toyDuck = new RubberDuck();

            myDuck.QuackBehavior.Quack();
            toyDuck.QuackBehavior.Quack();
        }
    }
}
