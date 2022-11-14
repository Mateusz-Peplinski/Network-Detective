
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wifiSpeedTestForm));
            this.startSpeedTestButton = new System.Windows.Forms.Button();
            this.currentSpeedtextBox = new System.Windows.Forms.TextBox();
            this.testNetInter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.stopSpeedTestButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // startSpeedTestButton
            // 
            this.startSpeedTestButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.startSpeedTestButton.BackColor = System.Drawing.Color.LawnGreen;
            this.startSpeedTestButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startSpeedTestButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.startSpeedTestButton.Location = new System.Drawing.Point(114, 180);
            this.startSpeedTestButton.Name = "startSpeedTestButton";
            this.startSpeedTestButton.Size = new System.Drawing.Size(75, 23);
            this.startSpeedTestButton.TabIndex = 0;
            this.startSpeedTestButton.Text = "Start";
            this.startSpeedTestButton.UseVisualStyleBackColor = false;
            this.startSpeedTestButton.Click += new System.EventHandler(this.startSpeedTestButton_Click);
            // 
            // currentSpeedtextBox
            // 
            this.currentSpeedtextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.currentSpeedtextBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.currentSpeedtextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.currentSpeedtextBox.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentSpeedtextBox.ForeColor = System.Drawing.Color.LawnGreen;
            this.currentSpeedtextBox.Location = new System.Drawing.Point(12, 12);
            this.currentSpeedtextBox.Multiline = true;
            this.currentSpeedtextBox.Name = "currentSpeedtextBox";
            this.currentSpeedtextBox.ReadOnly = true;
            this.currentSpeedtextBox.Size = new System.Drawing.Size(368, 162);
            this.currentSpeedtextBox.TabIndex = 1;
            // 
            // testNetInter
            // 
            this.testNetInter.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.testNetInter.BackColor = System.Drawing.Color.LawnGreen;
            this.testNetInter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.testNetInter.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.testNetInter.Location = new System.Drawing.Point(160, 229);
            this.testNetInter.Name = "testNetInter";
            this.testNetInter.Size = new System.Drawing.Size(75, 23);
            this.testNetInter.TabIndex = 3;
            this.testNetInter.Text = "Try";
            this.testNetInter.UseVisualStyleBackColor = false;
            this.testNetInter.Click += new System.EventHandler(this.testNetInter_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Test All Network Interfaces Max Speed:";
            // 
            // stopSpeedTestButton
            // 
            this.stopSpeedTestButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.stopSpeedTestButton.BackColor = System.Drawing.Color.Crimson;
            this.stopSpeedTestButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stopSpeedTestButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.stopSpeedTestButton.Location = new System.Drawing.Point(195, 180);
            this.stopSpeedTestButton.Name = "stopSpeedTestButton";
            this.stopSpeedTestButton.Size = new System.Drawing.Size(75, 23);
            this.stopSpeedTestButton.TabIndex = 5;
            this.stopSpeedTestButton.Text = "Start";
            this.stopSpeedTestButton.UseVisualStyleBackColor = false;
            // 
            // wifiSpeedTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(392, 278);
            this.Controls.Add(this.stopSpeedTestButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.testNetInter);
            this.Controls.Add(this.currentSpeedtextBox);
            this.Controls.Add(this.startSpeedTestButton);
            this.ForeColor = System.Drawing.Color.LawnGreen;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "wifiSpeedTestForm";
            this.Text = "Network Detective (WIFI Speed Test)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.wifiSpeedTestForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startSpeedTestButton;
        private System.Windows.Forms.TextBox currentSpeedtextBox;
        private System.Windows.Forms.Button testNetInter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button stopSpeedTestButton;
    }
}