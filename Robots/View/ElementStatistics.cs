namespace Robots.View
{
    public class ElementStatistics
    {
        private readonly int total;
        private readonly int completed;
        private readonly int completedRed;
        private readonly int completedGreen;
        private readonly int completedBlue;

        public ElementStatistics(int total, int completed, int completedRed, int completedGreen, int completedBlue)
        {
            this.total = total;
            this.completed = completed;
            this.completedRed = completedRed;
            this.completedGreen = completedGreen;
            this.completedBlue = completedBlue;
        }

        public int Completed => this.completed;
        public int Total => this.total;
        public int Left => this.total - this.completed;

        public decimal CompletedPercentage => decimal.Divide(this.completed, this.total) * 100;
        public decimal LeftPercentage => decimal.Divide(this.Left, this.total) * 100;

        public decimal CompletedRedPercentage => decimal.Divide(this.completedRed, this.total) * 100;
        public decimal CompletedGreenPercentage => decimal.Divide(this.completedGreen, this.total) * 100;
        public decimal CompletedBluePercentage => decimal.Divide(this.completedBlue, this.total) * 100;

        public int CompletedRed => this.completedRed;
        public int CompletedGreen => this.completedGreen;
        public int CompletedBlue => this.completedBlue;
    }
}
