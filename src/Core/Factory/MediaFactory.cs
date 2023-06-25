namespace Core;

public class MediaFactory
{
    public int Id { get; }
    public string Title { get; set; }
    public string? Singer { get; set; }
    public string? Director { get; set; }
    public int Duration { get; set; }
    private bool _isPlaying;

    public MediaFactory(int id, string title, MediaType type, string? singer, string? director, string artist, int duration)
    {
        Id = id;
        Title = title;
        Singer = singer;
        Director = director;
        Duration = duration;
    }

    public Media CreateMedia(MediaType type)
    {

        switch (type)
        {
            case MediaType.Audio:
                return new Audio(Id, Title, Singer, Duration);
            case MediaType.Video:
                return new Video(Id, Title, Director, Duration);
            default:
                throw new Exception("Invalid data");
        }
    }
}