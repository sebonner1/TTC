namespace observerpattern
{
    public interface IObserver // Observer is the subscriber
    {
         public void Update(double temp, double humidity, double pressure);
    }
}