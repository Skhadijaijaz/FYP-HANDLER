namespace fyp_handler
{
    partial class ProjectAdvisor
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
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.ProjectIdlabel = new System.Windows.Forms.Label();
            this.AdvisorIdlabel = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.AdvisorRolelabel = new System.Windows.Forms.Label();
            this.Save = new System.Windows.Forms.Button();
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
            this.panel1.Size = new System.Drawing.Size(140, 450);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::fyp_handler.Properties.Resources.download__12_;
            this.pictureBox1.Location = new System.Drawing.Point(31, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 49;
            this.pictureBox1.TabStop = false;
            // 
            // Home
            // 
            this.Home.Location = new System.Drawing.Point(22, 99);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(96, 49);
            this.Home.TabIndex = 48;
            this.Home.Text = "Home";
            this.Home.UseVisualStyleBackColor = true;
            this.Home.Click += new System.EventHandler(this.Home_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(22, 314);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(96, 49);
            this.Delete.TabIndex = 47;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // AddNew
            // 
            this.AddNew.Location = new System.Drawing.Point(22, 172);
            this.AddNew.Name = "AddNew";
            this.AddNew.Size = new System.Drawing.Size(96, 49);
            this.AddNew.TabIndex = 46;
            this.AddNew.Text = "Add New";
            this.AddNew.UseVisualStyleBackColor = true;
            this.AddNew.Click += new System.EventHandler(this.AddNew_Click);
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(22, 242);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(96, 49);
            this.Update.TabIndex = 45;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // Display
            // 
            this.Display.Location = new System.Drawing.Point(22, 387);
            this.Display.Name = "Display";
            this.Display.Size = new System.Drawing.Size(96, 49);
            this.Display.TabIndex = 44;
            this.Display.Text = "Display";
            this.Display.UseVisualStyleBackColor = true;
            this.Display.Click += new System.EventHandler(this.Display_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Students);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(140, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(660, 59);
            this.panel2.TabIndex = 1;
            // 
            // Students
            // 
            this.Students.AutoSize = true;
            this.Students.BackColor = System.Drawing.SystemColors.ControlText;
            this.Students.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Students.ForeColor = System.Drawing.Color.White;
            this.Students.Location = new System.Drawing.Point(186, 15);
            this.Students.Name = "Students";
            this.Students.Size = new System.Drawing.Size(212, 31);
            this.Students.TabIndex = 2;
            this.Students.Text = "Project Advisor";
            // 
            // add
            // 
            this.add.Controls.Add(this.comboBox2);
            this.add.Controls.Add(this.comboBox3);
            this.add.Controls.Add(this.ProjectIdlabel);
            this.add.Controls.Add(this.AdvisorIdlabel);
            this.add.Controls.Add(this.comboBox1);
            this.add.Controls.Add(this.AdvisorRolelabel);
            this.add.Controls.Add(this.Save);
            this.add.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.add.Location = new System.Drawing.Point(140, 277);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(660, 173);
            this.add.TabIndex = 1;
            this.add.Paint += new System.Windows.Forms.PaintEventHandler(this.add_Paint);
            // 
            // comboBox2
            // 
            this.comboBox2.ForeColor = System.Drawing.Color.Black;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(288, 64);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 79;
            // 
            // comboBox3
            // 
            this.comboBox3.ForeColor = System.Drawing.Color.Black;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "Main Advisor",
            "Co-Advisror",
            "Industry Advisor"});
            this.comboBox3.Location = new System.Drawing.Point(288, 115);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 78;
            // 
            // ProjectIdlabel
            // 
            this.ProjectIdlabel.AutoSize = true;
            this.ProjectIdlabel.ForeColor = System.Drawing.Color.White;
            this.ProjectIdlabel.Location = new System.Drawing.Point(173, 72);
            this.ProjectIdlabel.Name = "ProjectIdlabel";
            this.ProjectIdlabel.Size = new System.Drawing.Size(52, 13);
            this.ProjectIdlabel.TabIndex = 77;
            this.ProjectIdlabel.Text = "Project Id";
            // 
            // AdvisorIdlabel
            // 
            this.AdvisorIdlabel.AutoSize = true;
            this.AdvisorIdlabel.ForeColor = System.Drawing.Color.White;
            this.AdvisorIdlabel.Location = new System.Drawing.Point(173, 18);
            this.AdvisorIdlabel.Name = "AdvisorIdlabel";
            this.AdvisorIdlabel.Size = new System.Drawing.Size(54, 13);
            this.AdvisorIdlabel.TabIndex = 76;
            this.AdvisorIdlabel.Text = "Advisor Id";
            // 
            // comboBox1
            // 
            this.comboBox1.ForeColor = System.Drawing.Color.Black;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(288, 10);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 75;
            // 
            // AdvisorRolelabel
            // 
            this.AdvisorRolelabel.AutoSize = true;
            this.AdvisorRolelabel.ForeColor = System.Drawing.Color.White;
            this.AdvisorRolelabel.Location = new System.Drawing.Point(173, 118);
            this.AdvisorRolelabel.Name = "AdvisorRolelabel";
            this.AdvisorRolelabel.Size = new System.Drawing.Size(67, 13);
            this.AdvisorRolelabel.TabIndex = 74;
            this.AdvisorRolelabel.Text = "Advisor Role";
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(233, 147);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 23);
            this.Save.TabIndex = 69;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(146, 65);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(539, 206);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            // 
            // ProjectAdvisor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.add);
            this.Controls.Add(this.panel1);
            this.Name = "ProjectAdvisor";
            this.Text = "ProjectAdvisor";
            this.Load += new System.EventHandler(this.ProjectAdvisor_Load);
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
        private System.Windows.Forms.Panel add;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Home;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button AddNew;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button Display;
        private System.Windows.Forms.Label Students;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label ProjectIdlabel;
        private System.Windows.Forms.Label AdvisorIdlabel;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label AdvisorRolelabel;
        private System.Windows.Forms.Button Save;
    }
}