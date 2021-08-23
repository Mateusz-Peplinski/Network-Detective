
namespace Network_Detective
{
    partial class portScanForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(portScanForm));
            this.portScanStartButton = new System.Windows.Forms.Button();
            this.userPingIPAddrTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.portScanStopButton = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.displayCommonPortScanResults = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // portScanStartButton
            // 
            this.portScanStartButton.BackColor = System.Drawing.Color.LawnGreen;
            this.portScanStartButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.portScanStartButton.Location = new System.Drawing.Point(12, 70);
            this.portScanStartButton.Name = "portScanStartButton";
            this.portScanStartButton.Size = new System.Drawing.Size(75, 23);
            this.portScanStartButton.TabIndex = 0;
            this.portScanStartButton.Text = "Start";
            this.portScanStartButton.UseVisualStyleBackColor = false;
            this.portScanStartButton.Click += new System.EventHandler(this.portScanStartButton_Click);
            // 
            // userPingIPAddrTextBox
            // 
            this.userPingIPAddrTextBox.Location = new System.Drawing.Point(12, 35);
            this.userPingIPAddrTextBox.Name = "userPingIPAddrTextBox";
            this.userPingIPAddrTextBox.Size = new System.Drawing.Size(156, 20);
            this.userPingIPAddrTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter Target IPv4 Address:";
            // 
            // portScanStopButton
            // 
            this.portScanStopButton.BackColor = System.Drawing.Color.Crimson;
            this.portScanStopButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.portScanStopButton.Location = new System.Drawing.Point(93, 70);
            this.portScanStopButton.Name = "portScanStopButton";
            this.portScanStopButton.Size = new System.Drawing.Size(75, 23);
            this.portScanStopButton.TabIndex = 3;
            this.portScanStopButton.Text = "STOP";
            this.portScanStopButton.UseVisualStyleBackColor = false;
            this.portScanStopButton.Click += new System.EventHandler(this.portScanStopButton_Click);
            // 
            // displayCommonPortScanResults
            // 
            this.displayCommonPortScanResults.Location = new System.Drawing.Point(12, 133);
            this.displayCommonPortScanResults.Multiline = true;
            this.displayCommonPortScanResults.Name = "displayCommonPortScanResults";
            this.displayCommonPortScanResults.ReadOnly = true;
            this.displayCommonPortScanResults.Size = new System.Drawing.Size(156, 305);
            this.displayCommonPortScanResults.TabIndex = 5;
            this.toolTip1.SetToolTip(this.displayCommonPortScanResults, "For full Port Scan go to Advanced Port Scan");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Common Port Scan Results:";
            // 
            // portScanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(182, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.displayCommonPortScanResults);
            this.Controls.Add(this.portScanStopButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.userPingIPAddrTextBox);
            this.Controls.Add(this.portScanStartButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "portScanForm";
            this.Text = "Network Detective (Port Scan)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.portScanForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button portScanStartButton;
        private System.Windows.Forms.TextBox userPingIPAddrTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button portScanStopButton;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox displayCommonPortScanResults;
        private System.Windows.Forms.Label label2;
    }
}