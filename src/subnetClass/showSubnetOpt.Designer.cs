
namespace Network_Detective.subnetClass
{
    partial class showSubnetOpt
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
            this.showMaskTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // showMaskTextBox
            // 
            this.showMaskTextBox.Location = new System.Drawing.Point(12, 12);
            this.showMaskTextBox.Multiline = true;
            this.showMaskTextBox.Name = "showMaskTextBox";
            this.showMaskTextBox.ReadOnly = true;
            this.showMaskTextBox.Size = new System.Drawing.Size(236, 426);
            this.showMaskTextBox.TabIndex = 0;
            // 
            // showSubnetOpt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(261, 450);
            this.Controls.Add(this.showMaskTextBox);
            this.Name = "showSubnetOpt";
            this.Text = "Network Detective (Subnet Mask Options)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox showMaskTextBox;
    }
}