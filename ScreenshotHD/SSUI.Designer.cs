namespace ScreenshotHD
{
    partial class SSUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SSUI));
            this.buttonexit = new System.Windows.Forms.Button();
            this.CAPTURE = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonexit
            // 
            this.buttonexit.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonexit.Font = new System.Drawing.Font("Arial", 15F);
            this.buttonexit.ForeColor = System.Drawing.Color.Red;
            this.buttonexit.Location = new System.Drawing.Point(277, 12);
            this.buttonexit.Name = "buttonexit";
            this.buttonexit.Size = new System.Drawing.Size(62, 31);
            this.buttonexit.TabIndex = 0;
            this.buttonexit.Text = "EXIT";
            this.buttonexit.UseVisualStyleBackColor = false;
            this.buttonexit.Click += new System.EventHandler(this.buttonexit_Click);
            // 
            // CAPTURE
            // 
            this.CAPTURE.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.CAPTURE.Font = new System.Drawing.Font("Arial", 15F);
            this.CAPTURE.ForeColor = System.Drawing.Color.Red;
            this.CAPTURE.Location = new System.Drawing.Point(12, 12);
            this.CAPTURE.Name = "CAPTURE";
            this.CAPTURE.Size = new System.Drawing.Size(118, 31);
            this.CAPTURE.TabIndex = 1;
            this.CAPTURE.Text = "CAPTURE";
            this.CAPTURE.UseVisualStyleBackColor = false;
            this.CAPTURE.Click += new System.EventHandler(this.CAPTURE_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(330, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "PRESS CTRL+12 TO TAKE AN UNCOMPRESSED SCREENSHOT";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // SSUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(351, 68);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CAPTURE);
            this.Controls.Add(this.buttonexit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SSUI";
            this.Opacity = 0.7D;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Screenshot";
            this.Load += new System.EventHandler(this.SSUI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonexit;
        private System.Windows.Forms.Button CAPTURE;
        private System.Windows.Forms.Label label1;
    }
}