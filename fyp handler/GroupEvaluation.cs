using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace fyp_handler
{
    public partial class GroupEvaluation : Form
    {
        string con = "Data Source=DESKTOP-OFNFN9P\\SKI2017;Initial Catalog=ProjectA;Persist Security Info=True;User ID=sa;Password=Sql2018";
        public GroupEvaluation()
        {
            InitializeComponent();
            add.Hide();
           
            Show();
        }
        private void Savebutton_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(con);
            conn.Open();
            string gid = comboBox1.SelectedItem.ToString();
            string eid = comboBox2.SelectedItem.ToString();
            DateTime dt = DateTime.Now;
            string ps = "insert into GroupEvaluation(GroupId, EvaluationId ,ObtainedMarks, EvaluationDate ) values ('" + gid + "' , '" + eid + "' , '" + textBox1.Text + "','" + dt + "')";
            SqlCommand cmd = new SqlCommand(ps, conn);
            int a = cmd.ExecuteNonQuery();
            conn.Close();
            textBox1.Text = "";
            comboBox1.Text = "";
            comboBox2.Text = "";
            if (MessageBox.Show("Are you sure you want to add Evaluation", "insert", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                MessageBox.Show("Evaluation inserted successfully");
            }
            else
            {
                MessageBox.Show("Evaluation is not inserted!");
            }
        }
        public void show()
        {
            SqlConnection conn = new SqlConnection(con);
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT [Group].Id as [Group Id],Evaluation.Id as [Evaluation Id], GroupEvaluation.ObtainedMarks, GroupEvaluation.EvaluationDate FROM ([Group] JOIN GroupEvaluation ON [Group].Id = GroupEvaluation.GroupId) JOIN Evaluation ON GroupEvaluation.EvaluationId = Evaluation.Id";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void GroupEvaluation_Load(object sender, EventArgs e)
        {
            
            SqlConnection conn = new SqlConnection(con);
            conn.Open();
            SqlDataAdapter ad = new SqlDataAdapter("select * from [Group]", conn);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                comboBox1.Items.Add(dt.Rows[i]["Id"]);
            }
            SqlDataAdapter ad1 = new SqlDataAdapter("select * from Evaluation", conn);
            DataTable dt1 = new DataTable();
            ad1.Fill(dt1);
            for (int j = 0; j < dt1.Rows.Count; j++)
            {
                comboBox2.Items.Add(dt1.Rows[j]["Id"]);
            }
            conn.Close();
        }
        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            add.Show();
            try
            {
                //int marks = int.Parse(textBox1.Text.ToString());
                comboBox1.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                comboBox2.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                textBox1.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();

            }
            catch (Exception ex)
            {
                return;
            }
        }

        private void Update_Click(object sender, EventArgs e)
        {
            add.Hide();
            //update1.Show();
            SqlConnection conn = new SqlConnection(con);
            try
            {

                if (conn.State == ConnectionState.Closed)
                { conn.Open(); }
                string a = (dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                int x = 0;
                Int32.TryParse(a, out x);
                string gid = comboBox1.SelectedItem.ToString();
                string eid = comboBox2.SelectedItem.ToString();
                int marks = int.Parse(textBox1.Text.ToString());
                DateTime dt = DateTime.Now;
                string uq = "Update GroupEvaluation set ObtainedMarks ='" + textBox1.Text + "'  WHERE (GroupId = '" + gid + "'and EvaluationId ='" + eid + "') where Id ='" + x + "'";
                SqlCommand cmd = new SqlCommand(uq, conn);
                int r = cmd.ExecuteNonQuery();
                show();
                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(" ERROR IS :" + ex.ToString());
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            add.Show();
            SqlConnection conn = new SqlConnection(con);
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            string a = (dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            int x = 0;
            Int32.TryParse(a, out x);
            string gid = comboBox1.SelectedItem.ToString();
            string eid = comboBox2.SelectedItem.ToString();
            string del = String.Format("delete from GroupEvaluation WHERE(GroupId = '" + gid + "'and EvaluationId = '" + eid + "')where Id ='" + x + "'");
            SqlCommand cmd = new SqlCommand(del, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            show();
            if (MessageBox.Show("Are you sure you want to delete this Information", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                MessageBox.Show("Information deleted successfully");
            }
            else
            {
                MessageBox.Show("Information not deleted!");
            }
        }

        private void AddNew_Click(object sender, EventArgs e)
        {
            add.Show();
        }

        private void Display_Click(object sender, EventArgs e)
        {
            show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void update1_Load(object sender, EventArgs e)
        {

        }

        private void Home_Click(object sender, EventArgs e)
        {
            WELCOME1 h = new WELCOME1();
            this.Hide();
            h.Show();
        }

        private void add_Paint(object sender, PaintEventArgs e)
        {

        }
    }
    
}
