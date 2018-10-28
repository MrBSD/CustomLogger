using System;
using CustomLogger.Core.Enums;

namespace CustomLogger.Core.Interfaces
{
  public interface ILoggerMessage
  {
    LogLevel Level { get; }
    DateTime LogDateTime{ get; }
    string  Message {get;}
    string ToString();
  }
}