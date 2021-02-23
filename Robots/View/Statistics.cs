namespace Robots.View
{
    public class Statistics
    {
        public ElementStatistics ElementStatistics { get; private set; }
        public RobotStatistics RobotStatistics { get; private set; }

        public Statistics(ElementStatistics elementStatistics, RobotStatistics robotStatistics)
        {
            this.ElementStatistics = elementStatistics;
            this.RobotStatistics = robotStatistics;
        }
    }
}
