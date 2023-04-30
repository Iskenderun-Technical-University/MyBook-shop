namespace MyBook_shop.PL
{
    partial class MyBook
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
            this.P_MB = new System.Windows.Forms.Panel();
            this.P_TB = new System.Windows.Forms.Panel();
            this.P_HOME = new System.Windows.Forms.Panel();
            this.P_MAIN = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // P_MB
            // 
            this.P_MB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.P_MB.Dock = System.Windows.Forms.DockStyle.Right;
            this.P_MB.Location = new System.Drawing.Point(721, 0);
            this.P_MB.Name = "P_MB";
            this.P_MB.Size = new System.Drawing.Size(203, 553);
            this.P_MB.TabIndex = 0;
            // 
            // P_TB
            // 
            this.P_TB.Dock = System.Windows.Forms.DockStyle.Top;
            this.P_TB.Location = new System.Drawing.Point(0, 0);
            this.P_TB.Name = "P_TB";
            this.P_TB.Size = new System.Drawing.Size(721, 50);
            this.P_TB.TabIndex = 1;
            // 
            // P_HOME
            // 
            this.P_HOME.Dock = System.Windows.Forms.DockStyle.Fill;
            this.P_HOME.Location = new System.Drawing.Point(0, 50);
            this.P_HOME.Name = "P_HOME";
            this.P_HOME.Size = new System.Drawing.Size(721, 503);
            this.P_HOME.TabIndex = 2;
            // 
            // P_MAIN
            // 
            this.P_MAIN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.P_MAIN.Location = new System.Drawing.Point(0, 50);
            this.P_MAIN.Name = "P_MAIN";
            this.P_MAIN.Size = new System.Drawing.Size(721, 503);
            this.P_MAIN.TabIndex = 0;
            // 
            // MyBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 40F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 553);
            this.Controls.Add(this.P_HOME);
            this.Controls.Add(this.P_MAIN);
            this.Controls.Add(this.P_TB);
            this.Controls.Add(this.P_MB);
            this.Font = new System.Drawing.Font("JF Flat", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "MyBook";
            this.ResumeLayout(false);

        }

        #endregion

        private Panel P_MB;
        private Panel P_TB;
        private Panel P_HOME;
        private Panel P_MAIN;
    }
}