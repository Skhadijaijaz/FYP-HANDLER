namespace fyp_handler
{
    partial class Advisor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Home = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.AddNew = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.Display = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Advisors = new System.Windows.Forms.Label();
            this.add = new System.Windows.Forms.Panel();
            this.DBox = new System.Windows.Forms.ComboBox();
            this.Designation = new System.Windows.Forms.Label();
            this.SText = new System.Windows.Forms.TextBox();
            this.Salary = new System.Windows.Forms.Label();
            this.Save = new System.Windows.Forms.Button();
            this.DOBPicker = new System.Windows.Forms.DateTimePicker();
            this.EmailText = new System.Windows.Forms.TextBox();
            this.LNText = new System.Windows.Forms.TextBox();
            this.ContactText = new System.Windows.Forms.TextBox();
            this.FNText = new System.Windows.Forms.TextBox();
            this.Female = new System.Windows.Forms.RadioButton();
            this.Male = new System.Windows.Forms.RadioButton();
            this.Gender = new System.Windows.Forms.Label();
            this.DOB = new System.Windows.Forms.Label();
            this.Contact = new System.Windows.Forms.Label();
            this.LastName = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.FirstName = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.add.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.Home);
            this.panel1.Controls.Add(this.Delete);
            this.panel1.Controls.Add(this.AddNew);
            this.panel1.Controls.Add(this.Update);
            this.panel1.Controls.Add(this.Display);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(114, 477);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::fyp_handler.Properties.Resources.download__12_;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 49;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Home
            // 
            this.Home.Location = new System.Drawing.Point(3, 98);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(96, 49);
            this.Home.TabIndex = 48;
            this.Home.Text = "Home";
            this.Home.UseVisualStyleBackColor = true;
            this.Home.Click += new System.EventHandler(this.Home_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(3, 305);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(96, 49);
            this.Delete.TabIndex = 47;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // AddNew
            // 
            this.AddNew.Location = new System.Drawing.Point(3, 163);
            this.AddNew.Name = "AddNew";
            this.AddNew.Size = new System.Drawing.Size(96, 49);
            this.AddNew.TabIndex = 46;
            this.AddNew.Text = "Add New";
            this.AddNew.UseVisualStyleBackColor = true;
            this.AddNew.Click += new System.EventHandler(this.AddNew_Click);
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(3, 233);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(96, 49);
            this.Update.TabIndex = 45;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // Display
            // 
            this.Display.Location = new System.Drawing.Point(3, 378);
            this.Display.Name = "Display";
            this.Display.Size = new System.Drawing.Size(96, 49);
            this.Display.TabIndex = 44;
            this.Display.Text = "Display";
            this.Display.UseVisualStyleBackColor = true;
            this.Display.Click += new System.EventHandler(this.Display_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Advisors);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(114, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(686, 58);
            this.panel2.TabIndex = 1;
            // 
            // Advisors
            // 
            this.Advisors.AutoSize = true;
            this.Advisors.BackColor = System.Drawing.SystemColors.ControlText;
            this.Advisors.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Advisors.ForeColor = System.Drawing.Color.White;
            this.Advisors.Location = new System.Drawing.Point(250, 9);
            this.Advisors.Name = "Advisors";
            this.Advisors.Size = new System.Drawing.Size(127, 31);
            this.Advisors.TabIndex = 2;
            this.Advisors.Text = "Advisors";
            // 
            // add
            // 
            this.add.Controls.Add(this.DBox);
            this.add.Controls.Add(this.Designation);
            this.add.Controls.Add(this.SText);
            this.add.Controls.Add(this.Salary);
            this.add.Controls.Add(this.Save);
            this.add.Controls.Add(this.DOBPicker);
            this.add.Controls.Add(this.EmailText);
            this.add.Controls.Add(this.LNText);
            this.add.Controls.Add(this.ContactText);
            this.add.Controls.Add(this.FNText);
            this.add.Controls.Add(this.Female);
            this.add.Controls.Add(this.Male);
            this.add.Controls.Add(this.Gender);
            this.add.Controls.Add(this.DOB);
            this.add.Controls.Add(this.Contact);
            this.add.Controls.Add(this.LastName);
            this.add.Controls.Add(this.Email);
            this.add.Controls.Add(this.FirstName);
            this.add.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.add.Location = new System.Drawing.Point(114, 297);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(686, 180);
            this.add.TabIndex = 2;
            // 
            // DBox
            // 
            this.DBox.FormattingEnabled = true;
            this.DBox.Location = new System.Drawing.Point(122, 81);
            this.DBox.Name = "DBox";
            this.DBox.Size = new System.Drawing.Size(121, 21);
            this.DBox.TabIndex = 81;
            // 
            // Designation
            // 
            this.Designation.AutoSize = true;
            this.Designation.BackColor = System.Drawing.SystemColors.ControlText;
            this.Designation.ForeColor = System.Drawing.Color.White;
            this.Designation.Location = new System.Drawing.Point(17, 89);
            this.Designation.Name = "Designation";
            this.Designation.Size = new System.Drawing.Size(63, 13);
            this.Designation.TabIndex = 80;
            this.Designation.Text = "Designation";
            // 
            // SText
            // 
            this.SText.Location = new System.Drawing.Point(436, 86);
            this.SText.Name = "SText";
            this.SText.Size = new System.Drawing.Size(124, 20);
            this.SText.TabIndex = 78;
            // 
            // Salary
            // 
            this.Salary.AutoSize = true;
            this.Salary.ForeColor = System.Drawing.Color.White;
            this.Salary.Location = new System.Drawing.Point(331, 89);
            this.Salary.Name = "Salary";
            this.Salary.Size = new System.Drawing.Size(36, 13);
            this.Salary.TabIndex = 65;
            this.Salary.Text = "Salary";
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(256, 157);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 23);
            this.Save.TabIndex = 69;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // DOBPicker
            // 
            this.DOBPicker.Location = new System.Drawing.Point(122, 116);
            this.DOBPicker.Name = "DOBPicker";
            this.DOBPicker.Size = new System.Drawing.Size(124, 20);
            this.DOBPicker.TabIndex = 79;
            // 
            // EmailText
            // 
            this.EmailText.Location = new System.Drawing.Point(436, 45);
            this.EmailText.Name = "EmailText";
            this.EmailText.Size = new System.Drawing.Size(124, 20);
            this.EmailText.TabIndex = 77;
            // 
            // LNText
            // 
            this.LNText.Location = new System.Drawing.Point(436, 5);
            this.LNText.Name = "LNText";
            this.LNText.Size = new System.Drawing.Size(124, 20);
            this.LNText.TabIndex = 76;
            // 
            // ContactText
            // 
            this.ContactText.Location = new System.Drawing.Point(122, 49);
            this.ContactText.Name = "ContactText";
            this.ContactText.Size = new System.Drawing.Size(124, 20);
            this.ContactText.TabIndex = 75;
            // 
            // FNText
            // 
            this.FNText.Location = new System.Drawing.Point(122, 9);
            this.FNText.Name = "FNText";
            this.FNText.Size = new System.Drawing.Size(124, 20);
            this.FNText.TabIndex = 74;
            // 
            // Female
            // 
            this.Female.AutoSize = true;
            this.Female.ForeColor = System.Drawing.Color.White;
            this.Female.Location = new System.Drawing.Point(516, 120);
            this.Female.Name = "Female";
            this.Female.Size = new System.Drawing.Size(59, 17);
            this.Female.TabIndex = 73;
            this.Female.TabStop = true;
            this.Female.Text = "Female";
            this.Female.UseVisualStyleBackColor = true;
            // 
            // Male
            // 
            this.Male.AutoSize = true;
            this.Male.ForeColor = System.Drawing.Color.White;
            this.Male.Location = new System.Drawing.Point(456, 120);
            this.Male.Name = "Male";
            this.Male.Size = new System.Drawing.Size(48, 17);
            this.Male.TabIndex = 72;
            this.Male.TabStop = true;
            this.Male.Text = "Male";
            this.Male.UseVisualStyleBackColor = true;
            // 
            // Gender
            // 
            this.Gender.AutoSize = true;
            this.Gender.BackColor = System.Drawing.SystemColors.ControlText;
            this.Gender.ForeColor = System.Drawing.Color.White;
            this.Gender.Location = new System.Drawing.Point(331, 122);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(42, 13);
            this.Gender.TabIndex = 71;
            this.Gender.Text = "Gender";
            // 
            // DOB
            // 
            this.DOB.AutoSize = true;
            this.DOB.BackColor = System.Drawing.SystemColors.ControlText;
            this.DOB.ForeColor = System.Drawing.Color.White;
            this.DOB.Location = new System.Drawing.Point(17, 122);
            this.DOB.Name = "DOB";
            this.DOB.Size = new System.Drawing.Size(68, 13);
            this.DOB.TabIndex = 70;
            this.DOB.Text = "Date Of Birth";
            // 
            // Contact
            // 
            this.Contact.AutoSize = true;
            this.Contact.BackColor = System.Drawing.SystemColors.ControlText;
            this.Contact.ForeColor = System.Drawing.Color.White;
            this.Contact.Location = new System.Drawing.Point(17, 52);
            this.Contact.Name = "Contact";
            this.Contact.Size = new System.Drawing.Size(44, 13);
            this.Contact.TabIndex = 68;
            this.Contact.Text = "Contact";
            // 
            // LastName
            // 
            this.LastName.AutoSize = true;
            this.LastName.BackColor = System.Drawing.SystemColors.ControlText;
            this.LastName.ForeColor = System.Drawing.Color.White;
            this.LastName.Location = new System.Drawing.Point(331, 8);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(58, 13);
            this.LastName.TabIndex = 67;
            this.LastName.Text = "Last Name";
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.BackColor = System.Drawing.SystemColors.ControlText;
            this.Email.ForeColor = System.Drawing.Color.White;
            this.Email.Location = new System.Drawing.Point(331, 49);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(32, 13);
            this.Email.TabIndex = 66;
            this.Email.Text = "Email";
            // 
            // FirstName
            // 
            this.FirstName.AutoSize = true;
            this.FirstName.BackColor = System.Drawing.SystemColors.ControlText;
            this.FirstName.ForeColor = System.Drawing.Color.White;
            this.FirstName.Location = new System.Drawing.Point(17, 12);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(57, 13);
            this.FirstName.TabIndex = 64;
            this.FirstName.Text = "First Name";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dataGridView1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(114, 58);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(686, 239);
            this.panel4.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 10);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(668, 223);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            // 
            // Advisor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(800, 477);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.add);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Advisor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Advisor";
            this.Load += new System.EventHandler(this.Advisor_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.add.ResumeLayout(false);
            this.add.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel add;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.DateTimePicker DOBPicker;
        private System.Windows.Forms.TextBox SText;
        private System.Windows.Forms.TextBox EmailText;
        private System.Windows.Forms.TextBox LNText;
        private System.Windows.Forms.TextBox ContactText;
        private System.Windows.Forms.TextBox FNText;
        private System.Windows.Forms.RadioButton Female;
        private System.Windows.Forms.RadioButton Male;
        private System.Windows.Forms.Label Gender;
        private System.Windows.Forms.Label DOB;
        private System.Windows.Forms.Label Contact;
        private System.Windows.Forms.Label LastName;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Label Salary;
        private System.Windows.Forms.Label FirstName;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Home;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button AddNew;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button Display;
        private System.Windows.Forms.Label Advisors;
        private System.Windows.Forms.Label Designation;
        private System.Windows.Forms.ComboBox DBox;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}