using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using CustomLogger.Core.Interfaces;

namespace CustomLogger.Writers
{
    public class ConsoleWriter : IWriter
    {
        public void Write(ILoggerMessage message)
        {
            Console.WriteLine(message);
        }
    }
}
