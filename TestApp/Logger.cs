using Microsoft.Extensions.Configuration;

namespace TestApp;

public static class Logger
{
    private static readonly IConfiguration Configuration;
    private static readonly string LogFilePath;

    static Logger()
    {
        Configuration = new ConfigurationBuilder()
            .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
            .Build();

        LogFilePath = Configuration["logFile"] ?? "logs/application.log";
    }

    public static void LogInfo(string info)
    {
        var message = $"[INFO] {DateTime.Now:yyyy-MM-dd HH:mm:ss} - {info}";
        WriteToFile(message);
    }

    public static void LogError(Exception exception)
    {
        var errorMessage = $"[ERROR] {DateTime.Now:yyyy-MM-dd HH:mm:ss} - {exception.Message}\nStack Trace:\n{exception.StackTrace}";
        WriteToFile(errorMessage);
    }

    private static void WriteToFile(string message)
    {
        var directory = Path.GetDirectoryName(LogFilePath);
        if (!string.IsNullOrEmpty(directory) && !Directory.Exists(directory))
        {
            Directory.CreateDirectory(directory);
        }

        File.AppendAllText(LogFilePath, message + Environment.NewLine);
    }
}
