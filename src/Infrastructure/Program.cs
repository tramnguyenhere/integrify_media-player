using Core;
using Service;
using Controller;
using Infrastructure;

internal class Program
{
    private static void Main(string[] args)
    {
        var audio1 = new Audio(1, "Hello", "Adele", 2);

        var mediaRepo = MediaRepository.Instance;
        var mediaService = new MediaService(mediaRepo);

        mediaService.AddMedia(audio1);
    }
}