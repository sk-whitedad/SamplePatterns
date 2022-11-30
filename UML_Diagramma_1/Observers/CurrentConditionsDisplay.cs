using ObserverPattern.DisplayElements;
using ObserverPattern.Subjects;

namespace ObserverPattern.Observers
{
    public class CurrentConditionsDisplay : IObserver, IDisplayElement
    {
        private int temperature;
        private int humidity;
        private ISubject weatherData;
        
        public CurrentConditionsDisplay(ISubject weatherData)
        {
            this.weatherData = weatherData;
            this.weatherData.registerObserver(this);//подписываемся на данные от Субъекта
        }
        public void display()
        {
            Console.WriteLine($"Current conditions: температура {temperature}C, влажность воздуха { humidity}%");
        }

        public void update(int temp, int humidity, int pressure)
        {
            this.temperature = temp;
            this.humidity = humidity;
            display();
        }
    }
}
