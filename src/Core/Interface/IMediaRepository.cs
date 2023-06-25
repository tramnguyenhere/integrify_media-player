namespace Core;

public interface IMediaRepository
{
    public IEnumerable<Media> GetAllAudio(int page, int perPage);
}
