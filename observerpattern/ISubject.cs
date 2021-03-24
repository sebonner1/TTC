namespace observerpattern
{
    public interface ISubject
    {
        // Subject is the youtuber/podcast creator/etc.
         public void RegisterObserver(IObserver o);
         public void RemoveObserver(IObserver o);
         public void NotifyObserver();
    }
}