namespace WindowsFormsApplication1
{
    partial class Form2
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonSesrch = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TitleText
            // 
            this.TitleText.BackColor = System.Drawing.Color.GreenYellow;
            this.TitleText.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.TitleText.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitleText.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.TitleText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.TitleText.ForeColor = System.Drawing.SystemColors.MenuText;
            this.TitleText.Location = new System.Drawing.Point(0, 0);
            this.TitleText.Name = "TitleText";
            this.TitleText.Size = new System.Drawing.Size(896, 57);
            this.TitleText.TabIndex = 1;
            this.TitleText.Text = "Saman\'s Bookstore";
            this.TitleText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TitleText.UseWaitCursor = true;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("MRT_Elit", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-58, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1012, 60);
            this.label1.TabIndex = 4;
            this.label1.Text = "Looking for a book?";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(278, 211);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(340, 30);
            this.textBox1.TabIndex = 5;
            // 
            // buttonSesrch
            // 
            this.buttonSesrch.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonSesrch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonSesrch.Cursor = System.Windows.Forms.Cursors.Help;
            this.buttonSesrch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSesrch.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonSesrch.Location = new System.Drawing.Point(330, 258);
            this.buttonSesrch.Name = "buttonSesrch";
            this.buttonSesrch.Size = new System.Drawing.Size(230, 55);
            this.buttonSesrch.TabIndex = 6;
            this.buttonSesrch.Text = "Search in Bookstore";
            this.buttonSesrch.UseVisualStyleBackColor = false;
            this.buttonSesrch.Click += new System.EventHandler(this.buttonSesrch_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(359, 316);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "No book Found dear user!";
            this.label2.Visible = false;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(278, 453);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(340, 30);
            this.textBox2.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("MRT_Elit", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(-58, 366);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1012, 60);
            this.label3.TabIndex = 8;
            this.label3.Text = "Looking for an author\'s Books?";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(359, 564);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "No book Found dear user!";
            this.label4.Visible = false;
            // 
            // button1
            // 
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Help;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(330, 506);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(230, 55);
            this.button1.TabIndex = 10;
            this.button1.Text = "Search in Bookstore";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(222)))), ((int)(((byte)(69)))));
            this.ClientSize = new System.Drawing.Size(896, 623);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonSesrch);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TitleText);
            this.Name = "Form2";
            this.Text = "Saman\'s Bookstore-main page";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonSesrch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}