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

    public Media AddMedia(Media media)
    {
        _mediaRepository.AddMedia(media);
        return media;
    }

    public bool DeletMediaByTitle(string title)
    {
        _mediaRepository.DeleteMediaByTitle(title);
        return true;
    }

    public IEnumerable<Media> GetAllMedia()
    {
        var mediaList = _mediaRepository.GetAllMedia();
        return mediaList;
    }

    public Media GetMediaByTitle(string title)
    {
        return _mediaRepository.GetMediaByTitle(title);
    }

    public IEnumerable<Media> SortMediaRepository()
    {
        return _mediaRepository.SortMediaRepository();
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
