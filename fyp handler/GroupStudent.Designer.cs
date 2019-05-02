namespace fyp_handler
{
    partial class GroupStudent
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Home = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.AddNew = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.Display = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Panel();
            this.Savebutton = new System.Windows.Forms.Button();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.StudentIdlabel = new System.Windows.Forms.Label();
            this.GroupIdlabel = new System.Windows.Forms.Label();
            this.Statuslabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Students = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.add.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.pictureBox1);
            this.flowLayoutPanel1.Controls.Add(this.Home);
            this.flowLayoutPanel1.Controls.Add(this.Delete);
            this.flowLayoutPanel1.Controls.Add(this.AddNew);
            this.flowLayoutPanel1.Controls.Add(this.Update);
            this.flowLayoutPanel1.Controls.Add(this.Display);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(150, 450);
            this.flowLayoutPanel1.TabIndex = 0;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::fyp_handler.Properties.Resources.download__12_;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 61;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Home
            // 
            this.Home.Location = new System.Drawing.Point(3, 73);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(96, 49);
            this.Home.TabIndex = 60;
            this.Home.Text = "Home";
            this.Home.UseVisualStyleBackColor = true;
            this.Home.Click += new System.EventHandler(this.Home_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(3, 128);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(96, 49);
            this.Delete.TabIndex = 59;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // AddNew
            // 
            this.AddNew.Location = new System.Drawing.Point(3, 183);
            this.AddNew.Name = "AddNew";
            this.AddNew.Size = new System.Drawing.Size(96, 49);
            this.AddNew.TabIndex = 58;
            this.AddNew.Text = "Add New";
            this.AddNew.UseVisualStyleBackColor = true;
            this.AddNew.Click += new System.EventHandler(this.AddNew_Click);
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(3, 238);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(96, 49);
            this.Update.TabIndex = 57;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // Display
            // 
            this.Display.Location = new System.Drawing.Point(3, 293);
            this.Display.Name = "Display";
            this.Display.Size = new System.Drawing.Size(96, 49);
            this.Display.TabIndex = 56;
            this.Display.Text = "Display";
            this.Display.UseVisualStyleBackColor = true;
            this.Display.Click += new System.EventHandler(this.Display_Click);
            // 
            // add
            // 
            this.add.Controls.Add(this.Savebutton);
            this.add.Controls.Add(this.comboBox3);
            this.add.Controls.Add(this.comboBox2);
            this.add.Controls.Add(this.comboBox1);
            this.add.Controls.Add(this.StudentIdlabel);
            this.add.Controls.Add(this.GroupIdlabel);
            this.add.Controls.Add(this.Statuslabel);
            this.add.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.add.Location = new System.Drawing.Point(150, 296);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(650, 154);
            this.add.TabIndex = 1;
            this.add.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Savebutton
            // 
            this.Savebutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.Savebutton.Location = new System.Drawing.Point(448, 102);
            this.Savebutton.Name = "Savebutton";
            this.Savebutton.Size = new System.Drawing.Size(90, 37);
            this.Savebutton.TabIndex = 41;
            this.Savebutton.Text = "Save";
            this.Savebutton.UseVisualStyleBackColor = false;
            this.Savebutton.Click += new System.EventHandler(this.Savebutton_Click);
            // 
            // comboBox3
            // 
            this.comboBox3.ForeColor = System.Drawing.Color.Black;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "Active",
            "InActive"});
            this.comboBox3.Location = new System.Drawing.Point(283, 94);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 38;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.ForeColor = System.Drawing.Color.Black;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(283, 63);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 37;
            // 
            // comboBox1
            // 
            this.comboBox1.ForeColor = System.Drawing.Color.Black;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(283, 30);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 36;
            // 
            // StudentIdlabel
            // 
            this.StudentIdlabel.AutoSize = true;
            this.StudentIdlabel.ForeColor = System.Drawing.Color.White;
            this.StudentIdlabel.Location = new System.Drawing.Point(126, 71);
            this.StudentIdlabel.Name = "StudentIdlabel";
            this.StudentIdlabel.Size = new System.Drawing.Size(56, 13);
            this.StudentIdlabel.TabIndex = 35;
            this.StudentIdlabel.Text = "Student Id";
            // 
            // GroupIdlabel
            // 
            this.GroupIdlabel.AutoSize = true;
            this.GroupIdlabel.ForeColor = System.Drawing.Color.White;
            this.GroupIdlabel.Location = new System.Drawing.Point(126, 33);
            this.GroupIdlabel.Name = "GroupIdlabel";
            this.GroupIdlabel.Size = new System.Drawing.Size(48, 13);
            this.GroupIdlabel.TabIndex = 34;
            this.GroupIdlabel.Text = "Group Id";
            // 
            // Statuslabel
            // 
            this.Statuslabel.AutoSize = true;
            this.Statuslabel.ForeColor = System.Drawing.Color.White;
            this.Statuslabel.Location = new System.Drawing.Point(126, 102);
            this.Statuslabel.Name = "Statuslabel";
            this.Statuslabel.Size = new System.Drawing.Size(37, 13);
            this.Statuslabel.TabIndex = 33;
            this.Statuslabel.Text = "Status";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Students);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(150, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(650, 71);
            this.panel2.TabIndex = 2;
            // 
            // Students
            // 
            this.Students.AutoSize = true;
            this.Students.BackColor = System.Drawing.SystemColors.ControlText;
            this.Students.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Students.ForeColor = System.Drawing.Color.White;
            this.Students.Location = new System.Drawing.Point(197, 25);
            this.Students.Name = "Students";
            this.Students.Size = new System.Drawing.Size(210, 31);
            this.Students.TabIndex = 8;
            this.Students.Text = "GroupStudents";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(166, 84);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(539, 206);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            // 
            // GroupStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.add);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "GroupStudent";
            this.Text = "GroupStudent";
            this.Load += new System.EventHandler(this.GroupStudent_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.add.ResumeLayout(false);
            this.add.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel add;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label StudentIdlabel;
        private System.Windows.Forms.Label GroupIdlabel;
        private System.Windows.Forms.Label Statuslabel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Home;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button AddNew;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button Display;
        private System.Windows.Forms.Label Students;
        private System.Windows.Forms.Button Savebutton;
    }
}