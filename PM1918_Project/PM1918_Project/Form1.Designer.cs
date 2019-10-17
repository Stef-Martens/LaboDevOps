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
            this.snake_button = new System.Windows.Forms.Button();
            this.bss_button = new System.Windows.Forms.Button();
            this.pong_button = new System.Windows.Forms.Button();
            this.back_to_main = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // snake_button
            // 
            this.snake_button.Location = new System.Drawing.Point(300, 190);
            this.snake_button.Name = "snake_button";
            this.snake_button.Size = new System.Drawing.Size(130, 23);
            this.snake_button.TabIndex = 0;
            this.snake_button.Text = "Snake";
            this.snake_button.UseVisualStyleBackColor = true;
            this.snake_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // bss_button
            // 
            this.bss_button.Location = new System.Drawing.Point(300, 234);
            this.bss_button.Name = "bss_button";
            this.bss_button.Size = new System.Drawing.Size(130, 23);
            this.bss_button.TabIndex = 1;
            this.bss_button.Text = "Blad-Steen-Schaar";
            this.bss_button.UseVisualStyleBackColor = true;
            this.bss_button.Click += new System.EventHandler(this.button2_Click);
            // 
            // pong_button
            // 
            this.pong_button.Location = new System.Drawing.Point(300, 278);
            this.pong_button.Name = "pong_button";
            this.pong_button.Size = new System.Drawing.Size(130, 23);
            this.pong_button.TabIndex = 2;
            this.pong_button.Text = "Pong";
            this.pong_button.UseVisualStyleBackColor = true;
            this.pong_button.Click += new System.EventHandler(this.button3_Click);
            // 
            // back_to_main
            // 
            this.back_to_main.Location = new System.Drawing.Point(300, 378);
            this.back_to_main.Name = "back_to_main";
            this.back_to_main.Size = new System.Drawing.Size(130, 23);
            this.back_to_main.TabIndex = 3;
            this.back_to_main.Text = "return to main menu";
            this.back_to_main.UseVisualStyleBackColor = true;
            this.back_to_main.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.back_to_main);
            this.Controls.Add(this.pong_button);
            this.Controls.Add(this.bss_button);
            this.Controls.Add(this.snake_button);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button snake_button;
        private System.Windows.Forms.Button bss_button;
        private System.Windows.Forms.Button pong_button;
        private System.Windows.Forms.Button back_to_main;
    }
}

