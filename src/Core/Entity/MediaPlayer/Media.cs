using Service;

namespace Core;

public class Media : IPlayer
{
    public int Id { get; }
    public string Title { get; set; }
    public string Artist { get; set; }
    public int Duration { get; set; }

    public Media(int id, string filePath, string title, string artist, int duration)
    {
        Id = id;
        Title = title;
        Artist = artist;
        Duration = duration;
    }

    public void Play(string filePath)
    {
        Console.WriteLine("");
    }

    public void Pause(string filePath)
    {
        Console.WriteLine("");
    }

    public void Stop(string filePath)
    {
        Console.WriteLine("");
    }

    public void Seek(string filePath, TimeSpan position)
    {
        Console.WriteLine("");
    }
}
