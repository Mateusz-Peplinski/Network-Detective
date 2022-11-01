
namespace Network_Detective
{
    partial class traceRouteForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(traceRouteForm));
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.startTraceButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.traceInputTextBox = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.stopTraceRoute = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // resultTextBox
            // 
            this.resultTextBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.resultTextBox.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultTextBox.ForeColor = System.Drawing.Color.Chartreuse;
            this.resultTextBox.Location = new System.Drawing.Point(252, 3);
            this.resultTextBox.Multiline = true;
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.ReadOnly = true;
            this.resultTextBox.Size = new System.Drawing.Size(545, 444);
            this.resultTextBox.TabIndex = 0;
            // 
            // startTraceButton
            // 
            this.startTraceButton.BackColor = System.Drawing.Color.LawnGreen;
            this.startTraceButton.Location = new System.Drawing.Point(29, 69);
            this.startTraceButton.Name = "startTraceButton";
            this.startTraceButton.Size = new System.Drawing.Size(75, 23);
            this.startTraceButton.TabIndex = 1;
            this.startTraceButton.Text = "Start";
            this.startTraceButton.UseVisualStyleBackColor = false;
            this.startTraceButton.Click += new System.EventHandler(this.startTraceButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Destination:";
            // 
            // traceInputTextBox
            // 
            this.traceInputTextBox.Location = new System.Drawing.Point(64, 9);
            this.traceInputTextBox.Name = "traceInputTextBox";
            this.traceInputTextBox.Size = new System.Drawing.Size(182, 20);
            this.traceInputTextBox.TabIndex = 3;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.ForeColor = System.Drawing.Color.White;
            this.checkBox1.Location = new System.Drawing.Point(6, 35);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(131, 17);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "Show with Hostnames";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // stopTraceRoute
            // 
            this.stopTraceRoute.BackColor = System.Drawing.Color.Crimson;
            this.stopTraceRoute.Location = new System.Drawing.Point(134, 69);
            this.stopTraceRoute.Name = "stopTraceRoute";
            this.stopTraceRoute.Size = new System.Drawing.Size(75, 23);
            this.stopTraceRoute.TabIndex = 5;
            this.stopTraceRoute.Text = "Stop";
            this.stopTraceRoute.UseVisualStyleBackColor = false;
            this.stopTraceRoute.Click += new System.EventHandler(this.stopTraceRoute_Click);
            // 
            // traceRouteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.stopTraceRoute);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.traceInputTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.startTraceButton);
            this.Controls.Add(this.resultTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "traceRouteForm";
            this.Text = "Network Detective (Trace Route)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.traceRouteForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox resultTextBox;
        private System.Windows.Forms.Button startTraceButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox traceInputTextBox;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button stopTraceRoute;
    }
}