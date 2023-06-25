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

    public IEnumerable<Media> GetAllAudio(int page, int perPage)
    {
        return _mediaService.GetAllAudio(page, perPage);
    }
}
