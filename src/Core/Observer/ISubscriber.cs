namespace Core;

public interface ISubscriber
{
    void OnReceive(string message);
}
