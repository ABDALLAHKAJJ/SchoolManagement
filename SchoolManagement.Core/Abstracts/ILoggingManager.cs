namespace SchoolManagement.Libraries.Core.Abstracts
{
    public interface ILoggingManager
    {
        void LogInfo(string message);

        void LogWarn(string message);

        void LogDebug(string message);

        void LogError(string message);
    }
}