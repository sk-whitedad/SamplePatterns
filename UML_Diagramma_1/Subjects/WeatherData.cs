using ObserverPattern.Observers;
using System.Collections;

namespace ObserverPattern.Subjects

{
    public class WeatherData : ISubject
    {
        private ArrayList observers;
        private int temperature;
        private int humidity;
        private int pressure;

        public WeatherData()
        {
            observers = new ArrayList();
        }
        public void notifyObservers()//оповещение обсерверов
        {
            foreach (IObserver observer in observers)
            {
                observer.update(temperature, humidity, pressure);// через метод интерфейса Обсервера оповещаем подписавшиеся субклассы 
            }
        }

        //вспомогательный метод для изменения метеоданных (для реализации примера)
        public void setMeasurements(int temperature, int humidity, int pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            this.pressure = pressure;
            measurementsChanged();
        }

        public void measurementsChanged()//Оповещение наблюдателей о появлении новых данных.
        {
            notifyObservers();
        }

        public void registerObserver(IObserver o)
        {
            observers.Add(o);
        }

        public void removeObserver(IObserver o)
        {
            observers.Remove(o);
        }


    }
}
