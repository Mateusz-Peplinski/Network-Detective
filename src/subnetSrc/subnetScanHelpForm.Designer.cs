
namespace Network_Detective
{
    partial class subnetScanHelpForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(subnetScanHelpForm));
            this.helpTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // helpTextBox
            // 
            this.helpTextBox.BackColor = System.Drawing.SystemColors.ControlDark;
            this.helpTextBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.helpTextBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.helpTextBox.Location = new System.Drawing.Point(12, 11);
            this.helpTextBox.Multiline = true;
            this.helpTextBox.Name = "helpTextBox";
            this.helpTextBox.ReadOnly = true;
            this.helpTextBox.Size = new System.Drawing.Size(516, 184);
            this.helpTextBox.TabIndex = 0;
            // 
            // subnetScanHelpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(542, 207);
            this.Controls.Add(this.helpTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "subnetScanHelpForm";
            this.Text = "Subnet Scan Help";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox helpTextBox;
    }
}