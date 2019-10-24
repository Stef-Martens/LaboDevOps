namespace PM1918_Project
{
    partial class Bladsteenschaar
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
            this.score = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gelijk = new System.Windows.Forms.Label();
            this.ver = new System.Windows.Forms.Label();
            this.gew = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Button();
            this.Papier = new System.Windows.Forms.Button();
            this.Schaar = new System.Windows.Forms.Button();
            this.Steen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // score
            // 
            this.score.AutoSize = true;
            this.score.Location = new System.Drawing.Point(915, 146);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(43, 17);
            this.score.TabIndex = 29;
            this.score.Text = "score";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(840, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 17);
            this.label6.TabIndex = 28;
            this.label6.Text = "Score";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(532, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 17);
            this.label5.TabIndex = 27;
            this.label5.Text = "Keuze computer:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PM1918_Project.Properties.Resources.steen;
            this.pictureBox1.Location = new System.Drawing.Point(532, 198);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(184, 174);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // gelijk
            // 
            this.gelijk.AutoSize = true;
            this.gelijk.Location = new System.Drawing.Point(449, 271);
            this.gelijk.Name = "gelijk";
            this.gelijk.Size = new System.Drawing.Size(0, 17);
            this.gelijk.TabIndex = 25;
            // 
            // ver
            // 
            this.ver.AutoSize = true;
            this.ver.Location = new System.Drawing.Point(449, 232);
            this.ver.Name = "ver";
            this.ver.Size = new System.Drawing.Size(0, 17);
            this.ver.TabIndex = 24;
            // 
            // gew
            // 
            this.gew.AutoSize = true;
            this.gew.Location = new System.Drawing.Point(446, 199);
            this.gew.Name = "gew";
            this.gew.Size = new System.Drawing.Size(0, 17);
            this.gew.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(341, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 17);
            this.label4.TabIndex = 22;
            this.label4.Text = "Gelijkstand";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(341, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 17);
            this.label3.TabIndex = 21;
            this.label3.Text = "Verloren";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(341, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 20;
            this.label2.Text = "Gewonnen";
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(116, 337);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 23);
            this.Exit.TabIndex = 19;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Papier
            // 
            this.Papier.Location = new System.Drawing.Point(116, 261);
            this.Papier.Name = "Papier";
            this.Papier.Size = new System.Drawing.Size(75, 23);
            this.Papier.TabIndex = 18;
            this.Papier.Text = "Papier";
            this.Papier.UseVisualStyleBackColor = true;
            this.Papier.Click += new System.EventHandler(this.Papier_Click);
            // 
            // Schaar
            // 
            this.Schaar.Location = new System.Drawing.Point(116, 232);
            this.Schaar.Name = "Schaar";
            this.Schaar.Size = new System.Drawing.Size(75, 23);
            this.Schaar.TabIndex = 17;
            this.Schaar.Text = "Schaar";
            this.Schaar.UseVisualStyleBackColor = true;
            this.Schaar.Click += new System.EventHandler(this.Schaar_Click);
            // 
            // Steen
            // 
            this.Steen.Location = new System.Drawing.Point(116, 203);
            this.Steen.Name = "Steen";
            this.Steen.Size = new System.Drawing.Size(75, 23);
            this.Steen.TabIndex = 16;
            this.Steen.Text = "Steen";
            this.Steen.UseVisualStyleBackColor = true;
            this.Steen.Click += new System.EventHandler(this.Steen_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(113, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 29);
            this.label1.TabIndex = 15;
            this.label1.Text = "Schaar steen papier!";
            // 
            // Bladsteenschaar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 619);
            this.Controls.Add(this.score);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gelijk);
            this.Controls.Add(this.ver);
            this.Controls.Add(this.gew);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Papier);
            this.Controls.Add(this.Schaar);
            this.Controls.Add(this.Steen);
            this.Controls.Add(this.label1);
            this.Name = "Bladsteenschaar";
            this.Text = "Bladsteenschaar";
            this.Load += new System.EventHandler(this.Bladsteenschaar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label score;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label gelijk;
        private System.Windows.Forms.Label ver;
        private System.Windows.Forms.Label gew;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button Papier;
        private System.Windows.Forms.Button Schaar;
        private System.Windows.Forms.Button Steen;
        private System.Windows.Forms.Label label1;
    }
}