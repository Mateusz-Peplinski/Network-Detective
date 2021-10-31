
namespace Network_Detective.src.speedTestSrc
{
    partial class wifiSpeedTestForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wifiSpeedTestForm));
            this.startSpeedTestButton = new System.Windows.Forms.Button();
            this.currentSpeedtextBox = new System.Windows.Forms.TextBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.testNetInter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // startSpeedTestButton
            // 
            this.startSpeedTestButton.BackColor = System.Drawing.Color.LawnGreen;
            this.startSpeedTestButton.Location = new System.Drawing.Point(99, 254);
            this.startSpeedTestButton.Name = "startSpeedTestButton";
            this.startSpeedTestButton.Size = new System.Drawing.Size(75, 23);
            this.startSpeedTestButton.TabIndex = 0;
            this.startSpeedTestButton.Text = "Start";
            this.startSpeedTestButton.UseVisualStyleBackColor = false;
            this.startSpeedTestButton.Click += new System.EventHandler(this.startSpeedTestButton_Click);
            // 
            // currentSpeedtextBox
            // 
            this.currentSpeedtextBox.Location = new System.Drawing.Point(12, 12);
            this.currentSpeedtextBox.Multiline = true;
            this.currentSpeedtextBox.Name = "currentSpeedtextBox";
            this.currentSpeedtextBox.ReadOnly = true;
            this.currentSpeedtextBox.Size = new System.Drawing.Size(258, 100);
            this.currentSpeedtextBox.TabIndex = 1;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(292, 38);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(300, 300);
            this.chart1.TabIndex = 2;
            this.chart1.Text = "chart1";
            // 
            // testNetInter
            // 
            this.testNetInter.BackColor = System.Drawing.Color.LawnGreen;
            this.testNetInter.Location = new System.Drawing.Point(12, 347);
            this.testNetInter.Name = "testNetInter";
            this.testNetInter.Size = new System.Drawing.Size(75, 23);
            this.testNetInter.TabIndex = 3;
            this.testNetInter.Text = "Try";
            this.testNetInter.UseVisualStyleBackColor = false;
            this.testNetInter.Click += new System.EventHandler(this.testNetInter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 331);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Test All Network Interfaces:";
            // 
            // wifiSpeedTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 382);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.testNetInter);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.currentSpeedtextBox);
            this.Controls.Add(this.startSpeedTestButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "wifiSpeedTestForm";
            this.Text = "Network Detective (WIFI Speed Test)";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startSpeedTestButton;
        private System.Windows.Forms.TextBox currentSpeedtextBox;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button testNetInter;
        private System.Windows.Forms.Label label1;
    }
}