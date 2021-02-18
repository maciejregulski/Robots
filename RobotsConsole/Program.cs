using System;
using Robots.Model;

namespace RobotsConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            RobotManager system = new RobotManager(3, 4, 5);
            system.Start();

            Console.ReadLine();

        }
    }
}
