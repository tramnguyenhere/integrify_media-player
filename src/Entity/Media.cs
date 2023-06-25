namespace Entity;

public class Media
{
    public string Song { get; set; }
    public string Singer { get; set; }
    public Media(string song, string singer)
    {
        Song = song;
        Singer = singer;
    }
}
