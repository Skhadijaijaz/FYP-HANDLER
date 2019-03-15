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
    public partial class Evaluation : Form
    {
        string con = "Data Source=DESKTOP-OFNFN9P\\SKI2017;Initial Catalog=ProjectA;Persist Security Info=True;User ID=sa;Password=Sql2018";
        public Evaluation()
        {
            InitializeComponent();
            add.Hide();
            Show();
        }

        private void Evaluation_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {

            add.Show();
            try
            {
                NText.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                numeric1.Value = decimal.Parse(dataGridView1.SelectedRows[0].Cells[2].Value.ToString());
                numeric2.Value = decimal.Parse(dataGridView1.SelectedRows[0].Cells[3].Value.ToString());
            }
            catch (Exception ex)
            {
                return;
            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            add.Hide();
            SqlConnection conn = new SqlConnection(con);
            try
            {
                if (conn.State == ConnectionState.Closed)
                { conn.Open(); }
                String Name = NText.Text.ToString();
                int marks = int.Parse(numeric1.Value.ToString());
                int weightage = int.Parse(numeric2.Value.ToString());
                String qry = "insert into Evaluation  values('" + Name + "','" + marks + "','" + weightage + "' ) ";
                SqlCommand cmd = new SqlCommand(qry, conn);
                int i = cmd.ExecuteNonQuery();
                if (i >= 1)
                { MessageBox.Show(i + "Evaluation" + Name + " " + "Added Successfully!"); }
                else
                {
                    { MessageBox.Show("Evaluation" + Name  + " " + "not Added!"); }
                }
                conn.Close();
                show();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void show()
        {
            SqlConnection conn = new SqlConnection(con);
            if (conn.State == ConnectionState.Closed)
            { conn.Open(); }
            String c= "SELECT  Evaluation.Id as [ID],Evaluation.Name as [Title],TotalMarks as[Total Marks],TotalWeightage as [Total Weightage] FROM [dbo].[Evaluation]  ";
            SqlCommand cmd = new SqlCommand(c, conn);
            try
            {
                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = cmd;
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

        private void Display_Click(object sender, EventArgs e)
        {
            add.Hide();
            SqlConnection conn = new SqlConnection(con);
            if (conn.State == ConnectionState.Closed)
            { conn.Open(); }
            String cmd = "SELECT  Evaluation.Id as [ID],Evaluation.Name as [Title],TotalMarks as[Total Marks],TotalWeightage as [Total Weightage] FROM [dbo].[Evaluation]  ";
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
            add.Hide();
            SqlConnection conn = new SqlConnection(con);
            try
            {
                if (conn.State == ConnectionState.Closed)
                { conn.Open(); }
                string a = (dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                //string a = dataGridView1.Columns["ID"].ToString();
                int x = 0;

                Int32.TryParse(a, out x);
                String Name1 = NText.Text.ToString();
                int marks = int.Parse(numeric1.Value.ToString());
                int weight = int.Parse(numeric2.Value.ToString());
                String qry = "delete from Evaluation  where Id='" + x + "'";
                SqlCommand sc = new SqlCommand(qry, conn);
                int i = sc.ExecuteNonQuery();

                if (i >= 1)
                { MessageBox.Show(i + " Evaluation Deleted :" + " " + Name1); }
                else
                {
                    MessageBox.Show(" Evaluation not Deleted :" + Name1);
                }
                conn.Close();
                show();
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(" ERROR IS :" + ex.ToString());
            }
        }

        private void Update_Click(object sender, EventArgs e)
        {
            add.Hide();
            SqlConnection conn = new SqlConnection(con);
            try
            {

                if (conn.State == ConnectionState.Closed)
                { conn.Open(); }
                string a = (dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                //string a = dataGridView1.Columns["ID"].ToString();
                int x = 0;

                Int32.TryParse(a, out x);
                String Name1 = NText.Text.ToString();
                int marks = int.Parse(numeric1.Value.ToString());
                int weight = int.Parse(numeric2.Value.ToString());  
                String qry = "update  Evaluation set Name = '" + Name1 + "',TotalMarks='" + marks + "',TotalWeightage='" + weight + "'where Id='" + x + "'";
                SqlCommand sc = new SqlCommand(qry, conn);
                int i = sc.ExecuteNonQuery();

                if (i >= 1)
                { MessageBox.Show(i + " Evaluation Updated :" + " " + Name1); }
                else
                {
                    { MessageBox.Show(" Evaluation not Updated :" + " " + Name1); }
                }
                conn.Close();
                show();


            }
            catch (Exception ex)
            {
                MessageBox.Show(" ERROR IS :" + ex.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Project p = new Project();
            this.Hide();
            p.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
            Project p = new Project();
            this.Hide();
            p.Show();
        }
    }
}
