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
    public partial class GroupStudent : Form
    {
        string con = "Data Source=DESKTOP-OFNFN9P\\SKI2017;Initial Catalog=ProjectA;Persist Security Info=True;User ID=sa;Password=Sql2018";
        public GroupStudent()
        {
            InitializeComponent();
            add.Hide();
            Show();
        }
        private void show()
        {
            SqlConnection conn = new SqlConnection(con);
            if (conn.State == ConnectionState.Closed)
            { conn.Open(); }
            String c = "select [Group].Id as [Group Id],Student.Id as [Student Id],[Group].Created_On, GroupStudent.Status, GroupStudent.AssignmentDate FROM ([Group] JOIN Groupstudent ON [Group].Id = GroupStudent.GroupId) JOIN Student ON GroupStudent.StudentId = Student.Id";
            SqlCommand cmd = new SqlCommand(c, conn);
            try
            {
                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = cmd;
                DataTable dat = new DataTable();
                sda.Fill(dat);
                BindingSource bsource = new BindingSource();
                bsource.DataSource = dat;
                dataGridView1.DataSource = bsource;
                sda.Update(dat);
                this.dataGridView1.Columns["ID"].Visible = false;
                conn.Close();
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Display_Click(object sender, EventArgs e)
        {
            //add.Hide();
            show();
        }

        private void GroupStudent_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(con);
            conn.Open();
            SqlDataAdapter a1 = new SqlDataAdapter("select * from [Group]", conn);
            DataTable dt = new DataTable();
            a1.Fill(dt);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                comboBox1.Items.Add(dt.Rows[i]["Id"]);
            }
            SqlDataAdapter ad = new SqlDataAdapter("select * from Student", conn);
            DataTable dt1 = new DataTable();
            ad.Fill(dt1);
            for (int j = 0; j < dt1.Rows.Count; j++)
            {
                comboBox2.Items.Add(dt1.Rows[j]["Id"]);
            }
            conn.Close();
        }

        private void Savebutton_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(con);
            conn.Open();
            string status = comboBox3.SelectedItem.ToString();
            string q1 = "select Id FROM Lookup WHERE Category = 'Status' AND value ='" + status + "'";
            SqlCommand sc = new SqlCommand(q1, conn);
            int i = 0;
            SqlDataReader reader = sc.ExecuteReader();
            
            while (reader.Read())
            {
                i = int.Parse(reader[0].ToString());
            }
            conn.Close();
            conn.Open();

            string gid = comboBox1.SelectedItem.ToString();
            string sid = comboBox2.SelectedItem.ToString();
            DateTime dt = DateTime.Now;
            string q = "INSERT into GroupStudent(GroupId, StudentId ,Status, AssignmentDate ) values ('" + gid + "' , '" + sid + "' , '" + i + "','" + dt + "')";
            SqlCommand sc1 = new SqlCommand(q, conn);
            int r = sc1.ExecuteNonQuery();
            conn.Close();
            comboBox1.Text = "";
            comboBox2.Text = "";
            if (MessageBox.Show("Are you sure you want to add this Evaluation", "Insert", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                MessageBox.Show("Record inserted successfully");
            }
            else
            {
                MessageBox.Show("Record not inserted!");
            }
        }

        private void AddNew_Click(object sender, EventArgs e)
        {
            add.Show();
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
            string q = "select Id FROM Lookup WHERE Category = 'Status' AND value ='" + comboBox3.Text.ToString() + "'";
            SqlCommand sc = new SqlCommand(q, conn);
            int s = 0;
            SqlDataReader reader = sc.ExecuteReader();

            while (reader.Read())
            {
                s = int.Parse(reader[0].ToString());
            }
            reader.Close();
            string gid = comboBox1.SelectedItem.ToString();
            string g = comboBox2.SelectedItem.ToString();
            DateTime dt = DateTime.Now;
            string q1 = "Update GroupStudent set  AssignmentDate ='" + dt + "', Status ='" + s + "'  WHERE (GroupId = '" + gid + "'and StudentId ='" + g + "')where Id ='" + x + "'";
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
            string sid = comboBox2.SelectedItem.ToString();


            string display = String.Format("DELETE FROM GroupStudent WHERE  (GroupId = '" + gid + "'and StudentId = '" + sid + "')where Id ='" + x + "'");
            SqlCommand cmd = new SqlCommand(display, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            show();
            if (MessageBox.Show("are you sure you want to delete this record", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
