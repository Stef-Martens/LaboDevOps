namespace PM1918_Project
{
    partial class Form1
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
            this.quitButton = new System.Windows.Forms.Button();
            this.totalScoreLabel = new System.Windows.Forms.Label();
            this.pong_button = new System.Windows.Forms.Button();
            this.bss_button = new System.Windows.Forms.Button();
            this.snake_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // quitButton
            // 
            this.quitButton.Location = new System.Drawing.Point(25, 495);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(103, 29);
            this.quitButton.TabIndex = 4;
            this.quitButton.Text = "Quit Game";
            this.quitButton.UseVisualStyleBackColor = true;
            this.quitButton.Click += new System.EventHandler(this.quitButton_Click);
            // 
            // totalScoreLabel
            // 
            this.totalScoreLabel.AutoSize = true;
            this.totalScoreLabel.Location = new System.Drawing.Point(441, 28);
            this.totalScoreLabel.Name = "totalScoreLabel";
            this.totalScoreLabel.Size = new System.Drawing.Size(97, 17);
            this.totalScoreLabel.TabIndex = 5;
            this.totalScoreLabel.Text = "Total Score: 0";
            // 
            // pong_button
            // 
            this.pong_button.BackColor = System.Drawing.Color.Blue;
            this.pong_button.BackgroundImage = global::PM1918_Project.Properties.Resources.unity_2d_pong;
            this.pong_button.Location = new System.Drawing.Point(616, 131);
            this.pong_button.Margin = new System.Windows.Forms.Padding(4);
            this.pong_button.Name = "pong_button";
            this.pong_button.Size = new System.Drawing.Size(175, 175);
            this.pong_button.TabIndex = 2;
            this.pong_button.Text = "Pong";
            this.pong_button.UseVisualStyleBackColor = false;
            this.pong_button.Click += new System.EventHandler(this.button3_Click);
            // 
            // bss_button
            // 
            this.bss_button.BackColor = System.Drawing.Color.DarkOrange;
            this.bss_button.BackgroundImage = global::PM1918_Project.Properties.Resources.cropped_LOGO_1;
            this.bss_button.Location = new System.Drawing.Point(397, 253);
            this.bss_button.Margin = new System.Windows.Forms.Padding(4);
            this.bss_button.Name = "bss_button";
            this.bss_button.Size = new System.Drawing.Size(175, 175);
            this.bss_button.TabIndex = 1;
            this.bss_button.Text = "Blad-Steen-Schaar";
            this.bss_button.UseVisualStyleBackColor = false;
            this.bss_button.Click += new System.EventHandler(this.button2_Click);
            // 
            // snake_button
            // 
            this.snake_button.BackgroundImage = global::PM1918_Project.Properties.Resources.Python_Snake_Game;
            this.snake_button.Location = new System.Drawing.Point(182, 131);
            this.snake_button.Margin = new System.Windows.Forms.Padding(4);
            this.snake_button.Name = "snake_button";
            this.snake_button.Size = new System.Drawing.Size(175, 175);
            this.snake_button.TabIndex = 0;
            this.snake_button.Text = "Snake";
            this.snake_button.UseVisualStyleBackColor = true;
            this.snake_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.totalScoreLabel);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.pong_button);
            this.Controls.Add(this.bss_button);
            this.Controls.Add(this.snake_button);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button snake_button;
        private System.Windows.Forms.Button bss_button;
        private System.Windows.Forms.Button pong_button;
        private System.Windows.Forms.Button quitButton;
        private System.Windows.Forms.Label totalScoreLabel;
    }
}

