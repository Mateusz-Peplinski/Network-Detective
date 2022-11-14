
namespace Network_Detective.subnetClass
{
    partial class rangeScan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rangeScan));
            this.startAdvScan = new System.Windows.Forms.Button();
            this.IPAddrRange1 = new System.Windows.Forms.TextBox();
            this.IPAddrRange0 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.subnetTextBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.advScanMainTextBox = new System.Windows.Forms.TextBox();
            this.stopAdvScan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // startAdvScan
            // 
            this.startAdvScan.BackColor = System.Drawing.Color.LawnGreen;
            this.startAdvScan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.startAdvScan.Location = new System.Drawing.Point(332, 9);
            this.startAdvScan.Name = "startAdvScan";
            this.startAdvScan.Size = new System.Drawing.Size(75, 23);
            this.startAdvScan.TabIndex = 0;
            this.startAdvScan.Text = "Start";
            this.startAdvScan.UseVisualStyleBackColor = false;
            this.startAdvScan.Click += new System.EventHandler(this.startAdvScan_Click);
            // 
            // IPAddrRange1
            // 
            this.IPAddrRange1.Location = new System.Drawing.Point(184, 16);
            this.IPAddrRange1.Name = "IPAddrRange1";
            this.IPAddrRange1.Size = new System.Drawing.Size(100, 20);
            this.IPAddrRange1.TabIndex = 1;
            // 
            // IPAddrRange0
            // 
            this.IPAddrRange0.Location = new System.Drawing.Point(65, 16);
            this.IPAddrRange0.Name = "IPAddrRange0";
            this.IPAddrRange0.Size = new System.Drawing.Size(100, 20);
            this.IPAddrRange0.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "IP Range:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(167, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "to";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Subnet (Default is \\24): ";
            // 
            // subnetTextBox
            // 
            this.subnetTextBox.Location = new System.Drawing.Point(15, 64);
            this.subnetTextBox.Name = "subnetTextBox";
            this.subnetTextBox.Size = new System.Drawing.Size(56, 20);
            this.subnetTextBox.TabIndex = 10;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(128, 43);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Show Valid Subnets ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // advScanMainTextBox
            // 
            this.advScanMainTextBox.Location = new System.Drawing.Point(12, 99);
            this.advScanMainTextBox.Multiline = true;
            this.advScanMainTextBox.Name = "advScanMainTextBox";
            this.advScanMainTextBox.Size = new System.Drawing.Size(414, 339);
            this.advScanMainTextBox.TabIndex = 12;
            // 
            // stopAdvScan
            // 
            this.stopAdvScan.BackColor = System.Drawing.Color.Crimson;
            this.stopAdvScan.Location = new System.Drawing.Point(332, 43);
            this.stopAdvScan.Name = "stopAdvScan";
            this.stopAdvScan.Size = new System.Drawing.Size(75, 23);
            this.stopAdvScan.TabIndex = 13;
            this.stopAdvScan.Text = "Stop";
            this.stopAdvScan.UseVisualStyleBackColor = false;
            this.stopAdvScan.Click += new System.EventHandler(this.stopAdvScan_Click);
            // 
            // rangeScan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(441, 450);
            this.Controls.Add(this.stopAdvScan);
            this.Controls.Add(this.advScanMainTextBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.subnetTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IPAddrRange0);
            this.Controls.Add(this.IPAddrRange1);
            this.Controls.Add(this.startAdvScan);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "rangeScan";
            this.Text = "Network Detective (IP Range Scan)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.advSubnetScan_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startAdvScan;
        private System.Windows.Forms.TextBox IPAddrRange1;
        private System.Windows.Forms.TextBox IPAddrRange0;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox subnetTextBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox advScanMainTextBox;
        private System.Windows.Forms.Button stopAdvScan;
    }
}