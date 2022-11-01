
namespace Network_Detective
{
    partial class networkAdapterInformationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(networkAdapterInformationForm));
            this.mainListBox = new System.Windows.Forms.ListBox();
            this.titleText = new System.Windows.Forms.Label();
            this.numOfAdapt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mainListBox
            // 
            this.mainListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainListBox.BackColor = System.Drawing.SystemColors.WindowText;
            this.mainListBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.mainListBox.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainListBox.ForeColor = System.Drawing.SystemColors.Window;
            this.mainListBox.FormattingEnabled = true;
            this.mainListBox.ItemHeight = 19;
            this.mainListBox.Location = new System.Drawing.Point(12, 50);
            this.mainListBox.Name = "mainListBox";
            this.mainListBox.Size = new System.Drawing.Size(761, 631);
            this.mainListBox.TabIndex = 0;
            // 
            // titleText
            // 
            this.titleText.AutoSize = true;
            this.titleText.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleText.ForeColor = System.Drawing.Color.White;
            this.titleText.Location = new System.Drawing.Point(12, 9);
            this.titleText.Name = "titleText";
            this.titleText.Size = new System.Drawing.Size(49, 15);
            this.titleText.TabIndex = 1;
            this.titleText.Text = "label1";
            // 
            // numOfAdapt
            // 
            this.numOfAdapt.AutoSize = true;
            this.numOfAdapt.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numOfAdapt.ForeColor = System.Drawing.Color.White;
            this.numOfAdapt.Location = new System.Drawing.Point(12, 32);
            this.numOfAdapt.Name = "numOfAdapt";
            this.numOfAdapt.Size = new System.Drawing.Size(49, 15);
            this.numOfAdapt.TabIndex = 2;
            this.numOfAdapt.Text = "label1";
            // 
            // networkAdapterInformationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(783, 707);
            this.Controls.Add(this.numOfAdapt);
            this.Controls.Add(this.titleText);
            this.Controls.Add(this.mainListBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "networkAdapterInformationForm";
            this.Text = "Network Detective (Network Adapter Infomation)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox mainListBox;
        private System.Windows.Forms.Label titleText;
        private System.Windows.Forms.Label numOfAdapt;
    }
}