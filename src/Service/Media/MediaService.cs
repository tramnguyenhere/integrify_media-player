using Core;

namespace Service;

public class MediaService : IMediaService
{
    private IMediaRepository _mediaRepository;
    public MediaService(IMediaRepository mediaRepository)
    {
        _mediaRepository = mediaRepository;
    }

    public IEnumerable<Media> GetAllAudio(int page, int perPage)
    {
        var audios = _mediaRepository.GetAllAudio(page, perPage);
        return audios;
    }
}
