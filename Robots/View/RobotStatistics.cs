namespace Robots.View
{
    public class RobotStatistics
    {
        private readonly int busyRed;
        private readonly int busyGreen;
        private readonly int busyBlue;
        private readonly int timeTotalRed;
        private readonly int timeTotalGreen;
        private readonly int timeTotalBlue;

        public RobotStatistics(int busyRed, int busyGreen, int busyBlue, int timeTotalRed, int timeTotalGreen, int timeTotalBlue)
        {
            this.busyRed = busyRed;
            this.busyGreen = busyGreen;
            this.busyBlue = busyBlue;
            this.timeTotalRed = timeTotalRed;
            this.timeTotalGreen = timeTotalGreen;
            this.timeTotalBlue = timeTotalBlue;
        }

        public int BusyRed => this.busyRed;
        public int BusyGreen => this.busyGreen;
        public int BusyBlue => this.busyBlue;

        public int TimeTotalRed => this.timeTotalRed;
        public int TimeTotalGreen => this.timeTotalGreen;
        public int TimeTotalBlue => this.timeTotalBlue;
    }
}
