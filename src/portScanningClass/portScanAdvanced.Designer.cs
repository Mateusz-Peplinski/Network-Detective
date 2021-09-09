
namespace Network_Detective.portScanningClass
{
    partial class portScanAdvanced
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(portScanAdvanced));
            this.startAdvancedPortScan = new System.Windows.Forms.Button();
            this.stopAdvancedPortScan = new System.Windows.Forms.Button();
            this.userIPAddrPortAdv = new System.Windows.Forms.TextBox();
            this.showAdvPortScanResults = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.aboutTextBox = new System.Windows.Forms.TextBox();
            this.fullScancheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // startAdvancedPortScan
            // 
            this.startAdvancedPortScan.BackColor = System.Drawing.Color.LawnGreen;
            this.startAdvancedPortScan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.startAdvancedPortScan.ForeColor = System.Drawing.SystemColors.ControlText;
            this.startAdvancedPortScan.Location = new System.Drawing.Point(12, 80);
            this.startAdvancedPortScan.Name = "startAdvancedPortScan";
            this.startAdvancedPortScan.Size = new System.Drawing.Size(75, 23);
            this.startAdvancedPortScan.TabIndex = 0;
            this.startAdvancedPortScan.Text = "Start";
            this.startAdvancedPortScan.UseVisualStyleBackColor = false;
            this.startAdvancedPortScan.Click += new System.EventHandler(this.startAdvancedPortScan_Click);
            // 
            // stopAdvancedPortScan
            // 
            this.stopAdvancedPortScan.BackColor = System.Drawing.Color.Crimson;
            this.stopAdvancedPortScan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.stopAdvancedPortScan.Location = new System.Drawing.Point(127, 80);
            this.stopAdvancedPortScan.Name = "stopAdvancedPortScan";
            this.stopAdvancedPortScan.Size = new System.Drawing.Size(75, 23);
            this.stopAdvancedPortScan.TabIndex = 1;
            this.stopAdvancedPortScan.Text = "Stop";
            this.stopAdvancedPortScan.UseVisualStyleBackColor = false;
            this.stopAdvancedPortScan.Click += new System.EventHandler(this.stopAdvancedPortScan_Click);
            // 
            // userIPAddrPortAdv
            // 
            this.userIPAddrPortAdv.Location = new System.Drawing.Point(12, 28);
            this.userIPAddrPortAdv.Name = "userIPAddrPortAdv";
            this.userIPAddrPortAdv.Size = new System.Drawing.Size(190, 20);
            this.userIPAddrPortAdv.TabIndex = 2;
            // 
            // showAdvPortScanResults
            // 
            this.showAdvPortScanResults.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.showAdvPortScanResults.Location = new System.Drawing.Point(218, 28);
            this.showAdvPortScanResults.Multiline = true;
            this.showAdvPortScanResults.Name = "showAdvPortScanResults";
            this.showAdvPortScanResults.ReadOnly = true;
            this.showAdvPortScanResults.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.showAdvPortScanResults.Size = new System.Drawing.Size(350, 410);
            this.showAdvPortScanResults.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Enter Target IPv4 Address:";
            // 
            // aboutTextBox
            // 
            this.aboutTextBox.BackColor = System.Drawing.SystemColors.ControlDark;
            this.aboutTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.aboutTextBox.Cursor = System.Windows.Forms.Cursors.Help;
            this.aboutTextBox.Location = new System.Drawing.Point(12, 121);
            this.aboutTextBox.Multiline = true;
            this.aboutTextBox.Name = "aboutTextBox";
            this.aboutTextBox.ReadOnly = true;
            this.aboutTextBox.Size = new System.Drawing.Size(190, 83);
            this.aboutTextBox.TabIndex = 5;
            // 
            // fullScancheckBox
            // 
            this.fullScancheckBox.AutoSize = true;
            this.fullScancheckBox.Location = new System.Drawing.Point(15, 55);
            this.fullScancheckBox.Name = "fullScancheckBox";
            this.fullScancheckBox.Size = new System.Drawing.Size(70, 17);
            this.fullScancheckBox.TabIndex = 6;
            this.fullScancheckBox.Text = "Full Scan";
            this.fullScancheckBox.UseVisualStyleBackColor = true;
            // 
            // portScanAdvanced
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(576, 450);
            this.Controls.Add(this.fullScancheckBox);
            this.Controls.Add(this.aboutTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.showAdvPortScanResults);
            this.Controls.Add(this.userIPAddrPortAdv);
            this.Controls.Add(this.stopAdvancedPortScan);
            this.Controls.Add(this.startAdvancedPortScan);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "portScanAdvanced";
            this.Text = "Network Detective (Advanced Port Scan)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.portScanAdvanced_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startAdvancedPortScan;
        private System.Windows.Forms.Button stopAdvancedPortScan;
        private System.Windows.Forms.TextBox userIPAddrPortAdv;
        private System.Windows.Forms.TextBox showAdvPortScanResults;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox aboutTextBox;
        private System.Windows.Forms.CheckBox fullScancheckBox;
    }
}