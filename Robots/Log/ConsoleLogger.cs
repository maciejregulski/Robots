using System;

namespace Robots.Log
{
    /// <summary>
    /// Displays messages to the console.
    /// </summary>
    public class ConsoleLogger : BaseLogger, ILogger
    {
        public void Debug(string message)
        {
        }

        public void Error(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
        }

        public void Exception(Exception e)  
        {
        }

        public void Info(string message)
        {
            Console.ForegroundColor = this.TextColor;
            Console.WriteLine(message);
        }

        public void Trace(string message)
        {
        }

        public void Warning(string message)
        {
        }

    }
}
