using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Runtime.InteropServices;

namespace PM1918_Project
{
    public partial class Form1 : Form
    {
       
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();
        public Form1()
        {
            InitializeComponent();
            player.SoundLocation = "menuMusic.wav";
            player.Play();
        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            Snake frmsecond = new Snake();
            
            frmsecond.Show();
            //PlaySnake();

            


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Bladsteenschaar frmsecond = new Bladsteenschaar();
            frmsecond.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Pong frmsecond = new Pong();
            frmsecond.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Mainmenu frmsecond = new Mainmenu();
            frmsecond.Show();
        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            if (System.Windows.Forms.Application.MessageLoop)
            {        
                System.Windows.Forms.Application.Exit();
            }
            else
            {
                System.Environment.Exit(1);
            }
        }
    }
}
