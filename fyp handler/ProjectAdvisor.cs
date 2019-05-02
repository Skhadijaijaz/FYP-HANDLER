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
    public partial class ProjectAdvisor : Form
    {
        string con = "Data Source=DESKTOP-OFNFN9P\\SKI2017;Initial Catalog=ProjectA;Persist Security Info=True;User ID=sa;Password=Sql2018";
        public ProjectAdvisor()
        {
            InitializeComponent();
            add.Hide();
            Show();
        }

        private void ProjectAdvisor_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(con);
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from [Advisor]", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                comboBox1.Items.Add(dt.Rows[i]["Id"]);
            }
            conn.Close();
            conn.Open();
            SqlDataAdapter a2 = new SqlDataAdapter("select * from Project", conn);
            DataTable dt1 = new DataTable();
            a2.Fill(dt1);
            for (int j = 0; j < dt1.Rows.Count; j++)
            {
                comboBox2.Items.Add(dt1.Rows[j]["Id"]);
            }
            conn.Close();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(con);
            conn.Open();
            string status = comboBox3.SelectedItem.ToString();

            string gdv = "select Id FROM Lookup WHERE Category = 'ADVISOR_ROLE' AND value ='" + status + "'";
            SqlCommand gdInt = new SqlCommand(gdv, conn);
            int s = 0;
            SqlDataReader reader = gdInt.ExecuteReader();

            while (reader.Read())
            {
                s = int.Parse(reader[0].ToString());
            }
            conn.Close();
            conn.Open();
            string gender = comboBox1.SelectedItem.ToString();
            string g = comboBox2.SelectedItem.ToString();
            DateTime dt = DateTime.Now;
            string q = "INSERT into ProjectAdvisor(AdvisorId, ProjectId ,AdvisorRole, AssignmentDate ) values ('" + gender + "' , '" + g + "' , '" + s + "','" + dt + "')";
            SqlCommand sc = new SqlCommand(q, conn);
            int a = sc.ExecuteNonQuery();
            conn.Close();
            comboBox1.Text = "";
            comboBox2.Text = "";
            if (MessageBox.Show("Are you sure you want to add this Evaluation", "Insert", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                MessageBox.Show("Record has been inserted successfully");
            }
            else
            {
                MessageBox.Show("Record  not inserted!");

            }
            
        }

        private void AddNew_Click(object sender, EventArgs e)
        {
            add.Show();
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
            cmd.CommandText = "SELECT [Advisor].Id as [Advisor Id],Project.Id as [Project Id], ProjectAdvisor.AdvisorRole, ProjectAdvisor.AssignmentDate FROM ([Advisor] JOIN ProjectAdvisor ON [Advisor].Id = ProjectAdvisor.AdvisorId) JOIN Project ON ProjectAdvisor.ProjectId = Project.Id";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }


        private void Display_Click(object sender, EventArgs e)
        {
            show();
        }
        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            add.Show();
            try
            {
                //int marks = int.Parse(textBox1.Text.ToString());
                comboBox1.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                comboBox2.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                comboBox3.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();

            }
            catch (Exception ex)
            {
                return;
            }
        }

        private void Update_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(con);

            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            string a = (dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            int x = 0;
            Int32.TryParse(a, out x);
            string adr = "select Id FROM Lookup WHERE Category = 'ADVISOR_ROLE' AND value ='" + comboBox3.Text.ToString() + "'";
            SqlCommand gdInt = new SqlCommand(adr, conn);
            int k = 0;
            SqlDataReader reader = gdInt.ExecuteReader();

            while (reader.Read())
            {
                k = int.Parse(reader[0].ToString());
            }
            reader.Close();

            string gender = comboBox1.SelectedItem.ToString();
            string g = comboBox2.SelectedItem.ToString();
            DateTime dt = DateTime.Now;

            string q1 = "Update ProjectAdvisor set  AssignmentDate ='" + dt + "', AdvisorRole ='" + k + "'  WHERE (AdvisorId = '" + gender + "'and ProjectId ='" + g + "')where Id ='" + x + "'";
            SqlCommand sc1 = new SqlCommand(q1, conn);
            int a1 = sc1.ExecuteNonQuery();
            show();
            conn.Close();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(con);
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            string a = (dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            int x = 0;
            Int32.TryParse(a, out x);

            string aid = comboBox1.SelectedItem.ToString();
            string pid = comboBox2.SelectedItem.ToString();


            string del = String.Format("DELETE FROM ProjectAdvisor WHERE  (AdvisorId = '" + aid + "'and ProjectId = '" + pid + "')where Id ='" + x + "'");
            SqlCommand cmd = new SqlCommand(del, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            show();
            if (MessageBox.Show("Are you sure you want to delete this record", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                MessageBox.Show("Record deleted successfully");
            }
            else
            {
                MessageBox.Show("Information not deleted!");
            }
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
