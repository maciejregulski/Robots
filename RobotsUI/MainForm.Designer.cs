namespace RobotsUI
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupConfiguration = new System.Windows.Forms.GroupBox();
            this.numericConfiguration_RobotsBlue_Interval = new System.Windows.Forms.NumericUpDown();
            this.lblConfiguration_RobotsBlue_Interval = new System.Windows.Forms.Label();
            this.numericConfiguration_RobotsBlue = new System.Windows.Forms.NumericUpDown();
            this.lblConfiguration_RobotsBlue = new System.Windows.Forms.Label();
            this.numericConfiguration_RobotsGreen_Interval = new System.Windows.Forms.NumericUpDown();
            this.lblConfiguration_RobotsGreen_Interval = new System.Windows.Forms.Label();
            this.numericConfiguration_RobotsGreen = new System.Windows.Forms.NumericUpDown();
            this.lblConfiguration_RobotsGreen = new System.Windows.Forms.Label();
            this.numericConfiguration_RobotsRed_Interval = new System.Windows.Forms.NumericUpDown();
            this.lblConfiguration_RobotsRed_Interval = new System.Windows.Forms.Label();
            this.numericConfiguration_RobotsRed = new System.Windows.Forms.NumericUpDown();
            this.lblConfiguration_RobotsRed = new System.Windows.Forms.Label();
            this.numericConfiguration_Elements = new System.Windows.Forms.NumericUpDown();
            this.lblConfiguration_Elements = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.groupStatistics = new System.Windows.Forms.GroupBox();
            this.lblStatistics_ProcessedBlueValue = new System.Windows.Forms.Label();
            this.lblStatistics_ProcessedBlue = new System.Windows.Forms.Label();
            this.lblStatistics_ProcessedGreenValue = new System.Windows.Forms.Label();
            this.lblStatistics_ProcessedGreen = new System.Windows.Forms.Label();
            this.lblStatistics_ProcessedRedValue = new System.Windows.Forms.Label();
            this.lblStatistics_ProcessedRed = new System.Windows.Forms.Label();
            this.lblStatistics_LeftValue = new System.Windows.Forms.Label();
            this.lblStatistics_Left = new System.Windows.Forms.Label();
            this.lblStatistics_CompletedValue = new System.Windows.Forms.Label();
            this.lblStatistics_Completed = new System.Windows.Forms.Label();
            this.lblStatistics_ElapsedValue = new System.Windows.Forms.Label();
            this.lblStatistics_Elapsed = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.groupRobots = new System.Windows.Forms.GroupBox();
            this.lblRobots_TimeBlueValue = new System.Windows.Forms.Label();
            this.lblRobots_UsedBlueValue = new System.Windows.Forms.Label();
            this.lblRobots_TimeGreenValue = new System.Windows.Forms.Label();
            this.lblRobots_UsedGreenValue = new System.Windows.Forms.Label();
            this.lblRobots_TimeRedValue = new System.Windows.Forms.Label();
            this.lblRobots_UsedRedValue = new System.Windows.Forms.Label();
            this.lblRobots_ProcessingTime = new System.Windows.Forms.Label();
            this.lblRobots_Used = new System.Windows.Forms.Label();
            this.groupElements = new System.Windows.Forms.GroupBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.bindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupConfiguration.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericConfiguration_RobotsBlue_Interval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericConfiguration_RobotsBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericConfiguration_RobotsGreen_Interval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericConfiguration_RobotsGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericConfiguration_RobotsRed_Interval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericConfiguration_RobotsRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericConfiguration_Elements)).BeginInit();
            this.groupStatistics.SuspendLayout();
            this.groupRobots.SuspendLayout();
            this.groupElements.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupConfiguration
            // 
            this.groupConfiguration.Controls.Add(this.numericConfiguration_RobotsBlue_Interval);
            this.groupConfiguration.Controls.Add(this.lblConfiguration_RobotsBlue_Interval);
            this.groupConfiguration.Controls.Add(this.numericConfiguration_RobotsBlue);
            this.groupConfiguration.Controls.Add(this.lblConfiguration_RobotsBlue);
            this.groupConfiguration.Controls.Add(this.numericConfiguration_RobotsGreen_Interval);
            this.groupConfiguration.Controls.Add(this.lblConfiguration_RobotsGreen_Interval);
            this.groupConfiguration.Controls.Add(this.numericConfiguration_RobotsGreen);
            this.groupConfiguration.Controls.Add(this.lblConfiguration_RobotsGreen);
            this.groupConfiguration.Controls.Add(this.numericConfiguration_RobotsRed_Interval);
            this.groupConfiguration.Controls.Add(this.lblConfiguration_RobotsRed_Interval);
            this.groupConfiguration.Controls.Add(this.numericConfiguration_RobotsRed);
            this.groupConfiguration.Controls.Add(this.lblConfiguration_RobotsRed);
            this.groupConfiguration.Controls.Add(this.numericConfiguration_Elements);
            this.groupConfiguration.Controls.Add(this.lblConfiguration_Elements);
            this.groupConfiguration.Location = new System.Drawing.Point(24, 24);
            this.groupConfiguration.Name = "groupConfiguration";
            this.groupConfiguration.Size = new System.Drawing.Size(382, 187);
            this.groupConfiguration.TabIndex = 0;
            this.groupConfiguration.TabStop = false;
            this.groupConfiguration.Text = "Configuration";
            // 
            // numericConfiguration_RobotsBlue_Interval
            // 
            this.numericConfiguration_RobotsBlue_Interval.Location = new System.Drawing.Point(295, 126);
            this.numericConfiguration_RobotsBlue_Interval.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericConfiguration_RobotsBlue_Interval.Name = "numericConfiguration_RobotsBlue_Interval";
            this.numericConfiguration_RobotsBlue_Interval.Size = new System.Drawing.Size(66, 20);
            this.numericConfiguration_RobotsBlue_Interval.TabIndex = 13;
            this.numericConfiguration_RobotsBlue_Interval.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // lblConfiguration_RobotsBlue_Interval
            // 
            this.lblConfiguration_RobotsBlue_Interval.AutoSize = true;
            this.lblConfiguration_RobotsBlue_Interval.ForeColor = System.Drawing.Color.Blue;
            this.lblConfiguration_RobotsBlue_Interval.Location = new System.Drawing.Point(200, 130);
            this.lblConfiguration_RobotsBlue_Interval.Name = "lblConfiguration_RobotsBlue_Interval";
            this.lblConfiguration_RobotsBlue_Interval.Size = new System.Drawing.Size(83, 13);
            this.lblConfiguration_RobotsBlue_Interval.TabIndex = 12;
            this.lblConfiguration_RobotsBlue_Interval.Text = "processing time:";
            // 
            // numericConfiguration_RobotsBlue
            // 
            this.numericConfiguration_RobotsBlue.Location = new System.Drawing.Point(112, 126);
            this.numericConfiguration_RobotsBlue.Name = "numericConfiguration_RobotsBlue";
            this.numericConfiguration_RobotsBlue.Size = new System.Drawing.Size(66, 20);
            this.numericConfiguration_RobotsBlue.TabIndex = 11;
            this.numericConfiguration_RobotsBlue.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // lblConfiguration_RobotsBlue
            // 
            this.lblConfiguration_RobotsBlue.AutoSize = true;
            this.lblConfiguration_RobotsBlue.ForeColor = System.Drawing.Color.Blue;
            this.lblConfiguration_RobotsBlue.Location = new System.Drawing.Point(16, 130);
            this.lblConfiguration_RobotsBlue.Name = "lblConfiguration_RobotsBlue";
            this.lblConfiguration_RobotsBlue.Size = new System.Drawing.Size(67, 13);
            this.lblConfiguration_RobotsBlue.TabIndex = 10;
            this.lblConfiguration_RobotsBlue.Text = "Robots blue:";
            // 
            // numericConfiguration_RobotsGreen_Interval
            // 
            this.numericConfiguration_RobotsGreen_Interval.Location = new System.Drawing.Point(295, 97);
            this.numericConfiguration_RobotsGreen_Interval.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericConfiguration_RobotsGreen_Interval.Name = "numericConfiguration_RobotsGreen_Interval";
            this.numericConfiguration_RobotsGreen_Interval.Size = new System.Drawing.Size(66, 20);
            this.numericConfiguration_RobotsGreen_Interval.TabIndex = 9;
            this.numericConfiguration_RobotsGreen_Interval.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // lblConfiguration_RobotsGreen_Interval
            // 
            this.lblConfiguration_RobotsGreen_Interval.AutoSize = true;
            this.lblConfiguration_RobotsGreen_Interval.ForeColor = System.Drawing.Color.Green;
            this.lblConfiguration_RobotsGreen_Interval.Location = new System.Drawing.Point(200, 101);
            this.lblConfiguration_RobotsGreen_Interval.Name = "lblConfiguration_RobotsGreen_Interval";
            this.lblConfiguration_RobotsGreen_Interval.Size = new System.Drawing.Size(83, 13);
            this.lblConfiguration_RobotsGreen_Interval.TabIndex = 8;
            this.lblConfiguration_RobotsGreen_Interval.Text = "processing time:";
            // 
            // numericConfiguration_RobotsGreen
            // 
            this.numericConfiguration_RobotsGreen.Location = new System.Drawing.Point(112, 97);
            this.numericConfiguration_RobotsGreen.Name = "numericConfiguration_RobotsGreen";
            this.numericConfiguration_RobotsGreen.Size = new System.Drawing.Size(66, 20);
            this.numericConfiguration_RobotsGreen.TabIndex = 7;
            this.numericConfiguration_RobotsGreen.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // lblConfiguration_RobotsGreen
            // 
            this.lblConfiguration_RobotsGreen.AutoSize = true;
            this.lblConfiguration_RobotsGreen.ForeColor = System.Drawing.Color.Green;
            this.lblConfiguration_RobotsGreen.Location = new System.Drawing.Point(16, 101);
            this.lblConfiguration_RobotsGreen.Name = "lblConfiguration_RobotsGreen";
            this.lblConfiguration_RobotsGreen.Size = new System.Drawing.Size(74, 13);
            this.lblConfiguration_RobotsGreen.TabIndex = 6;
            this.lblConfiguration_RobotsGreen.Text = "Robots green:";
            // 
            // numericConfiguration_RobotsRed_Interval
            // 
            this.numericConfiguration_RobotsRed_Interval.Location = new System.Drawing.Point(294, 68);
            this.numericConfiguration_RobotsRed_Interval.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericConfiguration_RobotsRed_Interval.Name = "numericConfiguration_RobotsRed_Interval";
            this.numericConfiguration_RobotsRed_Interval.Size = new System.Drawing.Size(66, 20);
            this.numericConfiguration_RobotsRed_Interval.TabIndex = 5;
            this.numericConfiguration_RobotsRed_Interval.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // lblConfiguration_RobotsRed_Interval
            // 
            this.lblConfiguration_RobotsRed_Interval.AutoSize = true;
            this.lblConfiguration_RobotsRed_Interval.ForeColor = System.Drawing.Color.Red;
            this.lblConfiguration_RobotsRed_Interval.Location = new System.Drawing.Point(199, 72);
            this.lblConfiguration_RobotsRed_Interval.Name = "lblConfiguration_RobotsRed_Interval";
            this.lblConfiguration_RobotsRed_Interval.Size = new System.Drawing.Size(83, 13);
            this.lblConfiguration_RobotsRed_Interval.TabIndex = 4;
            this.lblConfiguration_RobotsRed_Interval.Text = "processing time:";
            // 
            // numericConfiguration_RobotsRed
            // 
            this.numericConfiguration_RobotsRed.Location = new System.Drawing.Point(111, 68);
            this.numericConfiguration_RobotsRed.Name = "numericConfiguration_RobotsRed";
            this.numericConfiguration_RobotsRed.Size = new System.Drawing.Size(66, 20);
            this.numericConfiguration_RobotsRed.TabIndex = 3;
            this.numericConfiguration_RobotsRed.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // lblConfiguration_RobotsRed
            // 
            this.lblConfiguration_RobotsRed.AutoSize = true;
            this.lblConfiguration_RobotsRed.ForeColor = System.Drawing.Color.Red;
            this.lblConfiguration_RobotsRed.Location = new System.Drawing.Point(16, 72);
            this.lblConfiguration_RobotsRed.Name = "lblConfiguration_RobotsRed";
            this.lblConfiguration_RobotsRed.Size = new System.Drawing.Size(62, 13);
            this.lblConfiguration_RobotsRed.TabIndex = 2;
            this.lblConfiguration_RobotsRed.Text = "Robots red:";
            // 
            // numericConfiguration_Elements
            // 
            this.numericConfiguration_Elements.Location = new System.Drawing.Point(111, 27);
            this.numericConfiguration_Elements.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericConfiguration_Elements.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericConfiguration_Elements.Name = "numericConfiguration_Elements";
            this.numericConfiguration_Elements.Size = new System.Drawing.Size(66, 20);
            this.numericConfiguration_Elements.TabIndex = 1;
            this.numericConfiguration_Elements.Value = new decimal(new int[] {
            1500,
            0,
            0,
            0});
            // 
            // lblConfiguration_Elements
            // 
            this.lblConfiguration_Elements.AutoSize = true;
            this.lblConfiguration_Elements.Location = new System.Drawing.Point(16, 31);
            this.lblConfiguration_Elements.Name = "lblConfiguration_Elements";
            this.lblConfiguration_Elements.Size = new System.Drawing.Size(78, 13);
            this.lblConfiguration_Elements.TabIndex = 0;
            this.lblConfiguration_Elements.Text = "Element count:";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(127, 395);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "&Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(233, 395);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 2;
            this.btnStop.Text = "S&top";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // groupStatistics
            // 
            this.groupStatistics.Controls.Add(this.lblStatistics_ProcessedBlueValue);
            this.groupStatistics.Controls.Add(this.lblStatistics_ProcessedBlue);
            this.groupStatistics.Controls.Add(this.lblStatistics_ProcessedGreenValue);
            this.groupStatistics.Controls.Add(this.lblStatistics_ProcessedGreen);
            this.groupStatistics.Controls.Add(this.lblStatistics_ProcessedRedValue);
            this.groupStatistics.Controls.Add(this.lblStatistics_ProcessedRed);
            this.groupStatistics.Controls.Add(this.lblStatistics_LeftValue);
            this.groupStatistics.Controls.Add(this.lblStatistics_Left);
            this.groupStatistics.Controls.Add(this.lblStatistics_CompletedValue);
            this.groupStatistics.Controls.Add(this.lblStatistics_Completed);
            this.groupStatistics.Controls.Add(this.lblStatistics_ElapsedValue);
            this.groupStatistics.Controls.Add(this.lblStatistics_Elapsed);
            this.groupStatistics.Location = new System.Drawing.Point(472, 231);
            this.groupStatistics.Name = "groupStatistics";
            this.groupStatistics.Size = new System.Drawing.Size(316, 187);
            this.groupStatistics.TabIndex = 3;
            this.groupStatistics.TabStop = false;
            this.groupStatistics.Text = "Statistics";
            // 
            // lblStatistics_ProcessedBlueValue
            // 
            this.lblStatistics_ProcessedBlueValue.AutoSize = true;
            this.lblStatistics_ProcessedBlueValue.Location = new System.Drawing.Point(139, 156);
            this.lblStatistics_ProcessedBlueValue.Name = "lblStatistics_ProcessedBlueValue";
            this.lblStatistics_ProcessedBlueValue.Size = new System.Drawing.Size(0, 13);
            this.lblStatistics_ProcessedBlueValue.TabIndex = 12;
            // 
            // lblStatistics_ProcessedBlue
            // 
            this.lblStatistics_ProcessedBlue.AutoSize = true;
            this.lblStatistics_ProcessedBlue.ForeColor = System.Drawing.Color.Blue;
            this.lblStatistics_ProcessedBlue.Location = new System.Drawing.Point(24, 155);
            this.lblStatistics_ProcessedBlue.Name = "lblStatistics_ProcessedBlue";
            this.lblStatistics_ProcessedBlue.Size = new System.Drawing.Size(98, 13);
            this.lblStatistics_ProcessedBlue.TabIndex = 11;
            this.lblStatistics_ProcessedBlue.Text = "Processed by Blue:";
            // 
            // lblStatistics_ProcessedGreenValue
            // 
            this.lblStatistics_ProcessedGreenValue.AutoSize = true;
            this.lblStatistics_ProcessedGreenValue.Location = new System.Drawing.Point(139, 130);
            this.lblStatistics_ProcessedGreenValue.Name = "lblStatistics_ProcessedGreenValue";
            this.lblStatistics_ProcessedGreenValue.Size = new System.Drawing.Size(0, 13);
            this.lblStatistics_ProcessedGreenValue.TabIndex = 10;
            // 
            // lblStatistics_ProcessedGreen
            // 
            this.lblStatistics_ProcessedGreen.AutoSize = true;
            this.lblStatistics_ProcessedGreen.ForeColor = System.Drawing.Color.Green;
            this.lblStatistics_ProcessedGreen.Location = new System.Drawing.Point(24, 129);
            this.lblStatistics_ProcessedGreen.Name = "lblStatistics_ProcessedGreen";
            this.lblStatistics_ProcessedGreen.Size = new System.Drawing.Size(106, 13);
            this.lblStatistics_ProcessedGreen.TabIndex = 9;
            this.lblStatistics_ProcessedGreen.Text = "Processed by Green:";
            // 
            // lblStatistics_ProcessedRedValue
            // 
            this.lblStatistics_ProcessedRedValue.AutoSize = true;
            this.lblStatistics_ProcessedRedValue.Location = new System.Drawing.Point(139, 104);
            this.lblStatistics_ProcessedRedValue.Name = "lblStatistics_ProcessedRedValue";
            this.lblStatistics_ProcessedRedValue.Size = new System.Drawing.Size(0, 13);
            this.lblStatistics_ProcessedRedValue.TabIndex = 8;
            // 
            // lblStatistics_ProcessedRed
            // 
            this.lblStatistics_ProcessedRed.AutoSize = true;
            this.lblStatistics_ProcessedRed.ForeColor = System.Drawing.Color.Red;
            this.lblStatistics_ProcessedRed.Location = new System.Drawing.Point(24, 103);
            this.lblStatistics_ProcessedRed.Name = "lblStatistics_ProcessedRed";
            this.lblStatistics_ProcessedRed.Size = new System.Drawing.Size(97, 13);
            this.lblStatistics_ProcessedRed.TabIndex = 7;
            this.lblStatistics_ProcessedRed.Text = "Processed by Red:";
            // 
            // lblStatistics_LeftValue
            // 
            this.lblStatistics_LeftValue.AutoSize = true;
            this.lblStatistics_LeftValue.Location = new System.Drawing.Point(139, 78);
            this.lblStatistics_LeftValue.Name = "lblStatistics_LeftValue";
            this.lblStatistics_LeftValue.Size = new System.Drawing.Size(0, 13);
            this.lblStatistics_LeftValue.TabIndex = 6;
            // 
            // lblStatistics_Left
            // 
            this.lblStatistics_Left.AutoSize = true;
            this.lblStatistics_Left.Location = new System.Drawing.Point(24, 77);
            this.lblStatistics_Left.Name = "lblStatistics_Left";
            this.lblStatistics_Left.Size = new System.Drawing.Size(28, 13);
            this.lblStatistics_Left.TabIndex = 5;
            this.lblStatistics_Left.Text = "Left:";
            // 
            // lblStatistics_CompletedValue
            // 
            this.lblStatistics_CompletedValue.AutoSize = true;
            this.lblStatistics_CompletedValue.Location = new System.Drawing.Point(139, 52);
            this.lblStatistics_CompletedValue.Name = "lblStatistics_CompletedValue";
            this.lblStatistics_CompletedValue.Size = new System.Drawing.Size(0, 13);
            this.lblStatistics_CompletedValue.TabIndex = 4;
            // 
            // lblStatistics_Completed
            // 
            this.lblStatistics_Completed.AutoSize = true;
            this.lblStatistics_Completed.Location = new System.Drawing.Point(24, 51);
            this.lblStatistics_Completed.Name = "lblStatistics_Completed";
            this.lblStatistics_Completed.Size = new System.Drawing.Size(60, 13);
            this.lblStatistics_Completed.TabIndex = 3;
            this.lblStatistics_Completed.Text = "Completed:";
            // 
            // lblStatistics_ElapsedValue
            // 
            this.lblStatistics_ElapsedValue.AutoSize = true;
            this.lblStatistics_ElapsedValue.Location = new System.Drawing.Point(139, 26);
            this.lblStatistics_ElapsedValue.Name = "lblStatistics_ElapsedValue";
            this.lblStatistics_ElapsedValue.Size = new System.Drawing.Size(0, 13);
            this.lblStatistics_ElapsedValue.TabIndex = 2;
            // 
            // lblStatistics_Elapsed
            // 
            this.lblStatistics_Elapsed.AutoSize = true;
            this.lblStatistics_Elapsed.Location = new System.Drawing.Point(24, 25);
            this.lblStatistics_Elapsed.Name = "lblStatistics_Elapsed";
            this.lblStatistics_Elapsed.Size = new System.Drawing.Size(73, 13);
            this.lblStatistics_Elapsed.TabIndex = 1;
            this.lblStatistics_Elapsed.Text = "Time elapsed:";
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // groupRobots
            // 
            this.groupRobots.Controls.Add(this.lblRobots_TimeBlueValue);
            this.groupRobots.Controls.Add(this.lblRobots_UsedBlueValue);
            this.groupRobots.Controls.Add(this.lblRobots_TimeGreenValue);
            this.groupRobots.Controls.Add(this.lblRobots_UsedGreenValue);
            this.groupRobots.Controls.Add(this.lblRobots_TimeRedValue);
            this.groupRobots.Controls.Add(this.lblRobots_UsedRedValue);
            this.groupRobots.Controls.Add(this.lblRobots_ProcessingTime);
            this.groupRobots.Controls.Add(this.lblRobots_Used);
            this.groupRobots.Location = new System.Drawing.Point(24, 231);
            this.groupRobots.Name = "groupRobots";
            this.groupRobots.Size = new System.Drawing.Size(432, 98);
            this.groupRobots.TabIndex = 4;
            this.groupRobots.TabStop = false;
            this.groupRobots.Text = "Robots";
            // 
            // lblRobots_TimeBlueValue
            // 
            this.lblRobots_TimeBlueValue.AutoSize = true;
            this.lblRobots_TimeBlueValue.Location = new System.Drawing.Point(337, 72);
            this.lblRobots_TimeBlueValue.Name = "lblRobots_TimeBlueValue";
            this.lblRobots_TimeBlueValue.Size = new System.Drawing.Size(0, 13);
            this.lblRobots_TimeBlueValue.TabIndex = 8;
            // 
            // lblRobots_UsedBlueValue
            // 
            this.lblRobots_UsedBlueValue.AutoSize = true;
            this.lblRobots_UsedBlueValue.Location = new System.Drawing.Point(337, 46);
            this.lblRobots_UsedBlueValue.Name = "lblRobots_UsedBlueValue";
            this.lblRobots_UsedBlueValue.Size = new System.Drawing.Size(0, 13);
            this.lblRobots_UsedBlueValue.TabIndex = 7;
            // 
            // lblRobots_TimeGreenValue
            // 
            this.lblRobots_TimeGreenValue.AutoSize = true;
            this.lblRobots_TimeGreenValue.Location = new System.Drawing.Point(259, 72);
            this.lblRobots_TimeGreenValue.Name = "lblRobots_TimeGreenValue";
            this.lblRobots_TimeGreenValue.Size = new System.Drawing.Size(0, 13);
            this.lblRobots_TimeGreenValue.TabIndex = 6;
            // 
            // lblRobots_UsedGreenValue
            // 
            this.lblRobots_UsedGreenValue.AutoSize = true;
            this.lblRobots_UsedGreenValue.Location = new System.Drawing.Point(259, 46);
            this.lblRobots_UsedGreenValue.Name = "lblRobots_UsedGreenValue";
            this.lblRobots_UsedGreenValue.Size = new System.Drawing.Size(0, 13);
            this.lblRobots_UsedGreenValue.TabIndex = 5;
            // 
            // lblRobots_TimeRedValue
            // 
            this.lblRobots_TimeRedValue.AutoSize = true;
            this.lblRobots_TimeRedValue.Location = new System.Drawing.Point(182, 72);
            this.lblRobots_TimeRedValue.Name = "lblRobots_TimeRedValue";
            this.lblRobots_TimeRedValue.Size = new System.Drawing.Size(0, 13);
            this.lblRobots_TimeRedValue.TabIndex = 4;
            // 
            // lblRobots_UsedRedValue
            // 
            this.lblRobots_UsedRedValue.AutoSize = true;
            this.lblRobots_UsedRedValue.Location = new System.Drawing.Point(182, 46);
            this.lblRobots_UsedRedValue.Name = "lblRobots_UsedRedValue";
            this.lblRobots_UsedRedValue.Size = new System.Drawing.Size(0, 13);
            this.lblRobots_UsedRedValue.TabIndex = 3;
            // 
            // lblRobots_ProcessingTime
            // 
            this.lblRobots_ProcessingTime.AutoSize = true;
            this.lblRobots_ProcessingTime.Location = new System.Drawing.Point(16, 72);
            this.lblRobots_ProcessingTime.Name = "lblRobots_ProcessingTime";
            this.lblRobots_ProcessingTime.Size = new System.Drawing.Size(143, 13);
            this.lblRobots_ProcessingTime.TabIndex = 2;
            this.lblRobots_ProcessingTime.Text = "Robots total processing time:";
            // 
            // lblRobots_Used
            // 
            this.lblRobots_Used.AutoSize = true;
            this.lblRobots_Used.Location = new System.Drawing.Point(16, 46);
            this.lblRobots_Used.Name = "lblRobots_Used";
            this.lblRobots_Used.Size = new System.Drawing.Size(70, 13);
            this.lblRobots_Used.TabIndex = 1;
            this.lblRobots_Used.Text = "Robots used:";
            // 
            // groupElements
            // 
            this.groupElements.Controls.Add(this.dataGridView);
            this.groupElements.Location = new System.Drawing.Point(430, 24);
            this.groupElements.Name = "groupElements";
            this.groupElements.Size = new System.Drawing.Size(358, 187);
            this.groupElements.TabIndex = 5;
            this.groupElements.TabStop = false;
            this.groupElements.Text = "Elements";
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.GridColor = System.Drawing.Color.AliceBlue;
            this.dataGridView.Location = new System.Drawing.Point(7, 23);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.Size = new System.Drawing.Size(345, 152);
            this.dataGridView.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 450);
            this.Controls.Add(this.groupElements);
            this.Controls.Add(this.groupRobots);
            this.Controls.Add(this.groupStatistics);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.groupConfiguration);
            this.Name = "MainForm";
            this.Text = "Elements Factory";
            this.groupConfiguration.ResumeLayout(false);
            this.groupConfiguration.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericConfiguration_RobotsBlue_Interval)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericConfiguration_RobotsBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericConfiguration_RobotsGreen_Interval)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericConfiguration_RobotsGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericConfiguration_RobotsRed_Interval)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericConfiguration_RobotsRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericConfiguration_Elements)).EndInit();
            this.groupStatistics.ResumeLayout(false);
            this.groupStatistics.PerformLayout();
            this.groupRobots.ResumeLayout(false);
            this.groupRobots.PerformLayout();
            this.groupElements.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupConfiguration;
        private System.Windows.Forms.NumericUpDown numericConfiguration_RobotsBlue_Interval;
        private System.Windows.Forms.Label lblConfiguration_RobotsBlue_Interval;
        private System.Windows.Forms.NumericUpDown numericConfiguration_RobotsBlue;
        private System.Windows.Forms.Label lblConfiguration_RobotsBlue;
        private System.Windows.Forms.NumericUpDown numericConfiguration_RobotsGreen_Interval;
        private System.Windows.Forms.Label lblConfiguration_RobotsGreen_Interval;
        private System.Windows.Forms.NumericUpDown numericConfiguration_RobotsGreen;
        private System.Windows.Forms.Label lblConfiguration_RobotsGreen;
        private System.Windows.Forms.NumericUpDown numericConfiguration_RobotsRed_Interval;
        private System.Windows.Forms.Label lblConfiguration_RobotsRed_Interval;
        private System.Windows.Forms.NumericUpDown numericConfiguration_RobotsRed;
        private System.Windows.Forms.Label lblConfiguration_RobotsRed;
        private System.Windows.Forms.NumericUpDown numericConfiguration_Elements;
        private System.Windows.Forms.Label lblConfiguration_Elements;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.GroupBox groupStatistics;
        private System.Windows.Forms.Label lblStatistics_ProcessedBlueValue;
        private System.Windows.Forms.Label lblStatistics_ProcessedBlue;
        private System.Windows.Forms.Label lblStatistics_ProcessedGreenValue;
        private System.Windows.Forms.Label lblStatistics_ProcessedGreen;
        private System.Windows.Forms.Label lblStatistics_ProcessedRedValue;
        private System.Windows.Forms.Label lblStatistics_ProcessedRed;
        private System.Windows.Forms.Label lblStatistics_LeftValue;
        private System.Windows.Forms.Label lblStatistics_Left;
        private System.Windows.Forms.Label lblStatistics_CompletedValue;
        private System.Windows.Forms.Label lblStatistics_Completed;
        private System.Windows.Forms.Label lblStatistics_ElapsedValue;
        private System.Windows.Forms.Label lblStatistics_Elapsed;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.GroupBox groupRobots;
        private System.Windows.Forms.Label lblRobots_ProcessingTime;
        private System.Windows.Forms.Label lblRobots_Used;
        private System.Windows.Forms.Label lblRobots_TimeBlueValue;
        private System.Windows.Forms.Label lblRobots_UsedBlueValue;
        private System.Windows.Forms.Label lblRobots_TimeGreenValue;
        private System.Windows.Forms.Label lblRobots_UsedGreenValue;
        private System.Windows.Forms.Label lblRobots_TimeRedValue;
        private System.Windows.Forms.Label lblRobots_UsedRedValue;
        private System.Windows.Forms.GroupBox groupElements;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.BindingSource bindingSource;
    }
}

