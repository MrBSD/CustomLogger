using System;
using CustomLogger.Core.Enums;
using CustomLogger.Core.Interfaces;

namespace CustomLogger.Core.Domain
{
    public class LoggerMessage : ILoggerMessage
    {
        public LogLevel Level { get; }
        public DateTime LogDateTime { get; }
        public string Message { get; }

        public LoggerMessage(LogLevel level, string message)
        {
            Level = level;
            Message = message;
            LogDateTime = DateTime.Now;
        }

        public override string ToString()
        {
            return $"{LogDateTime.ToShortDateString()}: [{Level.ToString().ToUpper()}] {Message}";
        }
    }
}