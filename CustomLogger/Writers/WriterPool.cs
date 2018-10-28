using System;
using System.Collections.Generic;
using System.Text;
using CustomLogger.Core.Interfaces;

namespace CustomLogger.Writers
{
    public class WriterPool : IBatchWriter
    {
        private readonly IEnumerable<IWriter> _writers;

        public WriterPool(IEnumerable<IWriter> writers)
        {
            _writers = writers;
        }

        public void Write(ILoggerMessage message)
        {
            foreach (var writer in _writers)
            {
                writer.Write(message);
            }
        }

        public void Write(ICollection<ILoggerMessage> messages)
        {
            foreach (var writer in _writers)
            {
                foreach (var message in messages)
                {
                    writer.Write(message);
                }
            }
        }

       
    }
}
