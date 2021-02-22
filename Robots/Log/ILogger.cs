using System;

namespace Robots.Log
{
    public interface ILogger
    {
        ConsoleColor TextColor { get; set; }
        void Trace(string message);
        void Warning(string message);
        void Debug(string message);
        void Info(string message);
        void Error(string message);
        void Exception(Exception e);
    }
}
