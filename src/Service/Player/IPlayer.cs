namespace Service;

public interface IPlayer
{
    public void Play(string filePath);
    public void Pause(string filePath);
    public void Stop(string filePath);
    public void Seek(string filePath, TimeSpan position);
}
