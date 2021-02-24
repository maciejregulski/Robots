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
                this.robotService.Dispose();
            }

            CreateRobotManager();

            this.bindingSource.DataSource = this.robotService.Records;
            this.dataGridView.DataSource = this.bindingSource;
            this.dataGridView.Columns.Remove("IsPainted");
            this.dataGridView.Columns.Remove("IsComplete");
            this.dataGridView.Columns.Remove("State");
            this.dataGridView.Columns["Id"].Width = 54;
            this.dataGridView.Columns["IsRed"].Width = 90;
            this.dataGridView.Columns["IsGreen"].Width = 90;
            this.dataGridView.Columns["IsBlue"].Width = 90;

            //this.bindingSource.ListChanged += BindingSource_ListChanged;
            //this.dataGridView.CellFormatting += DataGridView_CellFormatting;

            this.robotService.Start();

            this.timer.Enabled = true;
        }

        private void ColorGridCells()
        {
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                DataGridViewCell cell = row.Cells["IsRed"];
                if (IsCellChecked(cell))
                {
                    SetCellBackColor(cell, Color.Tomato);
                }
                cell = row.Cells["IsGreen"];
                if (IsCellChecked(cell))
                {
                    SetCellBackColor(cell, Color.ForestGreen);
                }
                cell = row.Cells["IsBlue"];
                if (IsCellChecked(cell))
                {
                    SetCellBackColor(cell, Color.CornflowerBlue);
                }
            }
        }

        bool IsCellChecked(DataGridViewCell cell)
        {
            var value = cell.Value;
            return (value != null & Convert.ToBoolean(value) == true);
        }

        void SetCellBackColor(DataGridViewCell cell, Color color)
        {
            if (cell.Style == null)
            {
                cell.Style = (DataGridViewCellStyle) (cell.InheritedStyle.Clone());
            }
            cell.Style.BackColor = color;
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

            lblRobots_UsedRedValue.Text = $"{robotStat.BusyRed} / {this.robotService.NumberOfRedRobots}";
            lblRobots_UsedGreenValue.Text = $"{robotStat.BusyGreen} / {this.robotService.NumberOfGreenRobots}";
            lblRobots_UsedBlueValue.Text = $"{robotStat.BusyBlue} / {this.robotService.NumberOfBlueRobots}";
            lblRobots_TimeRedValue.Text = $"{robotStat.TimeTotalRed} ms";
            lblRobots_TimeGreenValue.Text = $"{robotStat.TimeTotalGreen} ms";
            lblRobots_TimeBlueValue.Text = $"{robotStat.TimeTotalBlue} ms";

            ColorGridCells();
        }
    }
}
