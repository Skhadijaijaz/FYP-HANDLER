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
    public partial class Project : Form
    {
        string con = "Data Source=DESKTOP-OFNFN9P\\SKI2017;Initial Catalog=ProjectA;Persist Security Info=True;User ID=sa;Password=Sql2018";
        public Project()
        {
            InitializeComponent();
            add.Hide();
            Show();
        }

        private void Project_Load(object sender, EventArgs e)
        {

        }

        private void Save_Click(object sender, EventArgs e)
        {
            add.Hide();
            SqlConnection conn = new SqlConnection(con);
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                String Desc = richTextBox.Text.ToString();
                String title = TitleText.Text.ToString();
                String qry = "insert into Project  values('" + Desc + "','" + title + "' ) ";
                SqlCommand sc = new SqlCommand(qry, conn);
                int i = sc.ExecuteNonQuery();
                if (i >= 1)
                { MessageBox.Show(i + " Project Added Successfully :" + title); }
                else
                {
                    MessageBox.Show(" Project not Added :" + title);
                }

                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Update_Click(object sender, EventArgs e)
        {

            SqlConnection conn = new SqlConnection(con);
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string a = (dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                int x = 0;

                Int32.TryParse(a, out x);
                String Desc = richTextBox.Text.ToString();
                String title1 = TitleText.Text.ToString();
                String qry = "update  Project set Description = '" + Desc + "',Title='" + title1 + "' where Id='" + x + "'";
                SqlCommand sc = new SqlCommand(qry, conn);
                int i = sc.ExecuteNonQuery();


                if (i >= 1)
                { MessageBox.Show(i + " Project Updated :" + title1); }
                else
                {
                    { MessageBox.Show(" Project not Updated :" + title1); }
                }
                conn.Close();
                show();


            }
            catch (Exception ex)
            {
                MessageBox.Show(" ERROR IS :" + ex.ToString());
            }
        }

        private void show()
        {
            SqlConnection conn = new SqlConnection(con);
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            String cmd = "SELECT Project.[Id] ,Description ,Title  FROM [dbo].[Project]  ";
            SqlCommand command = new SqlCommand(cmd, conn);
            try
            {
                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = command;
                DataTable dbadataset = new DataTable();
                sda.Fill(dbadataset);
                BindingSource bsource = new BindingSource();
                bsource.DataSource = dbadataset;
                dataGridView1.DataSource = bsource;
                sda.Update(dbadataset);
                this.dataGridView1.Columns["ID"].Visible = false;
                conn.Close();
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(con);
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string a = (dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                int x = 0;

                Int32.TryParse(a, out x);
                String Desc = richTextBox.Text.ToString();
                String title1 = TitleText.Text.ToString();
                String qry = "delete from Project  where Id='" + x + "'";
                SqlCommand sc = new SqlCommand(qry, conn);
                int i = sc.ExecuteNonQuery();

                if (i >= 1)
                { MessageBox.Show(i + " Project removed :" + title1); }
                else
                {
                    { MessageBox.Show(" Project not removed :" + title1); }
                }
                conn.Close();
                show();


            }
            catch (Exception ex)
            {
                MessageBox.Show(" ERROR IS :" + ex.ToString());
            }
        }

        private void Display_Click(object sender, EventArgs e)
        {
            add.Hide();
            SqlConnection conn = new SqlConnection(con);
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            String cmd = "SELECT Project.[Id] ,Description ,Title  FROM [dbo].[Project]  ";
            SqlCommand command = new SqlCommand(cmd, conn);
            try
            {
                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = command;
                DataTable dbadataset = new DataTable();
                sda.Fill(dbadataset);
                BindingSource bsource = new BindingSource();
                bsource.DataSource = dbadataset;
                dataGridView1.DataSource = bsource;
                sda.Update(dbadataset);
                this.dataGridView1.Columns["ID"].Visible = false;
                conn.Close();
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            add.Show();
            try
            {
                richTextBox.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                TitleText.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            }
            catch (Exception ex)
            {
                return;

            }
        }

        private void AddNew_Click(object sender, EventArgs e)
        {
            add.Show();
        }

        private void Home_Click(object sender, EventArgs e)
        {
            WELCOME1 w = new WELCOME1();
            this.Hide();
            w.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Student s = new Student();
            this.Hide();
            s.Show();
        }
    }
}