using System;
using System.Collections.Generic;
using System.Text;
using CustomLogger.Core.Interfaces;

namespace CustomLogger.Writers
{
    public class FileLogWriter : IBatchWriter
    {
        public void Write(ILoggerMessage message)
        {
            throw new NotImplementedException();
        }

        public void Write(ICollection<ILoggerMessage> messages)
        {
            throw new NotImplementedException();
        }
    }
}
