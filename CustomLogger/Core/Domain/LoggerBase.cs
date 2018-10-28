using CustomLogger.Core.Enums;
using CustomLogger.Core.Interfaces;

namespace CustomLogger.Core.Domain
{
    public abstract class LoggerBase : ILogger
    {
        public void Debug(string message)
        {
            WriteLog(LogLevel.Debug, message);
        }

        public void Error(string message)
        {
            WriteLog(LogLevel.Error, message);
        }

        public void Fatal(string message)
        {
            WriteLog(LogLevel.Fatal, message);
        }

        public void Info(string message)
        {
            WriteLog(LogLevel.Info, message);
        }

        public void Warning(string message)
        {
            WriteLog(LogLevel.Warn, message);
        }

        internal abstract void WriteLog(LogLevel level, string message);
        internal abstract LoggerMessage GetLoggerMessage(LogLevel level, string mesage);
    }
}