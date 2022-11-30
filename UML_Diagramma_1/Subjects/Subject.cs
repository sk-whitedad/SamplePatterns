using ObserverPattern.Observers;

namespace ObserverPattern.Subjects
{
    public interface ISubject
    {
        public void registerObserver(IObserver o);
        public void removeObserver(IObserver o);
        public void notifyObservers();
    }
}
