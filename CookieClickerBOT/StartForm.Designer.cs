namespace CookieClickerBOT
{
    partial class StartForm
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
            this.BtnStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.NumTime = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.NumTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnStart
            // 
            this.BtnStart.Location = new System.Drawing.Point(4, 46);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(178, 23);
            this.BtnStart.TabIndex = 0;
            this.BtnStart.Text = "Start BOT";
            this.BtnStart.UseVisualStyleBackColor = true;
            this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bekleme Süresi :";
            // 
            // NumTime
            // 
            this.NumTime.Location = new System.Drawing.Point(95, 8);
            this.NumTime.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.NumTime.Name = "NumTime";
            this.NumTime.Size = new System.Drawing.Size(87, 23);
            this.NumTime.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(159, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "ms";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CookieClickerBOT.Properties.Resources.cookie;
            this.pictureBox1.Location = new System.Drawing.Point(188, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(63, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 74);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NumTime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "StartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CookieClicker BOT";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StartForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.NumTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown NumTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}