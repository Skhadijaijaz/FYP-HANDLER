namespace fyp_handler
{
    partial class Student
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
            this.Students = new System.Windows.Forms.Label();
            this.add = new System.Windows.Forms.Panel();
            this.Save = new System.Windows.Forms.Button();
            this.DOBPicker = new System.Windows.Forms.DateTimePicker();
            this.RNText = new System.Windows.Forms.TextBox();
            this.EmailText = new System.Windows.Forms.TextBox();
            this.LNText = new System.Windows.Forms.TextBox();
            this.ContactText = new System.Windows.Forms.TextBox();
            this.FNText = new System.Windows.Forms.TextBox();
            this.Female = new System.Windows.Forms.RadioButton();
            this.Male = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.add.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(114, 450);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::fyp_handler.Properties.Resources.download__12_;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 43;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Home
            // 
            this.Home.Location = new System.Drawing.Point(3, 96);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(96, 49);
            this.Home.TabIndex = 42;
            this.Home.Text = "Home";
            this.Home.UseVisualStyleBackColor = true;
            this.Home.Click += new System.EventHandler(this.Home_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(3, 311);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(96, 49);
            this.Delete.TabIndex = 41;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // AddNew
            // 
            this.AddNew.Location = new System.Drawing.Point(3, 169);
            this.AddNew.Name = "AddNew";
            this.AddNew.Size = new System.Drawing.Size(96, 49);
            this.AddNew.TabIndex = 40;
            this.AddNew.Text = "Add New";
            this.AddNew.UseVisualStyleBackColor = true;
            this.AddNew.Click += new System.EventHandler(this.AddNew_Click);
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(3, 239);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(96, 49);
            this.Update.TabIndex = 39;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // Display
            // 
            this.Display.Location = new System.Drawing.Point(3, 384);
            this.Display.Name = "Display";
            this.Display.Size = new System.Drawing.Size(96, 49);
            this.Display.TabIndex = 38;
            this.Display.Text = "Display";
            this.Display.UseVisualStyleBackColor = true;
            this.Display.Click += new System.EventHandler(this.Display_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Students);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(114, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(686, 65);
            this.panel2.TabIndex = 2;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // Students
            // 
            this.Students.AutoSize = true;
            this.Students.BackColor = System.Drawing.SystemColors.ControlText;
            this.Students.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Students.ForeColor = System.Drawing.Color.White;
            this.Students.Location = new System.Drawing.Point(266, 20);
            this.Students.Name = "Students";
            this.Students.Size = new System.Drawing.Size(130, 31);
            this.Students.TabIndex = 1;
            this.Students.Text = "Students";
            // 
            // add
            // 
            this.add.Controls.Add(this.Save);
            this.add.Controls.Add(this.DOBPicker);
            this.add.Controls.Add(this.RNText);
            this.add.Controls.Add(this.EmailText);
            this.add.Controls.Add(this.LNText);
            this.add.Controls.Add(this.ContactText);
            this.add.Controls.Add(this.FNText);
            this.add.Controls.Add(this.Female);
            this.add.Controls.Add(this.Male);
            this.add.Controls.Add(this.label7);
            this.add.Controls.Add(this.label6);
            this.add.Controls.Add(this.label5);
            this.add.Controls.Add(this.label4);
            this.add.Controls.Add(this.label1);
            this.add.Controls.Add(this.label3);
            this.add.Controls.Add(this.label2);
            this.add.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.add.Location = new System.Drawing.Point(114, 283);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(686, 167);
            this.add.TabIndex = 3;
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(518, 130);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 23);
            this.Save.TabIndex = 53;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // DOBPicker
            // 
            this.DOBPicker.Location = new System.Drawing.Point(469, 87);
            this.DOBPicker.Name = "DOBPicker";
            this.DOBPicker.Size = new System.Drawing.Size(124, 20);
            this.DOBPicker.TabIndex = 63;
            // 
            // RNText
            // 
            this.RNText.Location = new System.Drawing.Point(175, 52);
            this.RNText.Name = "RNText";
            this.RNText.Size = new System.Drawing.Size(120, 20);
            this.RNText.TabIndex = 62;
            // 
            // EmailText
            // 
            this.EmailText.Location = new System.Drawing.Point(175, 87);
            this.EmailText.Name = "EmailText";
            this.EmailText.Size = new System.Drawing.Size(120, 20);
            this.EmailText.TabIndex = 61;
            // 
            // LNText
            // 
            this.LNText.Location = new System.Drawing.Point(469, 18);
            this.LNText.Name = "LNText";
            this.LNText.Size = new System.Drawing.Size(124, 20);
            this.LNText.TabIndex = 60;
            // 
            // ContactText
            // 
            this.ContactText.Location = new System.Drawing.Point(469, 52);
            this.ContactText.Name = "ContactText";
            this.ContactText.Size = new System.Drawing.Size(124, 20);
            this.ContactText.TabIndex = 59;
            // 
            // FNText
            // 
            this.FNText.Location = new System.Drawing.Point(175, 17);
            this.FNText.Name = "FNText";
            this.FNText.Size = new System.Drawing.Size(120, 20);
            this.FNText.TabIndex = 58;
            // 
            // Female
            // 
            this.Female.AutoSize = true;
            this.Female.ForeColor = System.Drawing.Color.White;
            this.Female.Location = new System.Drawing.Point(175, 130);
            this.Female.Name = "Female";
            this.Female.Size = new System.Drawing.Size(59, 17);
            this.Female.TabIndex = 57;
            this.Female.TabStop = true;
            this.Female.Text = "Female";
            this.Female.UseVisualStyleBackColor = true;
            this.Female.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Female_MouseClick);
            // 
            // Male
            // 
            this.Male.AutoSize = true;
            this.Male.ForeColor = System.Drawing.Color.White;
            this.Male.Location = new System.Drawing.Point(122, 130);
            this.Male.Name = "Male";
            this.Male.Size = new System.Drawing.Size(48, 17);
            this.Male.TabIndex = 56;
            this.Male.TabStop = true;
            this.Male.Text = "Male";
            this.Male.UseVisualStyleBackColor = true;
            this.Male.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Male_MouseClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ControlText;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(50, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 55;
            this.label7.Text = "Gender";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ControlText;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(364, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 54;
            this.label6.Text = "Date Of Birth";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ControlText;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(364, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 52;
            this.label5.Text = "Contact";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ControlText;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(364, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 51;
            this.label4.Text = "Last Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlText;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(50, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 50;
            this.label1.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(50, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 49;
            this.label3.Text = "Registration No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlText;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(50, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 48;
            this.label2.Text = "First Name";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(120, 71);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(668, 206);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            // 
            // Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.add);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Student";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student";
            this.Load += new System.EventHandler(this.Student_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.add.ResumeLayout(false);
            this.add.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button AddNew;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button Display;
        private System.Windows.Forms.Label Students;
        private System.Windows.Forms.Panel add;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.DateTimePicker DOBPicker;
        private System.Windows.Forms.TextBox RNText;
        private System.Windows.Forms.TextBox EmailText;
        private System.Windows.Forms.TextBox LNText;
        private System.Windows.Forms.TextBox ContactText;
        private System.Windows.Forms.TextBox FNText;
        private System.Windows.Forms.RadioButton Female;
        private System.Windows.Forms.RadioButton Male;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Home;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}