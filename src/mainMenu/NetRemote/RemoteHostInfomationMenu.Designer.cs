namespace Network_Detective
{
    partial class RemoteHostInfomationMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RemoteHostInfomationMenu));
            this.portScan = new System.Windows.Forms.Button();
            this.AdvCheckBox = new System.Windows.Forms.CheckBox();
            this.TryPing = new System.Windows.Forms.Button();
            this.TraceRoute = new System.Windows.Forms.Button();
            this.GatherInteligence = new System.Windows.Forms.Button();
            this.GatherInteligenceCheckBox = new System.Windows.Forms.CheckBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.animatedTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // portScan
            // 
            this.portScan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.portScan.BackColor = System.Drawing.Color.Black;
            this.portScan.FlatAppearance.BorderSize = 0;
            this.portScan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.portScan.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.portScan.Location = new System.Drawing.Point(79, 147);
            this.portScan.Name = "portScan";
            this.portScan.Size = new System.Drawing.Size(159, 76);
            this.portScan.TabIndex = 0;
            this.portScan.Text = "Port Scanning";
            this.portScan.UseVisualStyleBackColor = false;
            this.portScan.Click += new System.EventHandler(this.portScan_Click);
            this.portScan.MouseEnter += new System.EventHandler(this.portScan_MouseEnter);
            this.portScan.MouseLeave += new System.EventHandler(this.portScan_MouseLeave);
            // 
            // AdvCheckBox
            // 
            this.AdvCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.AdvCheckBox.AutoSize = true;
            this.AdvCheckBox.Location = new System.Drawing.Point(95, 198);
            this.AdvCheckBox.Name = "AdvCheckBox";
            this.AdvCheckBox.Size = new System.Drawing.Size(125, 17);
            this.AdvCheckBox.TabIndex = 1;
            this.AdvCheckBox.Text = "Advanced Port Scan";
            this.AdvCheckBox.UseVisualStyleBackColor = true;
            // 
            // TryPing
            // 
            this.TryPing.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TryPing.BackColor = System.Drawing.Color.Black;
            this.TryPing.FlatAppearance.BorderSize = 0;
            this.TryPing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TryPing.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TryPing.Location = new System.Drawing.Point(79, 124);
            this.TryPing.Name = "TryPing";
            this.TryPing.Size = new System.Drawing.Size(159, 41);
            this.TryPing.TabIndex = 3;
            this.TryPing.Text = "Try Ping ";
            this.TryPing.UseVisualStyleBackColor = false;
            this.TryPing.Click += new System.EventHandler(this.TryPing_Click);
            this.TryPing.MouseEnter += new System.EventHandler(this.TryPing_MouseEnter);
            this.TryPing.MouseLeave += new System.EventHandler(this.TryPing_MouseLeave);
            // 
            // TraceRoute
            // 
            this.TraceRoute.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TraceRoute.BackColor = System.Drawing.Color.Black;
            this.TraceRoute.FlatAppearance.BorderSize = 0;
            this.TraceRoute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TraceRoute.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TraceRoute.Location = new System.Drawing.Point(79, 71);
            this.TraceRoute.Name = "TraceRoute";
            this.TraceRoute.Size = new System.Drawing.Size(159, 47);
            this.TraceRoute.TabIndex = 4;
            this.TraceRoute.Text = "Trace Route";
            this.TraceRoute.UseVisualStyleBackColor = false;
            this.TraceRoute.Click += new System.EventHandler(this.TraceRoute_Click);
            this.TraceRoute.MouseEnter += new System.EventHandler(this.TraceRoute_MouseEnter);
            this.TraceRoute.MouseLeave += new System.EventHandler(this.TraceRoute_MouseLeave);
            // 
            // GatherInteligence
            // 
            this.GatherInteligence.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.GatherInteligence.BackColor = System.Drawing.Color.Black;
            this.GatherInteligence.FlatAppearance.BorderSize = 0;
            this.GatherInteligence.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GatherInteligence.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GatherInteligence.Location = new System.Drawing.Point(69, 221);
            this.GatherInteligence.Name = "GatherInteligence";
            this.GatherInteligence.Size = new System.Drawing.Size(191, 41);
            this.GatherInteligence.TabIndex = 5;
            this.GatherInteligence.Text = "Gather Intelligence";
            this.GatherInteligence.UseVisualStyleBackColor = false;
            this.GatherInteligence.MouseEnter += new System.EventHandler(this.GatherInteligence_MouseEnter);
            this.GatherInteligence.MouseLeave += new System.EventHandler(this.GatherInteligence_MouseLeave);
            // 
            // GatherInteligenceCheckBox
            // 
            this.GatherInteligenceCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.GatherInteligenceCheckBox.AutoSize = true;
            this.GatherInteligenceCheckBox.Location = new System.Drawing.Point(69, 254);
            this.GatherInteligenceCheckBox.Name = "GatherInteligenceCheckBox";
            this.GatherInteligenceCheckBox.Size = new System.Drawing.Size(181, 17);
            this.GatherInteligenceCheckBox.TabIndex = 6;
            this.GatherInteligenceCheckBox.Text = "Advanced Intelligence Gathering";
            this.GatherInteligenceCheckBox.UseVisualStyleBackColor = true;
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = global::Network_Detective.Properties.Resources.pc;
            this.pictureBox10.Location = new System.Drawing.Point(2, 209);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(316, 270);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox10.TabIndex = 15;
            this.pictureBox10.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::Network_Detective.Properties.Resources.ePointerR;
            this.pictureBox8.Location = new System.Drawing.Point(2, 229);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(71, 27);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 14;
            this.pictureBox8.TabStop = false;
            this.pictureBox8.Visible = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = global::Network_Detective.Properties.Resources.ePointerL;
            this.pictureBox9.Location = new System.Drawing.Point(256, 229);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(71, 27);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox9.TabIndex = 13;
            this.pictureBox9.TabStop = false;
            this.pictureBox9.Visible = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::Network_Detective.Properties.Resources.ePointerR;
            this.pictureBox6.Location = new System.Drawing.Point(-11, 165);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(100, 50);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 12;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Visible = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::Network_Detective.Properties.Resources.ePointerL;
            this.pictureBox7.Location = new System.Drawing.Point(226, 165);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(100, 50);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 11;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Visible = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Network_Detective.Properties.Resources.ePointerR;
            this.pictureBox4.Location = new System.Drawing.Point(2, 124);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(100, 50);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 10;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Visible = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Network_Detective.Properties.Resources.ePointerL;
            this.pictureBox5.Location = new System.Drawing.Point(218, 124);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(100, 50);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 9;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Visible = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Network_Detective.Properties.Resources.ePointerR;
            this.pictureBox3.Location = new System.Drawing.Point(2, 71);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Network_Detective.Properties.Resources.ePointerL;
            this.pictureBox2.Location = new System.Drawing.Point(218, 71);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = global::Network_Detective.Properties.Resources.mainMenuTitle256;
            this.pictureBox1.Location = new System.Drawing.Point(41, -14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(244, 132);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // animatedTextBox
            // 
            this.animatedTextBox.BackColor = System.Drawing.SystemColors.MenuText;
            this.animatedTextBox.ForeColor = System.Drawing.Color.LawnGreen;
            this.animatedTextBox.Location = new System.Drawing.Point(95, 289);
            this.animatedTextBox.Multiline = true;
            this.animatedTextBox.Name = "animatedTextBox";
            this.animatedTextBox.ReadOnly = true;
            this.animatedTextBox.Size = new System.Drawing.Size(131, 106);
            this.animatedTextBox.TabIndex = 16;
            // 
            // RemoteHostInfomationMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(319, 450);
            this.Controls.Add(this.animatedTextBox);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.GatherInteligenceCheckBox);
            this.Controls.Add(this.GatherInteligence);
            this.Controls.Add(this.TraceRoute);
            this.Controls.Add(this.TryPing);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.AdvCheckBox);
            this.Controls.Add(this.portScan);
            this.Controls.Add(this.pictureBox10);
            this.ForeColor = System.Drawing.Color.LawnGreen;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RemoteHostInfomationMenu";
            this.Text = "Remote Host Information Menu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RemoteHostInfomationMenu_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button portScan;
        private System.Windows.Forms.CheckBox AdvCheckBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button TryPing;
        private System.Windows.Forms.Button TraceRoute;
        private System.Windows.Forms.Button GatherInteligence;
        private System.Windows.Forms.CheckBox GatherInteligenceCheckBox;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.TextBox animatedTextBox;
    }
}