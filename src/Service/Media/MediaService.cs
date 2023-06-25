using Core;

namespace Service;

public class MediaService : IMediaService, ISubject
{
    private IMediaRepository _mediaRepository;
    private HashSet<ISubscriber> _subscribers;

    public MediaService(IMediaRepository mediaRepository)
    {
        _mediaRepository = mediaRepository;
        _subscribers = new();
    }

    public Media AddMedia(Media Media)
    {
        throw new NotImplementedException();
    }

    public bool DeletMediaByTitle(string title)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Media> GetAllMedia(int page, int perPage)
    {
        var mediaList = _mediaRepository.GetAllMedia(page, perPage);
        return mediaList;
    }

    public Media GetMediaByTitle(string title)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Media> SortMediaRepository()
    {
        throw new NotImplementedException();
    }

    public void Notify(string message)
    {
        foreach (var subscriber in _subscribers)
        {
            subscriber.OnReceive(message);
        };
    }


    public void Subscribe(ISubscriber subscriber)
    {
        _subscribers.Add(subscriber);
    }

    public void Unsubscribe(ISubscriber subscriber)
    {
        _subscribers.Remove(subscriber);
    }
}
