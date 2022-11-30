namespace ObserverPattern.Observers
{
    public interface IObserver
    {
        public void update(int temp, int humidity, int pressure);
    }
}
