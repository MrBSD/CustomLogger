using System;
using System.Collections.Generic;
using System.Text;
using CustomLogger.Core.Enums;
using CustomLogger.Core.Interfaces;

namespace CustomLogger.Core.Domain
{
    public class BatchLogger : Logger, IBatchLogger
    {
        private readonly IBatchWriter _batchWriter;
        private readonly ICollection<ILoggerMessage> _messages;

        public BatchLogger(IBatchWriter batchWriter): base(batchWriter)
        {
            _batchWriter = batchWriter;
            _messages = new List<ILoggerMessage>();
        }

        internal override void WriteLog(LogLevel level, string message)
        {
            var loggerMessage = GetLoggerMessage(level, message);
            _messages.Add(loggerMessage);
        }

        public void Flush()
        {
            _batchWriter.Write(_messages);
        }


        
    }
}
