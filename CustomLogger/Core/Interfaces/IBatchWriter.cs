using System;
using System.Collections.Generic;
using System.Text;

namespace CustomLogger.Core.Interfaces
{
    public interface IBatchWriter : IWriter
    {
        void Write(ICollection<ILoggerMessage> messages);
    }
}
