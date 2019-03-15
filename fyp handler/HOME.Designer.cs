namespace fyp_handler
{
    partial class WELCOME1
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
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.Students = new System.Windows.Forms.Button();
            this.Projects = new System.Windows.Forms.Button();
            this.Advisors = new System.Windows.Forms.Button();
            this.Evaluation = new System.Windows.Forms.Button();
            this.Home = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 53);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mistral", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(243, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(273, 33);
            this.label2.TabIndex = 8;
            this.label2.Text = "FYP MANAGEMENT SYSTEM";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlText;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 426);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 24);
            this.panel2.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(292, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(216, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Copyright © 2019 ski Inc. All rights reserved.";
            // 
            // Students
            // 
            this.Students.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Students.BackColor = System.Drawing.SystemColors.ControlText;
            this.Students.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Students.ForeColor = System.Drawing.Color.White;
            this.Students.Location = new System.Drawing.Point(3, 74);
            this.Students.Name = "Students";
            this.Students.Size = new System.Drawing.Size(132, 64);
            this.Students.TabIndex = 6;
            this.Students.Text = "Students";
            this.Students.UseVisualStyleBackColor = false;
            this.Students.Click += new System.EventHandler(this.Students_Click);
            // 
            // Projects
            // 
            this.Projects.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Projects.BackColor = System.Drawing.SystemColors.ControlText;
            this.Projects.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Projects.ForeColor = System.Drawing.Color.White;
            this.Projects.Location = new System.Drawing.Point(3, 144);
            this.Projects.Name = "Projects";
            this.Projects.Size = new System.Drawing.Size(132, 65);
            this.Projects.TabIndex = 7;
            this.Projects.Text = "Projects";
            this.Projects.UseVisualStyleBackColor = false;
            this.Projects.Click += new System.EventHandler(this.Projects_Click);
            // 
            // Advisors
            // 
            this.Advisors.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Advisors.BackColor = System.Drawing.SystemColors.ControlText;
            this.Advisors.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Advisors.ForeColor = System.Drawing.Color.White;
            this.Advisors.Location = new System.Drawing.Point(3, 215);
            this.Advisors.Name = "Advisors";
            this.Advisors.Size = new System.Drawing.Size(132, 61);
            this.Advisors.TabIndex = 8;
            this.Advisors.Text = "Advisors";
            this.Advisors.UseVisualStyleBackColor = false;
            this.Advisors.Click += new System.EventHandler(this.Advisors_Click);
            // 
            // Evaluation
            // 
            this.Evaluation.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Evaluation.BackColor = System.Drawing.SystemColors.ControlText;
            this.Evaluation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Evaluation.ForeColor = System.Drawing.Color.White;
            this.Evaluation.Location = new System.Drawing.Point(3, 282);
            this.Evaluation.Name = "Evaluation";
            this.Evaluation.Size = new System.Drawing.Size(132, 63);
            this.Evaluation.TabIndex = 9;
            this.Evaluation.Text = "Evaluation";
            this.Evaluation.UseVisualStyleBackColor = false;
            this.Evaluation.Click += new System.EventHandler(this.Evaluation_Click);
            // 
            // Home
            // 
            this.Home.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Home.BackColor = System.Drawing.SystemColors.ControlText;
            this.Home.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Home.ForeColor = System.Drawing.Color.White;
            this.Home.Location = new System.Drawing.Point(3, 3);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(132, 65);
            this.Home.TabIndex = 11;
            this.Home.Text = "Home";
            this.Home.UseVisualStyleBackColor = false;
            this.Home.Click += new System.EventHandler(this.Home_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(348, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 12;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.Home);
            this.flowLayoutPanel1.Controls.Add(this.Students);
            this.flowLayoutPanel1.Controls.Add(this.Projects);
            this.flowLayoutPanel1.Controls.Add(this.Advisors);
            this.flowLayoutPanel1.Controls.Add(this.Evaluation);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 53);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(146, 373);
            this.flowLayoutPanel1.TabIndex = 13;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::fyp_handler.Properties.Resources.artificial_intelligence_3382507__340;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(146, 53);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(654, 373);
            this.panel3.TabIndex = 14;
            // 
            // WELCOME1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WELCOME1";
            this.Text = "Home";
            this.TransparencyKey = System.Drawing.SystemColors.Control;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Students;
        private System.Windows.Forms.Button Projects;
        private System.Windows.Forms.Button Advisors;
        private System.Windows.Forms.Button Evaluation;
        private System.Windows.Forms.Button Home;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel3;
    }
}