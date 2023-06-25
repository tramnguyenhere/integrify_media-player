using Core;

namespace Repositories;

public class MediaRepository : IMediaRepository
{
    private List<Media> _media = new();

    public MediaRepository()
    {

    }

    public IEnumerable<Media> GetAllAudio(int page, int perPage)
    {
        return _media.Skip(page * perPage).Take(perPage);
    }
}