namespace Core;

public static class ErrorLogger
{
    public static void LogError(string errorMessage)
    {
        Console.WriteLine($"Error: {errorMessage}");
    }
}