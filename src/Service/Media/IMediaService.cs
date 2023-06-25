using Core;

namespace Service;

public interface IMediaService
{
    public IEnumerable<Media> GetAllMedia(int page, int perPage);
    public Media AddMedia(Media Media);
    public Media GetMediaByTitle(string title);
    public bool DeletMediaByTitle(string title);
    public IEnumerable<Media> SortMediaRepository();
}
