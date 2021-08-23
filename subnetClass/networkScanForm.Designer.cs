
namespace Network_Detective
{
    partial class subnetScanForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(subnetScanForm));
            this.showResultsBox0 = new System.Windows.Forms.TextBox();
            this.startnetworkScan = new System.Windows.Forms.Button();
            this.showIPAddr = new System.Windows.Forms.TextBox();
            this.ipAddrLable = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.userNetworkIPAddr = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AbortNetScannerThread = new System.Windows.Forms.Button();
            this.showResultsBox1 = new System.Windows.Forms.TextBox();
            this.showResultsBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.helpButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // showResultsBox0
            // 
            this.showResultsBox0.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.showResultsBox0.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.showResultsBox0.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showResultsBox0.Location = new System.Drawing.Point(248, 28);
            this.showResultsBox0.Multiline = true;
            this.showResultsBox0.Name = "showResultsBox0";
            this.showResultsBox0.ReadOnly = true;
            this.showResultsBox0.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.showResultsBox0.Size = new System.Drawing.Size(164, 219);
            this.showResultsBox0.TabIndex = 0;
            // 
            // startnetworkScan
            // 
            this.startnetworkScan.BackColor = System.Drawing.Color.LawnGreen;
            this.startnetworkScan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.startnetworkScan.Location = new System.Drawing.Point(11, 209);
            this.startnetworkScan.Name = "startnetworkScan";
            this.startnetworkScan.Size = new System.Drawing.Size(75, 23);
            this.startnetworkScan.TabIndex = 1;
            this.startnetworkScan.Text = "Start";
            this.startnetworkScan.UseVisualStyleBackColor = false;
            this.startnetworkScan.Click += new System.EventHandler(this.startnetworkScan_Click);
            // 
            // showIPAddr
            // 
            this.showIPAddr.Location = new System.Drawing.Point(12, 28);
            this.showIPAddr.Multiline = true;
            this.showIPAddr.Name = "showIPAddr";
            this.showIPAddr.ReadOnly = true;
            this.showIPAddr.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.showIPAddr.Size = new System.Drawing.Size(206, 104);
            this.showIPAddr.TabIndex = 2;
            // 
            // ipAddrLable
            // 
            this.ipAddrLable.AutoSize = true;
            this.ipAddrLable.Location = new System.Drawing.Point(9, 12);
            this.ipAddrLable.Name = "ipAddrLable";
            this.ipAddrLable.Size = new System.Drawing.Size(128, 13);
            this.ipAddrLable.TabIndex = 3;
            this.ipAddrLable.Text = "Your IP Addresses (IPv4):";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Enter Network Address to Scan:";
            // 
            // userNetworkIPAddr
            // 
            this.userNetworkIPAddr.Location = new System.Drawing.Point(12, 183);
            this.userNetworkIPAddr.Name = "userNetworkIPAddr";
            this.userNetworkIPAddr.Size = new System.Drawing.Size(206, 20);
            this.userNetworkIPAddr.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Eg: 192.168.1";
            // 
            // AbortNetScannerThread
            // 
            this.AbortNetScannerThread.BackColor = System.Drawing.Color.Crimson;
            this.AbortNetScannerThread.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AbortNetScannerThread.Location = new System.Drawing.Point(143, 209);
            this.AbortNetScannerThread.Name = "AbortNetScannerThread";
            this.AbortNetScannerThread.Size = new System.Drawing.Size(75, 23);
            this.AbortNetScannerThread.TabIndex = 7;
            this.AbortNetScannerThread.Text = "STOP";
            this.AbortNetScannerThread.UseVisualStyleBackColor = false;
            this.AbortNetScannerThread.Click += new System.EventHandler(this.AbortNetScannerThread_Click);
            // 
            // showResultsBox1
            // 
            this.showResultsBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.showResultsBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.showResultsBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showResultsBox1.Location = new System.Drawing.Point(459, 28);
            this.showResultsBox1.Multiline = true;
            this.showResultsBox1.Name = "showResultsBox1";
            this.showResultsBox1.ReadOnly = true;
            this.showResultsBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.showResultsBox1.Size = new System.Drawing.Size(164, 219);
            this.showResultsBox1.TabIndex = 8;
            // 
            // showResultsBox2
            // 
            this.showResultsBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.showResultsBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.showResultsBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showResultsBox2.Location = new System.Drawing.Point(671, 28);
            this.showResultsBox2.Multiline = true;
            this.showResultsBox2.Name = "showResultsBox2";
            this.showResultsBox2.ReadOnly = true;
            this.showResultsBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.showResultsBox2.Size = new System.Drawing.Size(164, 219);
            this.showResultsBox2.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(245, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Addresses .2 - .84";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(456, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Addresses .85 - .168";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(668, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Addresses .169 - .255";
            // 
            // helpButton
            // 
            this.helpButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.helpButton.Cursor = System.Windows.Forms.Cursors.Help;
            this.helpButton.Location = new System.Drawing.Point(3, 246);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(101, 23);
            this.helpButton.TabIndex = 13;
            this.helpButton.Text = "Help/About";
            this.helpButton.UseVisualStyleBackColor = true;
            this.helpButton.Click += new System.EventHandler(this.helpButton_Click);
            // 
            // subnetScanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(863, 272);
            this.Controls.Add(this.helpButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.showResultsBox2);
            this.Controls.Add(this.showResultsBox1);
            this.Controls.Add(this.AbortNetScannerThread);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.userNetworkIPAddr);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ipAddrLable);
            this.Controls.Add(this.showIPAddr);
            this.Controls.Add(this.startnetworkScan);
            this.Controls.Add(this.showResultsBox0);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "subnetScanForm";
            this.Text = "Network Detective (Subnet Scan)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.subnetScanForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox showResultsBox0;
        private System.Windows.Forms.Button startnetworkScan;
        private System.Windows.Forms.TextBox showIPAddr;
        private System.Windows.Forms.Label ipAddrLable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox userNetworkIPAddr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AbortNetScannerThread;
        private System.Windows.Forms.TextBox showResultsBox1;
        private System.Windows.Forms.TextBox showResultsBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button helpButton;
    }
}