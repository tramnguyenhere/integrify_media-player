namespace Core;

public class Playlist
{
    public int Id { get; }
    public string Name { get; set; }
    public List<Media> MediaPlaylist { get; set; }

    public Playlist(int id, string name)
    {
        Id = id;
        Name = name;
        MediaPlaylist = new List<Media>();
    }
}