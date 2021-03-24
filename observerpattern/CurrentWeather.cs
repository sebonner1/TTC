namespace observerpattern
{
    public class CurrentWeather : IObserver
    {
        public ISubject WeatherData;

        public double Temp{get; set;}
        public double Humidity{get; set;}
        public double Pressure{get; set;}

        public CurrentWeather(ISubject weatherData)
        {
            WeatherData = weatherData;
            weatherData.RegisterObserver(this);
        }
        public void Update(double temp, double humidity, double pressure)
        {
            Temp = temp;
            Pressure = pressure;
            Humidity = humidity;
            Display();
        }

        public void Display()
        {
            System.Console.WriteLine($"The current temp is {Temp}");
        }
    }
}