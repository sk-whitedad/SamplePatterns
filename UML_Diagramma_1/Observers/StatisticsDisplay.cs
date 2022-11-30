using ObserverPattern.DisplayElements;

namespace ObserverPattern.Observers
{
    internal class StatisticsDisplay : IObserver, IDisplayElement
    {
        public void display()
        {
            throw new NotImplementedException();
        }

        public void update(int temp, int humidity, int pressure)
        {
            throw new NotImplementedException();
        }
    }
}
