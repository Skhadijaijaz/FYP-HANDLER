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
    public partial class Advisor : Form
    {
        string con = "Data Source=DESKTOP-OFNFN9P\\SKI2017;Initial Catalog=ProjectA;Persist Security Info=True;User ID=sa;Password=Sql2018";
        public Advisor()
        {
            InitializeComponent();
            add.Hide();
            Show();
        }

        private void Advisor_Load(object sender, EventArgs e)
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
                String FirstName = FNText.Text.ToString();
                String LastName = LNText.Text.ToString();
                String Contact = ContactText.Text.ToString();
                String Email = EmailText.Text.ToString();
                String gender1 = Male.Text.ToString();
                string gender2 = Female.Text.ToString();
                DateTime dt = DOBPicker.Value;
                string desig = DBox.Text.ToString();
                decimal sal = 0;
                if (decimal.TryParse(SText.Text.ToString(), out sal) && SText.MaxLength != 18)
                {
                    sal = decimal.Parse(SText.Text.ToString());
                }
                else
                {
                    
                    MessageBox.Show("Please enter a valid number");
                    conn.Close();
                    return;
                   
                }
                if(Male.Checked)
                {
                    int gen = gender(gender1);
                    if (desig != "Professor" && desig != "Associate Professor" && desig != "Assisstant Professor" && desig != "Lecturer" && desig != "Industry Professional")
                    {
                        string message = "You did not enter correct designation. Enter again?";
                        string caption = "Error ";

                        MessageBox.Show(message, caption);
                        conn.Close();
                        return;
                    }
                    int desg = designation(desig);
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


                    String qry1 = "insert into Advisor values('" + id + "','" + desg + "','" + sal + "')";
                    SqlCommand sc1 = new SqlCommand(qry1, conn);

                    int j = sc1.ExecuteNonQuery();
                    if (i >= 1 && j >= 1)
                    { MessageBox.Show(i + " Advisor Registered :" + FirstName + LastName); }
                    else
                    {
                        { MessageBox.Show("Advisor not Registered :" + FirstName + LastName); }
                    }
                    show();
                }
                else if(Female.Checked)
                {
                    int gen = gender(gender2);
                    if (desig != "Professor" && desig != "Associate Professor" && desig != "Assisstant Professor" && desig != "Lecturer" && desig != "Industry Professional")
                    {
                        string message = "You did not enter correct designation. Enter again?";
                        string caption = "Error ";

                        MessageBox.Show(message, caption);
                        conn.Close();
                        return;
                    }
                    int desg = designation(desig);
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


                    String qry1 = "insert into Advisor values('" + id + "','" + desg + "','" + sal + "')";
                    SqlCommand sc1 = new SqlCommand(qry1, conn);

                    int j = sc1.ExecuteNonQuery();
                    if (i >= 1 && j >= 1)
                    { MessageBox.Show(i + " Advisor Registered :" + FirstName + LastName); }
                    else
                    {
                        { MessageBox.Show("Advisor not Registered :" + FirstName + LastName); }
                    }

                    show();
                }
                else
                {
                    MessageBox.Show("Gender didn't selected!");
                }

                conn.Close();
                //show();

            }
            catch (Exception ex)
            {
                MessageBox.Show(" ERROR IS :" + ex.ToString());
            }
        }

        private int gender(string gen)
        {
            SqlConnection conn = new SqlConnection(con);
            string query;
            query = "SELECT Id FROM Lookup WHERE Category= 'GENDER' AND Value ='" + gen + "' ";
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

        private void show()
        {
            SqlConnection conn = new SqlConnection(con);
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            String cmd = "SELECT  Advisor.Id as [ID],FirstName as[First Name],LastName as [Last Name],Contact as [Contact],Email as [Email],DateOfBirth as [Date Of Birth],Gender as [Gender],Advisor.[Designation] as [Designation],Advisor.[Salary] as [Salary] FROM [dbo].[Person] JOIN [dbo].[Advisor] ON Advisor.Id = Person.Id ";
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private int designation(string gen)
        {
            SqlConnection conn = new SqlConnection(con);
            string query;
            query = "SELECT Id FROM Lookup WHERE Category= 'DESIGNATION' AND Value ='" + gen + "' ";
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
                LNText.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                ContactText.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                EmailText.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                SText.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
                if(Male.Checked)
                {
                    Male.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
                }
                else if(Female.Checked)
                {
                    Female.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
                }
                DBox.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
                DateTime dt;
                DateTime.TryParse(dataGridView1.SelectedRows[0].Cells[5].Value.ToString(), out dt);
                DOBPicker.Value = dt;
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
                String Contact = ContactText.Text.ToString();
                String Email = EmailText.Text.ToString();
                String gender1 = Male.Text.ToString();
                String gender2 = Female.Text.ToString();
                String desg1 = DBox.Text.ToString();
                decimal sal = 0;

                DateTime dt = DOBPicker.Value;
                if (decimal.TryParse(SText.Text.ToString(), out sal) && SText.MaxLength != 18)
                {
                    sal = decimal.Parse(SText.Text.ToString());
                }
                else
                {
                    
                    MessageBox.Show("Please enter a valid number");
                    conn.Close();
                    return;
                }



                if(Male.Checked)
                {
                    int gen = gender(gender1);
                    if (desg1 != "Professor" && desg1 != "Associate Professor" && desg1 != "Assisstant Professor" && desg1 != "Lecturer" && desg1 != "Industry Professional")
                    {
                        string message = "You did not enter correct designation. Enter again?";
                        string caption = "Error ";

                        MessageBox.Show(message, caption);
                        conn.Close();
                        return;
                    }
                    int desg = designation(desg1);
                    String qry = "update  Person set FirstName = '" + FirstName + "',LastName='" + LastName + "',Contact='" + Contact + "',Email='" + Email + "',DateOfBirth='" + dt + "',Gender='" + gen + "'where Id='" + x + "'";
                    SqlCommand sc = new SqlCommand(qry, conn);
                    int i = sc.ExecuteNonQuery();
                    String qry1 = "update  Advisor set Designation = '" + desg + "',Salary = '" + sal + "'where Id='" + x + "' ";
                    SqlCommand sc1 = new SqlCommand(qry1, conn);
                    int j = sc1.ExecuteNonQuery();
                    if (i >= 1 && j >= 1)
                    { MessageBox.Show(i + " Advisor Updated :" + FirstName + LastName); }
                    else
                    {
                        { MessageBox.Show(" Advisor not Updated :" + FirstName + LastName); }
                    }
                    show();
                }
                else if(Female.Checked)
                {
                    int gen = gender(gender2);
                    if (desg1 != "Professor" && desg1 != "Associate Professor" && desg1 != "Assisstant Professor" && desg1 != "Lecturer" && desg1 != "Industry Professional")
                    {
                        string message = "You did not enter correct designation. Enter again?";
                        string caption = "Error ";

                        MessageBox.Show(message, caption);
                        conn.Close();
                        return;
                    }
                    int desg = designation(desg1);
                    String qry = "update  Person set FirstName = '" + FirstName + "',LastName='" + LastName + "',Contact='" + Contact + "',Email='" + Email + "',DateOfBirth='" + dt + "',Gender='" + gen + "'where Id='" + x + "'";
                    SqlCommand sc = new SqlCommand(qry, conn);
                    int i = sc.ExecuteNonQuery();
                    String qry1 = "update  Advisor set Designation = '" + desg + "',Salary = '" + sal + "'where Id='" + x + "' ";
                    SqlCommand sc1 = new SqlCommand(qry1, conn);
                    int j = sc1.ExecuteNonQuery();
                    if (i >= 1 && j >= 1)
                    { MessageBox.Show(i + " Advisor Updated :" + FirstName + LastName); }
                    else
                    {
                        { MessageBox.Show(" Advisor not Updated :" + FirstName + LastName); }
                    }
                    show();
                }
                else
                {
                    MessageBox.Show("Gender didn't selected!");
                }

                conn.Close();
               // show();


            }
            catch (Exception ex)
            {
                MessageBox.Show(" ERROR IS :" + ex.ToString());
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
                int gen = gender(gender1);
                String desg1 = DBox.Text.ToString();
                int desg = designation(desg1);
                decimal sal = decimal.Parse(SText.Text.ToString());

                DateTime dt = DOBPicker.Value;
                String qry = "delete from Person  where Id='" + x + "'";
                SqlCommand sc = new SqlCommand(qry, conn);
                int i = sc.ExecuteNonQuery();
                String qry1 = "delete from Advisor where Id='" + x + "' ";
                SqlCommand sc1 = new SqlCommand(qry1, conn);
                int j = sc1.ExecuteNonQuery();
                if (i >= 1 && j >= 1)
                { MessageBox.Show(i + " Advisor Deleted :" + FirstName + LastName); }
                else
                {
                    MessageBox.Show(" Advisor not Deleted :" + FirstName + LastName);
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
            String cmd = "SELECT  Advisor.Id as [ID],FirstName as[First Name],LastName as [Last Name],Contact as [Contact],Email as [Email],DateOfBirth as [Date Of Birth],Gender as [Gender],Advisor.[Designation] as [Designation],Advisor.[Salary] as [Salary] FROM [dbo].[Person] JOIN [dbo].[Advisor] ON Advisor.Id = Person.Id ";
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
