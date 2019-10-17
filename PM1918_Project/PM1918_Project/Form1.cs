using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PM1918_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Snake frmsecond = new Snake();
            frmsecond.Show();

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
    }
}
