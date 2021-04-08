namespace compoundpattern
{
    public class QuackCounter : IQuackable
    {
        IQuackable duck;

        public static int numOfQuacks;

        public QuackCounter(IQuackable duck)
        {
            this.duck = duck;
        }
        public void Quack()
        {
            duck.Quack();
            numOfQuacks++;
        }

        public static int GetNumOfQuacks()
        {
            return numOfQuacks;
        }
    }
}