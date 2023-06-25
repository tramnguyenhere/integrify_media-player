using Service;
using Core;

namespace Controller;

public class MediaController
{
    private IMediaService _mediaService;

    public MediaController(IMediaService mediaService)
    {
        _mediaService = mediaService;
    }

    public IEnumerable<Media> GetAllMedia()
    {
        return _mediaService.GetAllMedia();
    }

    public Media AddMedia(Media media)
    {
        return _mediaService.AddMedia(media);
    }

    public bool DeletMediaByTitle(string title)
    {
        return _mediaService.DeletMediaByTitle(title);
    }

    public Media GetMediaByTitle(string title)
    {
        return _mediaService.GetMediaByTitle(title);
    }

    public IEnumerable<Media> SortMediaRepository()
    {
        return _mediaService.SortMediaRepository();
    }
}
