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
            this.groupConfiguration = new System.Windows.Forms.GroupBox();
            this.lblConfiguration_Elements = new System.Windows.Forms.Label();
            this.numericConfiguration_Elements = new System.Windows.Forms.NumericUpDown();
            this.numericConfiguration_RobotsRed = new System.Windows.Forms.NumericUpDown();
            this.lblConfiguration_RobotsRed = new System.Windows.Forms.Label();
            this.numericConfiguration_RobotsRed_Interval = new System.Windows.Forms.NumericUpDown();
            this.lblConfiguration_RobotsRed_Interval = new System.Windows.Forms.Label();
            this.numericConfiguration_RobotsGreen_Interval = new System.Windows.Forms.NumericUpDown();
            this.lblConfiguration_RobotsGreen_Interval = new System.Windows.Forms.Label();
            this.numericConfiguration_RobotsGreen = new System.Windows.Forms.NumericUpDown();
            this.lblConfiguration_RobotsGreen = new System.Windows.Forms.Label();
            this.numericConfiguration_RobotsBlue_Interval = new System.Windows.Forms.NumericUpDown();
            this.lblConfiguration_RobotsBlue_Interval = new System.Windows.Forms.Label();
            this.numericConfiguration_RobotsBlue = new System.Windows.Forms.NumericUpDown();
            this.lblConfiguration_RobotsBlue = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.groupConfiguration.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericConfiguration_Elements)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericConfiguration_RobotsRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericConfiguration_RobotsRed_Interval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericConfiguration_RobotsGreen_Interval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericConfiguration_RobotsGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericConfiguration_RobotsBlue_Interval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericConfiguration_RobotsBlue)).BeginInit();
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
            this.groupConfiguration.Location = new System.Drawing.Point(24, 27);
            this.groupConfiguration.Name = "groupConfiguration";
            this.groupConfiguration.Size = new System.Drawing.Size(382, 160);
            this.groupConfiguration.TabIndex = 0;
            this.groupConfiguration.TabStop = false;
            this.groupConfiguration.Text = "Configuration";
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
            // numericConfiguration_RobotsRed
            // 
            this.numericConfiguration_RobotsRed.Location = new System.Drawing.Point(111, 58);
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
            this.lblConfiguration_RobotsRed.Location = new System.Drawing.Point(16, 62);
            this.lblConfiguration_RobotsRed.Name = "lblConfiguration_RobotsRed";
            this.lblConfiguration_RobotsRed.Size = new System.Drawing.Size(62, 13);
            this.lblConfiguration_RobotsRed.TabIndex = 2;
            this.lblConfiguration_RobotsRed.Text = "Robots red:";
            // 
            // numericConfiguration_RobotsRed_Interval
            // 
            this.numericConfiguration_RobotsRed_Interval.Location = new System.Drawing.Point(294, 58);
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
            this.lblConfiguration_RobotsRed_Interval.Location = new System.Drawing.Point(199, 62);
            this.lblConfiguration_RobotsRed_Interval.Name = "lblConfiguration_RobotsRed_Interval";
            this.lblConfiguration_RobotsRed_Interval.Size = new System.Drawing.Size(83, 13);
            this.lblConfiguration_RobotsRed_Interval.TabIndex = 4;
            this.lblConfiguration_RobotsRed_Interval.Text = "processing time:";
            // 
            // numericConfiguration_RobotsGreen_Interval
            // 
            this.numericConfiguration_RobotsGreen_Interval.Location = new System.Drawing.Point(295, 87);
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
            this.lblConfiguration_RobotsGreen_Interval.Location = new System.Drawing.Point(200, 91);
            this.lblConfiguration_RobotsGreen_Interval.Name = "lblConfiguration_RobotsGreen_Interval";
            this.lblConfiguration_RobotsGreen_Interval.Size = new System.Drawing.Size(83, 13);
            this.lblConfiguration_RobotsGreen_Interval.TabIndex = 8;
            this.lblConfiguration_RobotsGreen_Interval.Text = "processing time:";
            // 
            // numericConfiguration_RobotsGreen
            // 
            this.numericConfiguration_RobotsGreen.Location = new System.Drawing.Point(112, 87);
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
            this.lblConfiguration_RobotsGreen.Location = new System.Drawing.Point(16, 91);
            this.lblConfiguration_RobotsGreen.Name = "lblConfiguration_RobotsGreen";
            this.lblConfiguration_RobotsGreen.Size = new System.Drawing.Size(74, 13);
            this.lblConfiguration_RobotsGreen.TabIndex = 6;
            this.lblConfiguration_RobotsGreen.Text = "Robots green:";
            // 
            // numericConfiguration_RobotsBlue_Interval
            // 
            this.numericConfiguration_RobotsBlue_Interval.Location = new System.Drawing.Point(295, 116);
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
            this.lblConfiguration_RobotsBlue_Interval.Location = new System.Drawing.Point(200, 120);
            this.lblConfiguration_RobotsBlue_Interval.Name = "lblConfiguration_RobotsBlue_Interval";
            this.lblConfiguration_RobotsBlue_Interval.Size = new System.Drawing.Size(83, 13);
            this.lblConfiguration_RobotsBlue_Interval.TabIndex = 12;
            this.lblConfiguration_RobotsBlue_Interval.Text = "processing time:";
            // 
            // numericConfiguration_RobotsBlue
            // 
            this.numericConfiguration_RobotsBlue.Location = new System.Drawing.Point(112, 116);
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
            this.lblConfiguration_RobotsBlue.Location = new System.Drawing.Point(16, 120);
            this.lblConfiguration_RobotsBlue.Name = "lblConfiguration_RobotsBlue";
            this.lblConfiguration_RobotsBlue.Size = new System.Drawing.Size(67, 13);
            this.lblConfiguration_RobotsBlue.TabIndex = 10;
            this.lblConfiguration_RobotsBlue.Text = "Robots blue:";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(310, 382);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "&Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(416, 382);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 2;
            this.btnStop.Text = "S&top";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.groupConfiguration);
            this.Name = "MainForm";
            this.Text = "Elements Factory";
            this.groupConfiguration.ResumeLayout(false);
            this.groupConfiguration.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericConfiguration_Elements)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericConfiguration_RobotsRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericConfiguration_RobotsRed_Interval)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericConfiguration_RobotsGreen_Interval)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericConfiguration_RobotsGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericConfiguration_RobotsBlue_Interval)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericConfiguration_RobotsBlue)).EndInit();
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
    }
}

