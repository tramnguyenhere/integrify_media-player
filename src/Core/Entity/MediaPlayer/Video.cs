namespace Core;

public class Video : Media
{
    public string Director { get; set; }
    public Video(int id, string title, string director, int duration) : base(id, title, duration)
    {
        Director = director;
    }

    public override void GetMediaType()
    {
        Console.WriteLine("Video");
    }
}