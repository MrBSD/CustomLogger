using System;
using System.Collections.Generic;
using System.Text;

namespace CustomLogger.Core.Interfaces
{
    public interface IBatchLogger: ILogger
    {
        void Flush();
    }
}
