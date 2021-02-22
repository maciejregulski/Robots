using System;
using System.Windows.Forms;
using Robots.Controller;

namespace RobotsUI
{
    public partial class MainForm : Form
    {
        private RobotManager robotService;
        
        public MainForm()
        {
            InitializeComponent();
        }

        private void CreateRobotManager()
        {
            this.robotService = new RobotManager(
                (int)numericConfiguration_RobotsRed.Value,
                (int)numericConfiguration_RobotsGreen.Value,
                (int)numericConfiguration_RobotsBlue.Value,
                (int)numericConfiguration_Elements.Value)
            {
                IntervalRed = (int)numericConfiguration_RobotsRed_Interval.Value,
                IntervalGreen = (int)numericConfiguration_RobotsGreen_Interval.Value,
                IntervalBlue = (int)numericConfiguration_RobotsBlue_Interval.Value,
            };
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (this.robotService != null)
            {
                this.robotService.Stop();
            }

            CreateRobotManager();

            this.robotService.Start();

            this.timer.Enabled = true;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if (this.robotService == null)
            {
                return;
            }
            this.robotService.Stop();

            this.timer.Enabled = false;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            lblStatistics_ElapsedValue.Text = $"{this.robotService.ElapsedMilliseconds} ms";
            var statistics = this.robotService.Statistics;
            lblStatistics_CompletedValue.Text = $"{statistics.Completed} ({statistics.CompletedPercentage:F2}%)";
            lblStatistics_LeftValue.Text = $"{statistics.Left} ({statistics.LeftPercentage:F2}%)";
            lblStatistics_ProcessedRedValue.Text = $"{statistics.CompletedRed} ({statistics.CompletedRedPercentage:F2}%)";
            lblStatistics_ProcessedGreenValue.Text = $"{statistics.CompletedGreen} ({statistics.CompletedGreenPercentage:F2}%)";
            lblStatistics_ProcessedBlueValue.Text = $"{statistics.CompletedBlue} ({statistics.CompletedBluePercentage:F2}%)";
        }
    }
}
