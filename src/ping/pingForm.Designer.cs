
namespace Network_Detective
{
    partial class pingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pingForm));
            this.userIPAddrBox = new System.Windows.Forms.TextBox();
            this.startPingButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.statusBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.testLoopbackButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userIPAddrBox
            // 
            this.userIPAddrBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.userIPAddrBox.ForeColor = System.Drawing.Color.LawnGreen;
            this.userIPAddrBox.Location = new System.Drawing.Point(68, 38);
            this.userIPAddrBox.Name = "userIPAddrBox";
            this.userIPAddrBox.Size = new System.Drawing.Size(218, 20);
            this.userIPAddrBox.TabIndex = 0;
            // 
            // startPingButton
            // 
            this.startPingButton.BackColor = System.Drawing.Color.LawnGreen;
            this.startPingButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.startPingButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startPingButton.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.startPingButton.Location = new System.Drawing.Point(317, 36);
            this.startPingButton.Name = "startPingButton";
            this.startPingButton.Size = new System.Drawing.Size(75, 23);
            this.startPingButton.TabIndex = 1;
            this.startPingButton.Text = "PING";
            this.startPingButton.UseVisualStyleBackColor = false;
            this.startPingButton.Click += new System.EventHandler(this.startPingButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Status:";
            // 
            // statusBox
            // 
            this.statusBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.statusBox.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.statusBox.ForeColor = System.Drawing.Color.LawnGreen;
            this.statusBox.Location = new System.Drawing.Point(68, 74);
            this.statusBox.Name = "statusBox";
            this.statusBox.ReadOnly = true;
            this.statusBox.Size = new System.Drawing.Size(100, 20);
            this.statusBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "IP Address:";
            // 
            // testLoopbackButton
            // 
            this.testLoopbackButton.BackColor = System.Drawing.Color.LawnGreen;
            this.testLoopbackButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.testLoopbackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.testLoopbackButton.ForeColor = System.Drawing.Color.Black;
            this.testLoopbackButton.Location = new System.Drawing.Point(301, 91);
            this.testLoopbackButton.Name = "testLoopbackButton";
            this.testLoopbackButton.Size = new System.Drawing.Size(110, 23);
            this.testLoopbackButton.TabIndex = 5;
            this.testLoopbackButton.Text = "Test Loopback";
            this.testLoopbackButton.UseVisualStyleBackColor = false;
            this.testLoopbackButton.Click += new System.EventHandler(this.testLoopbackButton_Click);
            // 
            // pingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(420, 121);
            this.Controls.Add(this.testLoopbackButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.statusBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.startPingButton);
            this.Controls.Add(this.userIPAddrBox);
            this.ForeColor = System.Drawing.Color.LawnGreen;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "pingForm";
            this.Text = "Network Detective (PING)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox userIPAddrBox;
        private System.Windows.Forms.Button startPingButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox statusBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button testLoopbackButton;
    }
}