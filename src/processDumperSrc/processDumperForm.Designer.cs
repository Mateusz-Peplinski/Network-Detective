
namespace Network_Detective.src.processDumperClass
{
    partial class processDumperForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(processDumperForm));
            this.processListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.startDump = new System.Windows.Forms.Button();
            this.dumpStatusTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.fileSaveBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // processListBox
            // 
            this.processListBox.FormattingEnabled = true;
            this.processListBox.Location = new System.Drawing.Point(12, 33);
            this.processListBox.Name = "processListBox";
            this.processListBox.Size = new System.Drawing.Size(216, 394);
            this.processListBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Running Processes:";
            // 
            // startDump
            // 
            this.startDump.BackColor = System.Drawing.Color.Crimson;
            this.startDump.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startDump.Location = new System.Drawing.Point(407, 104);
            this.startDump.Name = "startDump";
            this.startDump.Size = new System.Drawing.Size(100, 33);
            this.startDump.TabIndex = 3;
            this.startDump.Text = "Dump";
            this.startDump.UseVisualStyleBackColor = false;
            this.startDump.Click += new System.EventHandler(this.startDump_Click);
            // 
            // dumpStatusTextBox
            // 
            this.dumpStatusTextBox.Location = new System.Drawing.Point(319, 33);
            this.dumpStatusTextBox.Name = "dumpStatusTextBox";
            this.dumpStatusTextBox.ReadOnly = true;
            this.dumpStatusTextBox.Size = new System.Drawing.Size(373, 20);
            this.dumpStatusTextBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(242, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Dump Status:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(241, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "File Saved at:";
            // 
            // fileSaveBox
            // 
            this.fileSaveBox.Location = new System.Drawing.Point(319, 62);
            this.fileSaveBox.Name = "fileSaveBox";
            this.fileSaveBox.ReadOnly = true;
            this.fileSaveBox.Size = new System.Drawing.Size(373, 20);
            this.fileSaveBox.TabIndex = 7;
            // 
            // processDumperForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 450);
            this.Controls.Add(this.fileSaveBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dumpStatusTextBox);
            this.Controls.Add(this.startDump);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.processListBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "processDumperForm";
            this.Text = "Network Detective (Process Dump)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox processListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button startDump;
        private System.Windows.Forms.TextBox dumpStatusTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox fileSaveBox;
    }
}