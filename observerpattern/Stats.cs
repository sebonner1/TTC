namespace observerpattern
{
    public class Stats : IObserver
    {
        public ISubject WeatherData;

        public double Temp{get; set;}
        public double Humidity{get; set;}
        public double Pressure{get; set;}
        public int WarmDayCount{get; set;}

        public Stats(ISubject weatherData)
        {
            Stats = stats;
            weatherData.RegisterObserver(this);
        }
        public void Update(double temp, double humidity, double pressure)
        {
            Temp = temp;
            Pressure = pressure;
            Humidity = humidity;
            if(Temp > 70)
            {
                WarmDayCount++;
            }
            Display();
        }

        public void Display()
        {
            System.Console.WriteLine($"Ther have been {WarmDayCount} warm days");
        }
    }
}