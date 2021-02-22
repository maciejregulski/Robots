using System;
using Robots.Controller;

namespace RobotsConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var robotService = new RobotManager(5, 5, 5, 150);
            robotService.Start();
            robotService.IntervalRed = 21;
            robotService.IntervalGreen = 22;
            robotService.IntervalBlue = 23;

            Console.ReadLine();
            robotService.ReportStatus();
            Console.ReadLine();
        }
    }
}
