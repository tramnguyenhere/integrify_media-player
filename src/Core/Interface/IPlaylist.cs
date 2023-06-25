namespace Core;

public interface IPlaylist
{
    public IEnumerable<Media> GetAllMediaInPlaylist(int page, int perPage);
    public Media AddToPlaylist(Media Media);
    public bool RemovesFromPlaylist(string title);
    public Playlist CreatePlaylist(string name);
}
