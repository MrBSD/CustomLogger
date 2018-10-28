using System;
using System.Collections.Generic;
using System.Text;

namespace CustomLogger.Core.Interfaces
{
    public interface ILogger
    {
        void Debug(string message);
        void Error(string message);
        void Fatal(string message);
        void Info(string message);
        void Warning(string message);
    }
}
