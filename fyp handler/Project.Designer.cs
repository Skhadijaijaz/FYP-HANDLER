namespace fyp_handler
{
    partial class Project
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
            this.Home = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.AddNew = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.Display = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Projects = new System.Windows.Forms.Label();
            this.add = new System.Windows.Forms.Panel();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.Save = new System.Windows.Forms.Button();
            this.TitleText = new System.Windows.Forms.TextBox();
            this.Description = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.add.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(113, 444);
            this.panel1.TabIndex = 0;
            // 
            // Home
            // 
            this.Home.Location = new System.Drawing.Point(8, 89);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(96, 49);
            this.Home.TabIndex = 53;
            this.Home.Text = "Home";
            this.Home.UseVisualStyleBackColor = true;
            this.Home.Click += new System.EventHandler(this.Home_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(8, 296);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(96, 49);
            this.Delete.TabIndex = 52;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // AddNew
            // 
            this.AddNew.Location = new System.Drawing.Point(8, 154);
            this.AddNew.Name = "AddNew";
            this.AddNew.Size = new System.Drawing.Size(96, 49);
            this.AddNew.TabIndex = 51;
            this.AddNew.Text = "Add New";
            this.AddNew.UseVisualStyleBackColor = true;
            this.AddNew.Click += new System.EventHandler(this.AddNew_Click);
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(8, 224);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(96, 49);
            this.Update.TabIndex = 50;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // Display
            // 
            this.Display.Location = new System.Drawing.Point(8, 369);
            this.Display.Name = "Display";
            this.Display.Size = new System.Drawing.Size(96, 49);
            this.Display.TabIndex = 49;
            this.Display.Text = "Display";
            this.Display.UseVisualStyleBackColor = true;
            this.Display.Click += new System.EventHandler(this.Display_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Projects);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(113, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(687, 62);
            this.panel2.TabIndex = 1;
            // 
            // Projects
            // 
            this.Projects.AutoSize = true;
            this.Projects.BackColor = System.Drawing.SystemColors.ControlText;
            this.Projects.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Projects.ForeColor = System.Drawing.Color.White;
            this.Projects.Location = new System.Drawing.Point(250, 19);
            this.Projects.Name = "Projects";
            this.Projects.Size = new System.Drawing.Size(106, 31);
            this.Projects.TabIndex = 4;
            this.Projects.Text = "Project";
            // 
            // add
            // 
            this.add.Controls.Add(this.richTextBox);
            this.add.Controls.Add(this.Save);
            this.add.Controls.Add(this.TitleText);
            this.add.Controls.Add(this.Description);
            this.add.Controls.Add(this.Title);
            this.add.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.add.Location = new System.Drawing.Point(113, 276);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(687, 168);
            this.add.TabIndex = 2;
            // 
            // richTextBox
            // 
            this.richTextBox.Location = new System.Drawing.Point(405, 15);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(270, 104);
            this.richTextBox.TabIndex = 120;
            this.richTextBox.Text = "";
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(277, 133);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 23);
            this.Save.TabIndex = 118;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // TitleText
            // 
            this.TitleText.Location = new System.Drawing.Point(91, 54);
            this.TitleText.Name = "TitleText";
            this.TitleText.Size = new System.Drawing.Size(204, 20);
            this.TitleText.TabIndex = 119;
            // 
            // Description
            // 
            this.Description.AutoSize = true;
            this.Description.BackColor = System.Drawing.SystemColors.ControlText;
            this.Description.ForeColor = System.Drawing.Color.White;
            this.Description.Location = new System.Drawing.Point(328, 57);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(60, 13);
            this.Description.TabIndex = 117;
            this.Description.Text = "Description";
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.BackColor = System.Drawing.SystemColors.ControlText;
            this.Title.ForeColor = System.Drawing.Color.White;
            this.Title.Location = new System.Drawing.Point(27, 57);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(27, 13);
            this.Title.TabIndex = 115;
            this.Title.Text = "Title";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dataGridView1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(113, 62);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(687, 214);
            this.panel4.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(678, 202);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::fyp_handler.Properties.Resources.download__12_;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 54;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Project
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(800, 444);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.add);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Project";
            this.Text = "Project";
            this.Load += new System.EventHandler(this.Project_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.add.ResumeLayout(false);
            this.add.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel add;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.TextBox TitleText;
        private System.Windows.Forms.Label Description;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Button Home;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button AddNew;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button Display;
        private System.Windows.Forms.Label Projects;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}