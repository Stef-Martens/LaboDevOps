namespace PM1918_Project
{
      partial class Snake
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.EndGameLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.SnakeLengthLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.A1 = new System.Windows.Forms.Label();
            this.A2 = new System.Windows.Forms.Label();
            this.A3 = new System.Windows.Forms.Label();
            this.A4 = new System.Windows.Forms.Label();
            this.A5 = new System.Windows.Forms.Label();
            this.A10 = new System.Windows.Forms.Label();
            this.A9 = new System.Windows.Forms.Label();
            this.A8 = new System.Windows.Forms.Label();
            this.A7 = new System.Windows.Forms.Label();
            this.A6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // EndGameLabel
            // 
            this.EndGameLabel.BackColor = System.Drawing.Color.Black;
            this.EndGameLabel.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EndGameLabel.ForeColor = System.Drawing.Color.Red;
            this.EndGameLabel.Location = new System.Drawing.Point(225, 272);
            this.EndGameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EndGameLabel.Name = "EndGameLabel";
            this.EndGameLabel.Size = new System.Drawing.Size(331, 210);
            this.EndGameLabel.TabIndex = 2;
            this.EndGameLabel.Text = "You Lost!\r\n\r\nThe snake collided with itself\r\n\r\nClick to play again";
            this.EndGameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.EndGameLabel.Visible = false;
            this.EndGameLabel.Click += new System.EventHandler(this.EndGameLabel_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.ForeColor = System.Drawing.Color.Red;
            this.panel1.Location = new System.Drawing.Point(64, 121);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(647, 597);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(471, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 29);
            this.label1.TabIndex = 15;
            this.label1.Text = "Snake Length:";
            // 
            // SnakeLengthLabel
            // 
            this.SnakeLengthLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.SnakeLengthLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SnakeLengthLabel.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SnakeLengthLabel.ForeColor = System.Drawing.Color.Red;
            this.SnakeLengthLabel.Location = new System.Drawing.Point(632, 16);
            this.SnakeLengthLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SnakeLengthLabel.Name = "SnakeLengthLabel";
            this.SnakeLengthLabel.Size = new System.Drawing.Size(78, 43);
            this.SnakeLengthLabel.TabIndex = 14;
            this.SnakeLengthLabel.Text = "1";
            this.SnakeLengthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(65, 22);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 29);
            this.label2.TabIndex = 17;
            this.label2.Text = "Amount of food:";
            // 
            // A1
            // 
            this.A1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.A1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A1.ForeColor = System.Drawing.Color.Red;
            this.A1.Location = new System.Drawing.Point(65, 53);
            this.A1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.A1.Name = "A1";
            this.A1.Size = new System.Drawing.Size(35, 28);
            this.A1.TabIndex = 18;
            this.A1.Text = "1";
            this.A1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.A1.Click += new System.EventHandler(this.A1_Click);
            // 
            // A2
            // 
            this.A2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.A2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A2.ForeColor = System.Drawing.Color.Maroon;
            this.A2.Location = new System.Drawing.Point(101, 53);
            this.A2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.A2.Name = "A2";
            this.A2.Size = new System.Drawing.Size(35, 28);
            this.A2.TabIndex = 19;
            this.A2.Text = "2";
            this.A2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.A2.Click += new System.EventHandler(this.A2_Click);
            // 
            // A3
            // 
            this.A3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.A3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A3.ForeColor = System.Drawing.Color.Maroon;
            this.A3.Location = new System.Drawing.Point(137, 53);
            this.A3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.A3.Name = "A3";
            this.A3.Size = new System.Drawing.Size(35, 28);
            this.A3.TabIndex = 20;
            this.A3.Text = "3";
            this.A3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.A3.Click += new System.EventHandler(this.A3_Click);
            // 
            // A4
            // 
            this.A4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.A4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A4.ForeColor = System.Drawing.Color.Maroon;
            this.A4.Location = new System.Drawing.Point(173, 53);
            this.A4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.A4.Name = "A4";
            this.A4.Size = new System.Drawing.Size(35, 28);
            this.A4.TabIndex = 21;
            this.A4.Text = "4";
            this.A4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.A4.Click += new System.EventHandler(this.A4_Click);
            // 
            // A5
            // 
            this.A5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.A5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A5.ForeColor = System.Drawing.Color.Maroon;
            this.A5.Location = new System.Drawing.Point(209, 53);
            this.A5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.A5.Name = "A5";
            this.A5.Size = new System.Drawing.Size(35, 28);
            this.A5.TabIndex = 22;
            this.A5.Text = "5";
            this.A5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.A5.Click += new System.EventHandler(this.A5_Click);
            // 
            // A10
            // 
            this.A10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.A10.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A10.ForeColor = System.Drawing.Color.Maroon;
            this.A10.Location = new System.Drawing.Point(209, 82);
            this.A10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.A10.Name = "A10";
            this.A10.Size = new System.Drawing.Size(35, 28);
            this.A10.TabIndex = 27;
            this.A10.Text = "10";
            this.A10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.A10.Click += new System.EventHandler(this.A10_Click);
            // 
            // A9
            // 
            this.A9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.A9.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A9.ForeColor = System.Drawing.Color.Maroon;
            this.A9.Location = new System.Drawing.Point(173, 82);
            this.A9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.A9.Name = "A9";
            this.A9.Size = new System.Drawing.Size(35, 28);
            this.A9.TabIndex = 26;
            this.A9.Text = "9";
            this.A9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.A9.Click += new System.EventHandler(this.A9_Click);
            // 
            // A8
            // 
            this.A8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.A8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A8.ForeColor = System.Drawing.Color.Maroon;
            this.A8.Location = new System.Drawing.Point(137, 82);
            this.A8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.A8.Name = "A8";
            this.A8.Size = new System.Drawing.Size(35, 28);
            this.A8.TabIndex = 25;
            this.A8.Text = "8";
            this.A8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.A8.Click += new System.EventHandler(this.A8_Click);
            // 
            // A7
            // 
            this.A7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.A7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A7.ForeColor = System.Drawing.Color.Maroon;
            this.A7.Location = new System.Drawing.Point(101, 82);
            this.A7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.A7.Name = "A7";
            this.A7.Size = new System.Drawing.Size(35, 28);
            this.A7.TabIndex = 24;
            this.A7.Text = "7";
            this.A7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.A7.Click += new System.EventHandler(this.A7_Click);
            // 
            // A6
            // 
            this.A6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.A6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A6.ForeColor = System.Drawing.Color.Maroon;
            this.A6.Location = new System.Drawing.Point(65, 82);
            this.A6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.A6.Name = "A6";
            this.A6.Size = new System.Drawing.Size(35, 28);
            this.A6.TabIndex = 23;
            this.A6.Text = "6";
            this.A6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.A6.Click += new System.EventHandler(this.A6_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Red;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(509, 63);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(201, 48);
            this.label3.TabIndex = 30;
            this.label3.Text = "Restart";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(511, 64);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(199, 46);
            this.label4.TabIndex = 31;
            this.label4.Text = "Restart";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // quitGameButton
 
            // Snake
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(777, 768);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.A10);
            this.Controls.Add(this.A9);
            this.Controls.Add(this.A8);
            this.Controls.Add(this.A7);
            this.Controls.Add(this.A6);
            this.Controls.Add(this.A5);
            this.Controls.Add(this.A4);
            this.Controls.Add(this.A3);
            this.Controls.Add(this.A2);
            this.Controls.Add(this.A1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SnakeLengthLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.EndGameLabel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "Snake";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Snake";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label EndGameLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label SnakeLengthLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label A1;
        private System.Windows.Forms.Label A2;
        private System.Windows.Forms.Label A3;
        private System.Windows.Forms.Label A4;
        private System.Windows.Forms.Label A5;
        private System.Windows.Forms.Label A10;
        private System.Windows.Forms.Label A9;
        private System.Windows.Forms.Label A8;
        private System.Windows.Forms.Label A7;
        private System.Windows.Forms.Label A6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button quitGameButton;
    }
}
