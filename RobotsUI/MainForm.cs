using System;
using System.Drawing;
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

            groupRobots.Controls.Add(new RobotIcon()
            {
                ForeColor = Color.Tomato,
                Location = new Point(lblRobots_UsedRedValue.Left, 10)
            });
            groupRobots.Controls.Add(new RobotIcon()
            {
                ForeColor = Color.DarkGreen,
                Location = new Point(lblRobots_UsedGreenValue.Left, 10)
            });
            groupRobots.Controls.Add(new RobotIcon()
            {
                ForeColor = Color.CornflowerBlue,
                Location = new Point(lblRobots_UsedBlueValue.Left, 10)
            });
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

            var statistics = this.robotService.Statistics();
            var elementStat = statistics.ElementStatistics;
            var robotStat = statistics.RobotStatistics;

            lblStatistics_CompletedValue.Text = $"{elementStat.Completed} ({elementStat.CompletedPercentage:F2}%)";
            lblStatistics_LeftValue.Text = $"{elementStat.Left} ({elementStat.LeftPercentage:F2}%)";
            lblStatistics_ProcessedRedValue.Text = $"{elementStat.CompletedRed} ({elementStat.CompletedRedPercentage:F2}%)";
            lblStatistics_ProcessedGreenValue.Text = $"{elementStat.CompletedGreen} ({elementStat.CompletedGreenPercentage:F2}%)";
            lblStatistics_ProcessedBlueValue.Text = $"{elementStat.CompletedBlue} ({elementStat.CompletedBluePercentage:F2}%)";

            lblRobots_UsedRedValue.Text = $"{robotStat.BusyRed} / {(int)numericConfiguration_RobotsRed.Value}";
            lblRobots_UsedGreenValue.Text = $"{robotStat.BusyGreen} / {(int)numericConfiguration_RobotsGreen.Value}";
            lblRobots_UsedBlueValue.Text = $"{robotStat.BusyBlue} / {(int)numericConfiguration_RobotsBlue.Value}";
            lblRobots_TimeRedValue.Text = $"{robotStat.TimeTotalRed} ms";
            lblRobots_TimeGreenValue.Text = $"{robotStat.TimeTotalGreen} ms";
            lblRobots_TimeBlueValue.Text = $"{robotStat.TimeTotalBlue} ms";
        }
    }
}
