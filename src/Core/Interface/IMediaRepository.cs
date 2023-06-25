namespace Core;

public interface IMediaRepository
{
    public IEnumerable<Media> GetAllMedia();
    public Media AddMedia(Media Media);
    public Media GetMediaByTitle(string title);
    public bool DeleteMediaByTitle(string title);
    public IEnumerable<Media> SortMediaRepository();
}
