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

    public void AddToPlaylist(Media media)
    {
        MediaPlaylist.Add(media);
    }

    public void RemoveFromPlaylist(Media media)
    {
        MediaPlaylist.Remove(media);
    }

    public void SortAudioAlphabetically()
    {
        MediaPlaylist.Sort();
    }
}