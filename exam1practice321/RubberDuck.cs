namespace exam1practice321
{
    public class RubberDuck : Duck
    {
        public RubberDuck()
        {
            QuackBehavior = new Squeak();
        }
    }
}