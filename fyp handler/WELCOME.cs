using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fyp_handler
{
    public partial class WELCOME : Form
    {
        private int ticks;
        public WELCOME()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void about_us1_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ticks++;
            //this.Text = ticks.ToString();
            this.progressBar1.Increment(1);
            if(progressBar1.Value == 100)
            {
                WELCOME1 h1 = new WELCOME1();
                this.Hide();
                timer1.Stop(); 
                h1.Show();
            }
        }

        private void WELCOME_Load(object sender, EventArgs e)
        {
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
            progressBar1.Value = 0;
        }
    }
}
