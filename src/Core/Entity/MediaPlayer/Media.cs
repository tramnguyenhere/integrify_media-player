namespace Core;

public abstract class Media : IObservable<Media>
{
    public int Id { get; }
    public string Title { get; set; }
    public int Duration { get; set; }
    private List<ISubscriber> _subscribers;
    private List<IObserver<Media>> _observers;

    public Media(int id, string title, int duration)
    {
        Id = id;
        Title = title;
        Duration = duration;
        _subscribers = new();
        _observers = new();
    }

    public abstract void GetMediaType();

    public void Unsubscribe(ISubscriber subscriber)
    {
        _subscribers.Remove(subscriber);
    }

    public void Notify(string message)
    {
        foreach (var subscriber in _subscribers)
        {
            subscriber.OnReceive(message);
        };
    }

    public IDisposable Subscribe(IObserver<Media> observer)
    {
        _observers.Add(observer);
        return new Unsubscriber(_observers, observer);
    }

    public class Unsubscriber : IDisposable
    {
        private List<IObserver<Media>> _observers;
        private IObserver<Media> _observer;

        public Unsubscriber(List<IObserver<Media>> observers, IObserver<Media> observer)
        {
            _observers = observers;
            _observer = observer;
        }
        public void Dispose()
        {
            _observers.Remove(_observer);
        }
    }
}