using System;

namespace observerpattern
{
    class Program
    {
        static void Main(string[] args)
        {
            WeatherData weatherData = new WeatherData();
            CurrentWeather currWeather = new CurrentWeather(weatherData);
            Stats stats = new Stats(weatherData);

            weatherData.SetMeasurements(75, 30, 99);
            weatherData.SetMeasurements(61,30,99);
        }
    }
}
