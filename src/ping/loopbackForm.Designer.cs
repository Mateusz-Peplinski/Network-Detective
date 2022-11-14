
namespace Network_Detective
{
    partial class loopbackForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loopbackForm));
            this.loopbackStatusTextbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // loopbackStatusTextbox
            // 
            this.loopbackStatusTextbox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.loopbackStatusTextbox.ForeColor = System.Drawing.Color.LawnGreen;
            this.loopbackStatusTextbox.Location = new System.Drawing.Point(12, 12);
            this.loopbackStatusTextbox.Multiline = true;
            this.loopbackStatusTextbox.Name = "loopbackStatusTextbox";
            this.loopbackStatusTextbox.ReadOnly = true;
            this.loopbackStatusTextbox.Size = new System.Drawing.Size(376, 49);
            this.loopbackStatusTextbox.TabIndex = 0;
            // 
            // loopbackForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(400, 73);
            this.Controls.Add(this.loopbackStatusTextbox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "loopbackForm";
            this.Text = "Network Detective (Loopback Test)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox loopbackStatusTextbox;
    }
}