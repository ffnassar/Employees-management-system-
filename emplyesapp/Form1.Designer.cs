namespace emplyesapp
{
    partial class Form1
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
            this.label5 = new System.Windows.Forms.Label();
            this.Signupbtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Exit = new System.Windows.Forms.Label();
            this.LoginAccount = new System.Windows.Forms.Label();
            this.Username = new System.Windows.Forms.Label();
            this.Login_Username = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.Label();
            this.Login_Password = new System.Windows.Forms.TextBox();
            this.Login_ShowPassword = new System.Windows.Forms.CheckBox();
            this.Loginbtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(55, 326);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Register Your Aaccount";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // Signupbtn
            // 
            this.Signupbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.Signupbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Signupbtn.FlatAppearance.BorderSize = 0;
            this.Signupbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Purple;
            this.Signupbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.Signupbtn.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Signupbtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Signupbtn.Location = new System.Drawing.Point(11, 354);
            this.Signupbtn.Name = "Signupbtn";
            this.Signupbtn.Size = new System.Drawing.Size(240, 33);
            this.Signupbtn.TabIndex = 10;
            this.Signupbtn.Text = "SIGNUP";
            this.Signupbtn.UseVisualStyleBackColor = false;
            this.Signupbtn.Click += new System.EventHandler(this.Signupbtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(30, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(191, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Emplyee Managment System";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(11)))), ((int)(((byte)(186)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.Signupbtn);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(256, 400);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::emplyesapp.Properties.Resources.emplyee_pic_1;
            this.pictureBox1.Location = new System.Drawing.Point(72, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
           
            // 
            // Exit
            // 
            this.Exit.AutoSize = true;
            this.Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exit.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.Location = new System.Drawing.Point(546, 9);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(17, 18);
            this.Exit.TabIndex = 1;
            this.Exit.Text = "X";
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // LoginAccount
            // 
            this.LoginAccount.AutoSize = true;
            this.LoginAccount.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginAccount.Location = new System.Drawing.Point(266, 56);
            this.LoginAccount.Name = "LoginAccount";
            this.LoginAccount.Size = new System.Drawing.Size(158, 24);
            this.LoginAccount.TabIndex = 2;
            this.LoginAccount.Text = "Login Account";
            this.LoginAccount.Click += new System.EventHandler(this.label2_Click);
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username.Location = new System.Drawing.Point(266, 136);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(91, 21);
            this.Username.TabIndex = 3;
            this.Username.Text = "Username:";
            // 
            // Login_Username
            // 
            this.Login_Username.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_Username.Location = new System.Drawing.Point(266, 161);
            this.Login_Username.Multiline = true;
            this.Login_Username.Name = "Login_Username";
            this.Login_Username.Size = new System.Drawing.Size(297, 30);
            this.Login_Username.TabIndex = 4;
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.Location = new System.Drawing.Point(266, 206);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(86, 21);
            this.Password.TabIndex = 5;
            this.Password.Text = "Password:";
            // 
            // Login_Password
            // 
            this.Login_Password.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_Password.Location = new System.Drawing.Point(266, 230);
            this.Login_Password.Multiline = true;
            this.Login_Password.Name = "Login_Password";
            this.Login_Password.PasswordChar = '*';
            this.Login_Password.Size = new System.Drawing.Size(297, 30);
            this.Login_Password.TabIndex = 6;
            // 
            // Login_ShowPassword
            // 
            this.Login_ShowPassword.AutoSize = true;
            this.Login_ShowPassword.Location = new System.Drawing.Point(461, 266);
            this.Login_ShowPassword.Name = "Login_ShowPassword";
            this.Login_ShowPassword.Size = new System.Drawing.Size(102, 17);
            this.Login_ShowPassword.TabIndex = 7;
            this.Login_ShowPassword.Text = "Show Password";
            this.Login_ShowPassword.UseVisualStyleBackColor = true;
            this.Login_ShowPassword.CheckedChanged += new System.EventHandler(this.Login_ShowPassword_CheckedChanged);
            // 
            // Loginbtn
            // 
            this.Loginbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.Loginbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Loginbtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.Loginbtn.FlatAppearance.BorderSize = 0;
            this.Loginbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.Loginbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.Loginbtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Loginbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Loginbtn.Location = new System.Drawing.Point(270, 318);
            this.Loginbtn.Name = "Loginbtn";
            this.Loginbtn.Size = new System.Drawing.Size(100, 40);
            this.Loginbtn.TabIndex = 8;
            this.Loginbtn.Text = "Login";
            this.Loginbtn.UseVisualStyleBackColor = false;
            this.Loginbtn.Click += new System.EventHandler(this.Loginbtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(575, 400);
            this.Controls.Add(this.Loginbtn);
            this.Controls.Add(this.Login_ShowPassword);
            this.Controls.Add(this.Login_Password);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Login_Username);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.LoginAccount);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Signupbtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Exit;
        private System.Windows.Forms.Label LoginAccount;
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.TextBox Login_Username;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.TextBox Login_Password;
        private System.Windows.Forms.CheckBox Login_ShowPassword;
        private System.Windows.Forms.Button Loginbtn;
    }
}

