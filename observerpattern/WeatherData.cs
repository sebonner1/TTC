using System.Collections.Generic;

namespace observerpattern
{
    public class WeatherData : ISubject
    {
        public double Temp{get; set;}
        public double Humidity{get; set;}
        public double Pressure{get; set;}

        public List<IObserver> observers;
        public WeatherData()
        {
            observers = new List<IObserver>();
        }
        public void NotifyObserver()
        {
            foreach(IObserver observer in observers)
            {
                observer.Update(o);
            }
        }

        public void RegisterObserver(IObserver o)
        {
            observers.Add(o);
        }

        public void RemoveObserver(IObserver o)
        {
            observers.Remove(o);
        }

        public void SetMeasurements(double temp, double humidity, double pressure)
        {
            Temp = temp; 
            Humidity = humidity;
            Pressure = pressure;
            MeasurementChanged();
        }

        public void MeasurementChanged()
        {
            System.Console.WriteLine("The measurement has changed");
        }
    }
}