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
    public partial class Bladsteenschaar : Form
    {
        int Computer;
        int gewonnen = 0;
        int verloren = 0;
        int gelijkstand = 0;
        int puntjes = 0;
        Random r;
        public Bladsteenschaar()
        {
            InitializeComponent();
        }

        private void Bladsteenschaar_Load(object sender, EventArgs e)
        {
            r = new Random();
            Computer = r.Next(0, 2);
            gelijk.Text = gelijkstand.ToString();
            gew.Text = gewonnen.ToString();
            ver.Text = verloren.ToString();
            score.Text = puntjes.ToString();

            //0=schaar
            //1=steen
            //2=papier
        }

        private void Steen_Click(object sender, EventArgs e)
        {
            if (Computer == 1)
            {
                pictureBox1.Image = Image.FromFile("C:/Users/Stef Martens/Pictures/steen.png");
                gelijkstand++;
            }
            else if (Computer == 0)
            {
                pictureBox1.Image = Image.FromFile("C:/Users/Stef Martens/Pictures/schaar.jpg");
                gewonnen++;
            }
            else
            {
                pictureBox1.Image = Image.FromFile("C:/Users/Stef Martens/Pictures/papier.jpg");
                verloren++;
            }
            if (gewonnen == 3) { MessageBox.Show("Je hebt 3x gewonnen! :)"); gewonnen = 0; verloren = 0; gelijkstand = 0; puntjes++; score.Text = puntjes.ToString(); }
            else if (verloren == 3) { MessageBox.Show("Je hebt 3x verloren! :("); gewonnen = 0; verloren = 0; gelijkstand = 0; }
            gelijk.Text = gelijkstand.ToString();
            gew.Text = gewonnen.ToString();
            ver.Text = verloren.ToString();
            Computer = r.Next(0, 3);
        }

        private void Schaar_Click(object sender, EventArgs e)
        {
            if (Computer == 0)
            {
                pictureBox1.Image = Image.FromFile("C:/Users/Stef Martens/Pictures/schaar.jpg");
                gelijkstand++;
            }
            else if (Computer == 2)
            {
                pictureBox1.Image = Image.FromFile("C:/Users/Stef Martens/Pictures/papier.jpg");
                gewonnen++;
            }
            else
            {
                pictureBox1.Image = Image.FromFile("C:/Users/Stef Martens/Pictures/steen.png");
                verloren++;
            }
            if (gewonnen == 3) { MessageBox.Show("Je hebt 3x gewonnen! :)"); gewonnen = 0; verloren = 0; gelijkstand = 0; puntjes++; score.Text = puntjes.ToString(); }
            else if (verloren == 3) { MessageBox.Show("Je hebt 3x verloren! :("); gewonnen = 0; verloren = 0; gelijkstand = 0; }
            gelijk.Text = gelijkstand.ToString();
            gew.Text = gewonnen.ToString();
            ver.Text = verloren.ToString();
            Computer = r.Next(0, 3);
        }

        private void Papier_Click(object sender, EventArgs e)
        {
            if (Computer == 2)
            {
                pictureBox1.Image = Image.FromFile("C:/Users/Stef Martens/Pictures/papier.jpg");
                gelijkstand++;
            }
            else if (Computer == 1)
            {
                pictureBox1.Image = Image.FromFile("C:/Users/Stef Martens/Pictures/steen.png");
                gewonnen++;
            }
            else
            {
                pictureBox1.Image = Image.FromFile("C:/Users/Stef Martens/Pictures/schaar.jpg");
                verloren++;
            }
            if (gewonnen == 3) { MessageBox.Show("Je hebt 3x gewonnen! :)"); gewonnen = 0; verloren = 0; gelijkstand = 0; puntjes++; score.Text = puntjes.ToString(); }
            else if (verloren == 3) { MessageBox.Show("Je hebt 3x verloren! :("); gewonnen = 0; verloren = 0; gelijkstand = 0; }
            gelijk.Text = gelijkstand.ToString();
            gew.Text = gewonnen.ToString();
            ver.Text = verloren.ToString();
            Computer = r.Next(0, 3);
        }

        private void Exit_Click(object sender, EventArgs e)
        {

            this.Close();

        }
    }
    
    
}
