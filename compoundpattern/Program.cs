using System;

namespace compoundpattern
{
    // part 2 on the FINAL EXAM
    class Program
    {
        static void Main(string[] args)
        {
            Simulate();
        }
        public static void Simulate(){
            AbstractDuckFactory duckFactory = new CountingDuckFactory();
            IQuackable duckCall = DuckFactory.CreateDuckCall();
            IQuackable redHeadDuck = DuckFactory.CreateRedHeadDuck();
            IQuackable duckCall = DuckFactory.CreateMallardDuck();
            IQuackable rubberDuck = DuckFactory.CreateRubberDuck();
            IQuackable gooseDuck = DuckFactory.CreateGoose();

            Console.WriteLine("\nDuck Simulator");
            Simulate(mallardDuck);
            Simulate(redHeadDuck);
            Simulate(duckCall);
            Simulate(rubberDuck);
            Simulate(gooseDuck);

            System.Console.WriteLine("The ducks quacked " + QuackCounter.GetNumOfQuacks() + " times");
        }

        public static void Simulate(IQuackable duck)
        {
            duck.Quack();
        }
    }
}
