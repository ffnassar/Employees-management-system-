using EmployeeManagementSystem;

namespace emplyesapp
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.signout_label = new System.Windows.Forms.Label();
            this.SIGNOUTbtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SALARYbtn = new System.Windows.Forms.Button();
            this.ADDEMPLYEEbtn = new System.Windows.Forms.Button();
            this.DASHBOARDBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.salary1 = new emplyesapp.Salary();
            this.addEmplyee1 = new emplyesapp.AddEmplyee();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dashboard1 = new emplyesapp.Dashboard();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1100, 30);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(4, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Employee Managment System";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(1073, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.panel2.Controls.Add(this.signout_label);
            this.panel2.Controls.Add(this.SIGNOUTbtn);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.SALARYbtn);
            this.panel2.Controls.Add(this.ADDEMPLYEEbtn);
            this.panel2.Controls.Add(this.DASHBOARDBtn);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(0, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(250, 570);
            this.panel2.TabIndex = 1;
            // 
            // signout_label
            // 
            this.signout_label.AutoSize = true;
            this.signout_label.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signout_label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.signout_label.Location = new System.Drawing.Point(58, 527);
            this.signout_label.Name = "signout_label";
            this.signout_label.Size = new System.Drawing.Size(58, 20);
            this.signout_label.TabIndex = 6;
            this.signout_label.Text = "Sign out";
            // 
            // SIGNOUTbtn
            // 
            this.SIGNOUTbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.SIGNOUTbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SIGNOUTbtn.FlatAppearance.BorderSize = 0;
            this.SIGNOUTbtn.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.SIGNOUTbtn.Image = ((System.Drawing.Image)(resources.GetObject("SIGNOUTbtn.Image")));
            this.SIGNOUTbtn.Location = new System.Drawing.Point(12, 518);
            this.SIGNOUTbtn.Name = "SIGNOUTbtn";
            this.SIGNOUTbtn.Size = new System.Drawing.Size(40, 40);
            this.SIGNOUTbtn.TabIndex = 2;
            this.SIGNOUTbtn.UseVisualStyleBackColor = false;
            this.SIGNOUTbtn.Click += new System.EventHandler(this.SIGNOUTbtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(75, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // SALARYbtn
            // 
            this.SALARYbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.SALARYbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SALARYbtn.FlatAppearance.BorderSize = 0;
            this.SALARYbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.SALARYbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.SALARYbtn.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SALARYbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SALARYbtn.Image = ((System.Drawing.Image)(resources.GetObject("SALARYbtn.Image")));
            this.SALARYbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SALARYbtn.Location = new System.Drawing.Point(25, 380);
            this.SALARYbtn.Name = "SALARYbtn";
            this.SALARYbtn.Size = new System.Drawing.Size(200, 40);
            this.SALARYbtn.TabIndex = 4;
            this.SALARYbtn.Text = "SALARY";
            this.SALARYbtn.UseVisualStyleBackColor = false;
            this.SALARYbtn.Click += new System.EventHandler(this.SALARYbtn_Click);
            // 
            // ADDEMPLYEEbtn
            // 
            this.ADDEMPLYEEbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.ADDEMPLYEEbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ADDEMPLYEEbtn.FlatAppearance.BorderSize = 0;
            this.ADDEMPLYEEbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.ADDEMPLYEEbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.ADDEMPLYEEbtn.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ADDEMPLYEEbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ADDEMPLYEEbtn.Image = ((System.Drawing.Image)(resources.GetObject("ADDEMPLYEEbtn.Image")));
            this.ADDEMPLYEEbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ADDEMPLYEEbtn.Location = new System.Drawing.Point(25, 303);
            this.ADDEMPLYEEbtn.Name = "ADDEMPLYEEbtn";
            this.ADDEMPLYEEbtn.Size = new System.Drawing.Size(200, 40);
            this.ADDEMPLYEEbtn.TabIndex = 3;
            this.ADDEMPLYEEbtn.Text = "ADD EMPLYEE";
            this.ADDEMPLYEEbtn.UseVisualStyleBackColor = false;
            this.ADDEMPLYEEbtn.Click += new System.EventHandler(this.ADDEMPLYEEbtn_Click);
            // 
            // DASHBOARDBtn
            // 
            this.DASHBOARDBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.DASHBOARDBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DASHBOARDBtn.FlatAppearance.BorderSize = 0;
            this.DASHBOARDBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.DASHBOARDBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.DASHBOARDBtn.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DASHBOARDBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DASHBOARDBtn.Image = ((System.Drawing.Image)(resources.GetObject("DASHBOARDBtn.Image")));
            this.DASHBOARDBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DASHBOARDBtn.Location = new System.Drawing.Point(25, 220);
            this.DASHBOARDBtn.Name = "DASHBOARDBtn";
            this.DASHBOARDBtn.Size = new System.Drawing.Size(200, 40);
            this.DASHBOARDBtn.TabIndex = 2;
            this.DASHBOARDBtn.Text = "DASHBOARD";
            this.DASHBOARDBtn.UseVisualStyleBackColor = false;
            this.DASHBOARDBtn.Click += new System.EventHandler(this.DASHBOARDBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(75, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Welcome, User";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dashboard1);
            this.panel3.Controls.Add(this.salary1);
            this.panel3.Controls.Add(this.addEmplyee1);
            this.panel3.Location = new System.Drawing.Point(247, 30);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(853, 570);
            this.panel3.TabIndex = 2;
            // 
            // salary1
            // 
            this.salary1.Location = new System.Drawing.Point(0, -2);
            this.salary1.Name = "salary1";
            this.salary1.Size = new System.Drawing.Size(853, 572);
            this.salary1.TabIndex = 3;
            this.salary1.Load += new System.EventHandler(this.salary1_Load);
            // 
            // addEmplyee1
            // 
            this.addEmplyee1.Location = new System.Drawing.Point(0, 0);
            this.addEmplyee1.Name = "addEmplyee1";
            this.addEmplyee1.Size = new System.Drawing.Size(853, 570);
            this.addEmplyee1.TabIndex = 1;
            // 
            // dashboard1
            // 
            this.dashboard1.Location = new System.Drawing.Point(0, -2);
            this.dashboard1.Name = "dashboard1";
            this.dashboard1.Size = new System.Drawing.Size(853, 572);
            this.dashboard1.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 600);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button DASHBOARDBtn;
        private System.Windows.Forms.Button SALARYbtn;
        private System.Windows.Forms.Button ADDEMPLYEEbtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button SIGNOUTbtn;
        private System.Windows.Forms.Label signout_label;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.BindingSource bindingSource1;
      
        private AddEmplyee addEmplyee1;
       
        private Salary salary1;
        private Dashboard dashboard1;
    }
}