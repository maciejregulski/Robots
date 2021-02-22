using System;

namespace Robots.Log
{
    /// <summary>
    /// Null logger. Does nothing.
    /// </summary>
    public class NullLogger : BaseLogger, ILogger
    {
        public void Debug(string message)
        {
        }

        public void Error(string message)
        {
        }

        public void Exception(Exception e)
        {
        }

        public void Info(string message)
        {
        }

        public void Trace(string message)
        {
        }

        public void Warning(string message)
        {
        }
    }
}
