
namespace Network_Detective
{
    partial class mainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainMenu));
            this.RH_tools = new System.Windows.Forms.Button();
            this.NH_Tools = new System.Windows.Forms.Button();
            this.NI_tools = new System.Windows.Forms.Button();
            this.server1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.server1)).BeginInit();
            this.SuspendLayout();
            // 
            // RH_tools
            // 
            this.RH_tools.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.RH_tools.BackColor = System.Drawing.Color.Transparent;
            this.RH_tools.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.RH_tools.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RH_tools.FlatAppearance.BorderSize = 0;
            this.RH_tools.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.RH_tools.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.RH_tools.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RH_tools.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RH_tools.ForeColor = System.Drawing.Color.Red;
            this.RH_tools.Location = new System.Drawing.Point(207, 228);
            this.RH_tools.Name = "RH_tools";
            this.RH_tools.Size = new System.Drawing.Size(205, 38);
            this.RH_tools.TabIndex = 15;
            this.RH_tools.Text = "Remote Host Infomation Tools";
            this.RH_tools.UseVisualStyleBackColor = false;
            this.RH_tools.Click += new System.EventHandler(this.RH_tools_Click);
            // 
            // NH_Tools
            // 
            this.NH_Tools.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.NH_Tools.BackColor = System.Drawing.Color.Transparent;
            this.NH_Tools.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.NH_Tools.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NH_Tools.FlatAppearance.BorderSize = 0;
            this.NH_Tools.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.NH_Tools.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.NH_Tools.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NH_Tools.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NH_Tools.ForeColor = System.Drawing.Color.Red;
            this.NH_Tools.Location = new System.Drawing.Point(207, 322);
            this.NH_Tools.Name = "NH_Tools";
            this.NH_Tools.Size = new System.Drawing.Size(205, 39);
            this.NH_Tools.TabIndex = 16;
            this.NH_Tools.Text = "Network Hardware Information Tools";
            this.NH_Tools.UseVisualStyleBackColor = false;
            this.NH_Tools.Click += new System.EventHandler(this.NH_Tools_Click);
            // 
            // NI_tools
            // 
            this.NI_tools.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.NI_tools.BackColor = System.Drawing.Color.Transparent;
            this.NI_tools.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.NI_tools.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NI_tools.FlatAppearance.BorderSize = 0;
            this.NI_tools.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.NI_tools.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.NI_tools.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NI_tools.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NI_tools.ForeColor = System.Drawing.Color.Red;
            this.NI_tools.Location = new System.Drawing.Point(207, 128);
            this.NI_tools.Name = "NI_tools";
            this.NI_tools.Size = new System.Drawing.Size(205, 44);
            this.NI_tools.TabIndex = 14;
            this.NI_tools.Text = "Network Infomation Tools";
            this.NI_tools.UseVisualStyleBackColor = false;
            this.NI_tools.Click += new System.EventHandler(this.NI_tools_Click);
            // 
            // server1
            // 
            this.server1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.server1.BackColor = System.Drawing.Color.Transparent;
            this.server1.Image = global::Network_Detective.Properties.Resources.serverFrame1;
            this.server1.Location = new System.Drawing.Point(497, 221);
            this.server1.Name = "server1";
            this.server1.Size = new System.Drawing.Size(118, 149);
            this.server1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.server1.TabIndex = 12;
            this.server1.TabStop = false;
            // 
            // mainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.BackgroundImage = global::Network_Detective.Properties.Resources.mainBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(616, 411);
            this.Controls.Add(this.server1);
            this.Controls.Add(this.NH_Tools);
            this.Controls.Add(this.RH_tools);
            this.Controls.Add(this.NI_tools);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "mainMenu";
            this.Text = "Network Detective";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.mainMenu_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.server1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox server1;
        private System.Windows.Forms.Button NI_tools;
        private System.Windows.Forms.Button RH_tools;
        private System.Windows.Forms.Button NH_Tools;
    }
}

