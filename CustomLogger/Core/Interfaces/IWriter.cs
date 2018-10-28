namespace CustomLogger.Core.Interfaces
{
    public interface IWriter
    {
        void Write (ILoggerMessage message);
    }
}