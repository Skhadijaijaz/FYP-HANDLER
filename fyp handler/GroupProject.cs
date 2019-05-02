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
    public partial class GroupProject : Form
    {
        string con = "Data Source=DESKTOP-OFNFN9P\\SKI2017;Initial Catalog=ProjectA;Persist Security Info=True;User ID=sa;Password=Sql2018";
        public GroupProject()
        {
            InitializeComponent();
            add.Hide();
            Show();
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
            cmd.CommandText = "SELECT [Group].Id as [Group Id],Project.Id as [Project Id], GroupProject.AssignmentDate FROM ([Group] JOIN GroupProject ON [Group].Id = GroupProject.GroupId) JOIN Project ON GroupProject.ProjectId = Project.Id";

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
        private void Save_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(con);
            conn.Open();
            string gender = comboBox1.SelectedItem.ToString();
            string g = comboBox2.SelectedItem.ToString();
            DateTime dt = DateTime.Now;

            string q = "INSERT into GroupProject(GroupId, ProjectId , AssignmentDate ) values ('" + gender + "' , '" + g + "' , '" + dt + "')";

            SqlCommand sc = new SqlCommand(q, conn);
            int a = sc.ExecuteNonQuery();
            conn.Close();

            comboBox1.Text = "";
            if (MessageBox.Show("Are you sure you want to add this Evaluation", "Insert", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                MessageBox.Show("Record inserted successfully");
            }
            else
            {
                MessageBox.Show("Record not inserted!");
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
            string gid = comboBox1.SelectedItem.ToString();
            string pid = comboBox2.SelectedItem.ToString();
            DateTime dt = DateTime.Now;
            string q1 = "Update GroupProject set  AssignmentDate ='" + dt + "'  WHERE (GroupId = '" + gid + "'and ProjectId ='" + pid + "')where Id ='" + x + "'";
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
            string gid = comboBox1.SelectedItem.ToString();
            string pid = comboBox2.SelectedItem.ToString();
            string del = String.Format("DELETE FROM GroupProject WHERE  (GroupId = '" + gid + "'and ProjectId = '" + pid + "')where Id ='" + x + "'");
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
        private void GroupProject_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(con);
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from [Group]", conn);

            DataTable dt = new DataTable();
            da.Fill(dt);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                comboBox1.Items.Add(dt.Rows[i]["Id"]);
            }
            conn.Close();
            conn.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select * from Project", conn);
            DataTable dt1 = new DataTable();
            sda.Fill(dt1);
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
                //textBox1.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();

            }
            catch (Exception ex)
            {
                return;
            }
        }

        private void Home_Click(object sender, EventArgs e)
        {
            WELCOME1 h = new WELCOME1();
            this.Hide();
            h.Show();
        }

        private void AddNew_Click(object sender, EventArgs e)
        {
            add.Show();
        }
    }
}
