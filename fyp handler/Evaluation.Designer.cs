namespace fyp_handler
{
    partial class Evaluation
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
            this.add = new System.Windows.Forms.Panel();
            this.numeric2 = new System.Windows.Forms.NumericUpDown();
            this.numeric1 = new System.Windows.Forms.NumericUpDown();
            this.Save = new System.Windows.Forms.Button();
            this.NText = new System.Windows.Forms.TextBox();
            this.TotalMarks = new System.Windows.Forms.Label();
            this.TotalWeightage = new System.Windows.Forms.Label();
            this.Name = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lab = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Display = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.AddNew = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Home = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.add.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // add
            // 
            this.add.Controls.Add(this.numeric2);
            this.add.Controls.Add(this.numeric1);
            this.add.Controls.Add(this.Save);
            this.add.Controls.Add(this.NText);
            this.add.Controls.Add(this.TotalMarks);
            this.add.Controls.Add(this.TotalWeightage);
            this.add.Controls.Add(this.Name);
            this.add.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.add.Location = new System.Drawing.Point(103, 290);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(697, 160);
            this.add.TabIndex = 2;
            // 
            // numeric2
            // 
            this.numeric2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numeric2.Location = new System.Drawing.Point(284, 105);
            this.numeric2.Name = "numeric2";
            this.numeric2.Size = new System.Drawing.Size(192, 20);
            this.numeric2.TabIndex = 114;
            // 
            // numeric1
            // 
            this.numeric1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numeric1.Location = new System.Drawing.Point(284, 60);
            this.numeric1.Name = "numeric1";
            this.numeric1.Size = new System.Drawing.Size(192, 20);
            this.numeric1.TabIndex = 113;
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(251, 137);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 23);
            this.Save.TabIndex = 69;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // NText
            // 
            this.NText.Location = new System.Drawing.Point(284, 19);
            this.NText.Name = "NText";
            this.NText.Size = new System.Drawing.Size(192, 20);
            this.NText.TabIndex = 74;
            // 
            // TotalMarks
            // 
            this.TotalMarks.AutoSize = true;
            this.TotalMarks.BackColor = System.Drawing.SystemColors.ControlText;
            this.TotalMarks.ForeColor = System.Drawing.Color.White;
            this.TotalMarks.Location = new System.Drawing.Point(163, 67);
            this.TotalMarks.Name = "TotalMarks";
            this.TotalMarks.Size = new System.Drawing.Size(63, 13);
            this.TotalMarks.TabIndex = 67;
            this.TotalMarks.Text = "Total Marks";
            // 
            // TotalWeightage
            // 
            this.TotalWeightage.AutoSize = true;
            this.TotalWeightage.ForeColor = System.Drawing.Color.White;
            this.TotalWeightage.Location = new System.Drawing.Point(163, 110);
            this.TotalWeightage.Name = "TotalWeightage";
            this.TotalWeightage.Size = new System.Drawing.Size(83, 13);
            this.TotalWeightage.TabIndex = 65;
            this.TotalWeightage.Text = "TotalWeightage";
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.BackColor = System.Drawing.SystemColors.ControlText;
            this.Name.ForeColor = System.Drawing.Color.White;
            this.Name.Location = new System.Drawing.Point(163, 27);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(35, 13);
            this.Name.TabIndex = 64;
            this.Name.Text = "Name";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lab);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(697, 57);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lab
            // 
            this.lab.AutoSize = true;
            this.lab.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab.ForeColor = System.Drawing.Color.White;
            this.lab.Location = new System.Drawing.Point(245, 9);
            this.lab.Name = "lab";
            this.lab.Size = new System.Drawing.Size(151, 31);
            this.lab.TabIndex = 0;
            this.lab.Text = "Evaluation";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 63);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(679, 221);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(103, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(697, 290);
            this.panel3.TabIndex = 3;
            // 
            // Display
            // 
            this.Display.Location = new System.Drawing.Point(3, 317);
            this.Display.Name = "Display";
            this.Display.Size = new System.Drawing.Size(96, 49);
            this.Display.TabIndex = 44;
            this.Display.Text = "Display";
            this.Display.UseVisualStyleBackColor = true;
            this.Display.Click += new System.EventHandler(this.Display_Click);
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(3, 262);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(96, 49);
            this.Update.TabIndex = 45;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // AddNew
            // 
            this.AddNew.Location = new System.Drawing.Point(3, 207);
            this.AddNew.Name = "AddNew";
            this.AddNew.Size = new System.Drawing.Size(96, 49);
            this.AddNew.TabIndex = 46;
            this.AddNew.Text = "Add New";
            this.AddNew.UseVisualStyleBackColor = true;
            this.AddNew.Click += new System.EventHandler(this.AddNew_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(3, 152);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(96, 49);
            this.Delete.TabIndex = 47;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Home
            // 
            this.Home.Location = new System.Drawing.Point(3, 97);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(96, 49);
            this.Home.TabIndex = 48;
            this.Home.Text = "Home";
            this.Home.UseVisualStyleBackColor = true;
            this.Home.Click += new System.EventHandler(this.Home_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.panel2);
            this.flowLayoutPanel1.Controls.Add(this.Home);
            this.flowLayoutPanel1.Controls.Add(this.Delete);
            this.flowLayoutPanel1.Controls.Add(this.AddNew);
            this.flowLayoutPanel1.Controls.Add(this.Update);
            this.flowLayoutPanel1.Controls.Add(this.Display);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(103, 450);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(100, 88);
            this.panel2.TabIndex = 49;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::fyp_handler.Properties.Resources.download__12_;
            this.pictureBox1.Location = new System.Drawing.Point(9, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Evaluation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.add);
            this.Controls.Add(this.flowLayoutPanel1);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Evaluation_Load);
            this.add.ResumeLayout(false);
            this.add.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel add;
        private System.Windows.Forms.NumericUpDown numeric2;
        private System.Windows.Forms.NumericUpDown numeric1;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.TextBox NText;
        private System.Windows.Forms.Label TotalMarks;
        private System.Windows.Forms.Label TotalWeightage;
        private System.Windows.Forms.Label Name;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lab;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button Display;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button AddNew;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Home;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}