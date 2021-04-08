namespace compoundpattern
{
    public abstract class AbstractDuckFactory
    {
        public abstract IQuackable CreateDuckCall();
        public abstract IQuackable CreateMallardDuck();
        public abstract IQuackable CreateRedHead();
        public abstract IQuackable CreateRubberDuck();
    }
}