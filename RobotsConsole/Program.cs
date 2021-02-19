using System;
using Robots.Controller;

namespace RobotsConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            RobotManager system = new RobotManager(3, 4, 5, 1500);
            system.Start();

            Console.ReadLine();

        }
    }
}
