namespace WindowsFormsApplication1
{
    partial class BorrowSuccess
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
            this.TitleText = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TitleText
            // 
            this.TitleText.BackColor = System.Drawing.Color.GreenYellow;
            this.TitleText.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.TitleText.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitleText.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.TitleText.Font = new System.Drawing.Font("Microsoft Tai Le", 14F);
            this.TitleText.ForeColor = System.Drawing.SystemColors.MenuText;
            this.TitleText.Location = new System.Drawing.Point(0, 0);
            this.TitleText.Name = "TitleText";
            this.TitleText.Size = new System.Drawing.Size(932, 57);
            this.TitleText.TabIndex = 3;
            this.TitleText.Text = "Saman\'s Bookstore";
            this.TitleText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TitleText.UseWaitCursor = true;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DarkGreen;
            this.label1.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(0, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(932, 41);
            this.label1.TabIndex = 4;
            this.label1.Text = "Done!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.UseWaitCursor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Compset", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(261, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(411, 34);
            this.label2.TabIndex = 5;
            this.label2.Text = "You\'re time is set to 30 days!";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Compset", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(72, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(789, 33);
            this.label3.TabIndex = 6;
            this.label3.Text = "You can give the book back to the bookstore within this time.";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button1.Location = new System.Drawing.Point(410, 317);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 64);
            this.button1.TabIndex = 7;
            this.button1.Text = "Got it";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BorrowSuccess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 452);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TitleText);
            this.Name = "BorrowSuccess";
            this.Text = "BorrowSuccess";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}