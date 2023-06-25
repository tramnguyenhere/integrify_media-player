namespace Core;

public class Audio : Media
{
    public string Singer { get; set; }
    public Audio(int id, string title, string singer, int duration) : base(id, title, duration)
    {
        Singer = singer;
    }

    public override void GetMediaType()
    {
        Console.WriteLine("Audio");
    }
}
