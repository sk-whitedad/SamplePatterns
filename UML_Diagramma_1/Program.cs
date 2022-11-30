
using ObserverPattern.Observers;
using ObserverPattern.Subjects;

namespace ObserverPattern
{
    public class MyProgramm
    {
        public static void Main()
        {
            int temperature;
            int humidity;
            int pressure;

            Random rnd = new Random();

            WeatherData weather = new WeatherData();
            CurrentConditionsDisplay current = new CurrentConditionsDisplay(weather);

            while (true)
            {
                humidity = rnd.Next(0, 100);
                pressure = rnd.Next(730, 770);
                temperature = rnd.Next(-50, 50);
                weather.setMeasurements(temperature, humidity, pressure);
                Thread.Sleep(1000);
            }
            
        }
    }
}

