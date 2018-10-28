using System;
using System.Collections.Generic;
using System.Text;
using CustomLogger.Core.Enums;
using CustomLogger.Core.Interfaces;

namespace CustomLogger.Core.Domain
{
    public class Logger : LoggerBase
    {
        private readonly IWriter _writer;

        public Logger(IWriter writer)
        {
            _writer = writer;
        }

        internal override void WriteLog(LogLevel level, string message)
        {
            var loggerMessage = GetLoggerMessage(level, message);
            _writer.Write(loggerMessage);
        }

        internal override LoggerMessage GetLoggerMessage(LogLevel level, string message)
        {
            return new LoggerMessage(level, message);
        }
    }
}
