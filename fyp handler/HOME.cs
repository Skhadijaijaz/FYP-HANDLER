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
    public partial class WELCOME1 : Form
    {
        public WELCOME1()
        {
            InitializeComponent();
        }

        private void Evaluation_Click(object sender, EventArgs e)
        {
            Evaluation ev = new Evaluation();
            //this.Hide();
            ev.Show();
        }

        private void Students_Click(object sender, EventArgs e)
        {
            Student s = new Student();
            //this.Hide();
            s.Show();

        }

        private void Advisors_Click(object sender, EventArgs e)
        {
            Advisor ad = new Advisor();
            //this.Hide();
            ad.Show();
            
        }

        private void Projects_Click(object sender, EventArgs e)
        {
            Project p = new Project();
           // this.Hide();
            p.Show();
        }

        private void Home_Click(object sender, EventArgs e)
        {
            WELCOME h = new WELCOME();
            
            h.Show();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            GroupStudent gr = new GroupStudent();
            //this.Hide();
            gr.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GroupProject p = new GroupProject();
            //this.Hide();
            p.show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GroupEvaluation ge = new GroupEvaluation();
            //this.Hide();
            ge.show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ProjectAdvisor pa = new ProjectAdvisor();
            //this.Hide();
            pa.show();
        }
    }
}
