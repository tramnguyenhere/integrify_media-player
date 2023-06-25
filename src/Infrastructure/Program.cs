using Core;
using Service;
using Controller;
using Infrastructure;

internal class Program
{
    private static void Main(string[] args)
    {
        var audio1 = new Audio(1, "Hello", "Adele", 2);
        var audio2 = new Audio(2, "Shutdown", "BlackPint", 4);

        var mediaRepo = MediaRepository.Instance;
        var mediaService = new MediaService(mediaRepo);

        mediaService.AddMedia(audio1);
        mediaService.AddMedia(audio2);

        Console.WriteLine(mediaRepo.GetAllMedia().First().Title);
    }
}