using System;
using System.Collections.Generic;
using CustomLogger.Core.Domain;
using CustomLogger.Core.Interfaces;
using CustomLogger.Writers;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            var writer = new ConsoleWriter();
            var logger = new Logger(writer);

            logger.Debug("First debug message");
            logger.Error("First error message");
            logger.Fatal("First fatal message");
            logger.Info("First info message");

            var writers = new WriterPool(new List<IWriter>{new ConsoleWriter()});
            var batchLogger = new BatchLogger(writers);

            Console.WriteLine();
            batchLogger.Debug("Batch debug");
            batchLogger.Error("Batch error");

            Console.WriteLine("Let's FLUSH ))");
            batchLogger.Flush();

            Console.ReadLine();

        }
    }
}
