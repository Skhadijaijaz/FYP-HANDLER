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
    public partial class Student : Form
    {
        string con = "Data Source=DESKTOP-OFNFN9P\\SKI2017;Initial Catalog=ProjectA;Persist Security Info=True;User ID=sa;Password=Sql2018";
        public Student()
        {
            InitializeComponent();
            add.Hide();
            Show();

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void Male_MouseClick(object sender, MouseEventArgs e)
        {
            String gender1 = Male.Text.ToString();
            
        }

        private void Female_MouseClick(object sender, MouseEventArgs e)
        {
            String gender1 = Female.Text.ToString();
        }
        private int gender(string gen)
        {
            SqlConnection conn = new SqlConnection(con);
            string query;
            if (gen == "Male")
            {
                query = " Select Id from Lookup where Category= 'GENDER' AND Value = 'Male';";
            }
            else
            {
                query = " Select Id from Lookup where Category= 'GENDER' AND Value = 'Female';";
            }
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            int value = 0;
            while (reader.Read())
            {
                value = int.Parse(reader[0].ToString());
            }
            return value;
        }
        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            add.Show();
            try
            {
                FNText.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                ContactText.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                LNText.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                EmailText.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                RNText.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
                int gen = int.Parse(dataGridView1.SelectedRows[0].Cells[6].Value.ToString());
                DateTime dt;
                DateTime.TryParse(dataGridView1.SelectedRows[0].Cells[5].Value.ToString(), out dt);
                DOBPicker.Value = dt;
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
                {
                    conn.Open();
                }
                String FirstName =FNText.Text.ToString();
                String LastName = LNText.Text.ToString();
                String reg = RNText.Text.ToString();
                String Contact = ContactText.Text.ToString();
                String Email = EmailText.Text.ToString();
                string gender1 = Male.Text.ToString();
                string gender2 = Female.Text.ToString();
              

                DateTime dt = DOBPicker.Value;
                  
                if(Male.Checked)
                {
                    int gen = gender(gender1);
                    String qry = "insert into Person  values('" + FirstName + "','" + LastName + "','" + Contact + "','" + Email + "','" + dt + "','" + gen + "' ) ";
                    SqlCommand sc = new SqlCommand(qry, conn);
                    int i = sc.ExecuteNonQuery();
                    int id = 0;
                    string query = " Select Id from Person where (Id = SCOPE_IDENTITY());";
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }
                    SqlCommand cmd = new SqlCommand(query, conn);
                    var val = cmd.ExecuteScalar().ToString();
                    id = int.Parse(val);


                    String qry1 = "insert into Student values('" + id + "','" + reg + "')";
                    SqlCommand sc1 = new SqlCommand(qry1, conn);

                    int j = sc1.ExecuteNonQuery();
                    if (i >= 1 && j >= 1)
                    { MessageBox.Show(i + " Student Registered :" + FirstName + LastName); }
                    else
                    {
                        { MessageBox.Show(" Student not Registered :" + FirstName + LastName); }
                    }
                    show();
                }
                else if(Female.Checked)
                {
                    int gen = gender(gender2);
                    String qry = "insert into Person  values('" + FirstName + "','" + LastName + "','" + Contact + "','" + Email + "','" + dt + "','" + gen + "' ) ";
                    SqlCommand sc = new SqlCommand(qry, conn);
                    int i = sc.ExecuteNonQuery();
                    int id = 0;

                    string query = " Select Id from Person where (Id = SCOPE_IDENTITY());";
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }
                    SqlCommand cmd = new SqlCommand(query, conn);
                    var val = cmd.ExecuteScalar().ToString();
                    id = int.Parse(val);

                    String qry1 = "insert into Student values('" + id + "','" + reg + "')";
                    SqlCommand sc1 = new SqlCommand(qry1, conn);

                    int j = sc1.ExecuteNonQuery();
                    if (i >= 1 && j >= 1)
                    { MessageBox.Show(i + " Student Registered :" + FirstName + LastName); }
                    else
                    {
                        { MessageBox.Show(" Student not Registered :" + FirstName + LastName); }
                    }
                    show();

                }
                else
                {
                    MessageBox.Show("Didn't select Gender!");
                }

                conn.Close();

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
                {
                    conn.Open();
                }
                string a = (dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                int x = 0;

                Int32.TryParse(a, out x);
                String FirstName = FNText.Text.ToString();
                String LastName = LNText.Text.ToString();
                String reg = RNText.Text.ToString();
                String Contact = ContactText.Text.ToString();
                String Email = EmailText.Text.ToString();
                string gender1 = Male.Text.ToString();
                string gender2 = Female.Text.ToString();
                DateTime dt = DOBPicker.Value;
               
                if(Male.Checked)
                {
                    int gen = gender(gender1);
                    String qry = "update  Person set FirstName = '" + FirstName + "',LastName='" + LastName + "',Contact='" + Contact + "',Email='" + Email + "',DateOfBirth='" + dt + "',Gender='" + gen + "'where Id='" + x + "'";
                    SqlCommand sc = new SqlCommand(qry, conn);
                    int i = sc.ExecuteNonQuery();
                    String qry1 = "update  Student set RegistrationNo = '" + reg + "' where Id='" + x + "'";
                    SqlCommand sc1 = new SqlCommand(qry1, conn);
                    int j = sc1.ExecuteNonQuery();
                    if (i >= 1 && j >= 1)
                    { MessageBox.Show(i + " Student Updated :" + FirstName + LastName); }
                    else
                    {
                        { MessageBox.Show(i + " Student not Updated :" + FirstName + LastName); }
                    }
                    show();
                }
                else if (Female.Checked)
                {
                    int gen = gender(gender2);
                    String qry = "update  Person set FirstName = '" + FirstName + "',LastName='" + LastName + "',Contact='" + Contact + "',Email='" + Email + "',DateOfBirth='" + dt + "',Gender='" + gen + "'where Id='" + x + "'";
                    SqlCommand sc = new SqlCommand(qry, conn);
                    int i = sc.ExecuteNonQuery();
                    String qry1 = "update  Student set RegistrationNo = '" + reg + "' where Id='" + x + "'";
                    SqlCommand sc1 = new SqlCommand(qry1, conn);
                    int j = sc1.ExecuteNonQuery();
                    if (i >= 1 && j >= 1)
                    { MessageBox.Show(i + " Student Updated :" + FirstName + LastName); }
                    else
                    {
                        { MessageBox.Show(i + " Student not Updated :" + FirstName + LastName); }
                    }
                    show();
                }
                else
                {
                    MessageBox.Show("Didn't select Gender!");
                }

                conn.Close();
               // show();


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
            String cmd = "SELECT Person.[Id] as [ID],FirstName as [First Name],LastName as [Last Name],Contact as [Contact],Email as [Email],DateOfBirth as [Date Of Birth],Gender as [Gender],Student.[RegistrationNo] as [Registration No] FROM [dbo].[Person] JOIN [dbo].[Student] ON Student.Id = Person.Id ";
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
                {
                    conn.Open();
                }
                string a = (dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                int x = 0;

                Int32.TryParse(a, out x);
                String FirstName = FNText.Text.ToString();
                String LastName = LNText.Text.ToString();
                String Contact = ContactText.Text.ToString();
                String Email = EmailText.Text.ToString();
                String gender1 = Male.Text.ToString();
                String gender2 = Female.Text.ToString();
                String reg = RNText.Text.ToString();
               

                DateTime dt = DOBPicker.Value;
                if(Male.Checked)
                {
                    int gen = gender(gender1);
                    String qry = "delete from  Person  where Id='" + x + "'";
                    SqlCommand sc = new SqlCommand(qry, conn);

                    String qry1 = "delete from  Student  where Id='" + x + "'";
                    SqlCommand sc1 = new SqlCommand(qry1, conn);
                    int j = sc1.ExecuteNonQuery();
                    int i = sc.ExecuteNonQuery();
                    if (i >= 1 && j >= 1)
                    { MessageBox.Show(i + " Person Deleted :" + FirstName + LastName); }
                    else
                    {
                        { MessageBox.Show(i + " Person not Deleted :" + FirstName + LastName); }
                    }
                    show();

                }
                else if(Female.Checked)
                {
                    String qry = "delete from  Person  where Id='" + x + "'";
                    SqlCommand sc = new SqlCommand(qry, conn);

                    String qry1 = "delete from  Student  where Id='" + x + "'";
                    SqlCommand sc1 = new SqlCommand(qry1, conn);
                    int j = sc1.ExecuteNonQuery();
                    int i = sc.ExecuteNonQuery();
                    if (i >= 1 && j >= 1)
                    { MessageBox.Show(i + " Person Deleted :" + FirstName + LastName); }
                    else
                    {
                        { MessageBox.Show(i + " Person not Deleted :" + FirstName + LastName); }
                    }
                    show();

                }
                else
                {
                    MessageBox.Show("Didn't select Gender!");
                }


                conn.Close();

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
            String cmd = "SELECT Person.[Id] as [ID],FirstName as [First Name],LastName as [Last Name],Contact as [Contact],Email as [Email],DateOfBirth as [Date Of Birth],Gender as [Gender],Student.[RegistrationNo] as [Registration No] FROM [dbo].[Person] JOIN [dbo].[Student] ON Student.Id = Person.Id ";
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

        private void Student_Load(object sender, EventArgs e)
        {

        }
    }
}
