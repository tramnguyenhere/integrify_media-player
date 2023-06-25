using Core;

namespace Service;

public interface IMediaService
{
    public IEnumerable<Media> GetAllAudio(int page, int perPage);
}
