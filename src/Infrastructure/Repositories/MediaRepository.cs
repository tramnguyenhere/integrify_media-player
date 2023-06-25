using Core;

namespace Infrastructure;

public class MediaRepository : IMediaRepository
{
    private List<Media> _media = new();
    private static MediaRepository _instance = null;
    private static readonly object _lock = new object();
    private static readonly Lazy<MediaRepository> _lazy = new Lazy<MediaRepository>(() => new MediaRepository());


    public MediaRepository()
    {

    }
    public static MediaRepository Instance
    {
        get
        {
            return _lazy.Value;
        }
    }

    public IEnumerable<Media> GetAllMedia()
    {
        return _media;
    }

    public Media AddMedia(Media media)
    {
        _media.Add(media);
        Console.WriteLine("Added succesfully!");
        return media;
    }

    public Media GetMediaByTitle(string title)
    {
        return _media.FirstOrDefault(m => m.Title == title);
    }

    public bool DeleteMediaByTitle(string title)
    {
        var mediaToRemove = _media.FirstOrDefault(m => m.Title == title);
        if (mediaToRemove != null)
        {
            _media.Remove(mediaToRemove);
            return true;
        }
        return false;
    }

    public IEnumerable<Media> SortMediaRepository()
    {
        return _media.OrderBy(m => m.Title);
    }
}