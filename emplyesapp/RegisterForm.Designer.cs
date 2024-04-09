namespace emplyesapp
{
    partial class RegisterForm
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
            this.Login_ShowPassword = new System.Windows.Forms.CheckBox();
            this.Exit = new System.Windows.Forms.Label();
            this.SIGNIPbtn = new System.Windows.Forms.Button();
            this.SIGNEUP_showpassword = new System.Windows.Forms.CheckBox();
            this.SIGNEUP_Password = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.Label();
            this.SIGNEUP_Username = new System.Windows.Forms.TextBox();
            this.Username = new System.Windows.Forms.Label();
            this.RegisterAccount = new System.Windows.Forms.Label();
            this.ExitRegister = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.loginpbtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Login_ShowPassword
            // 
            this.Login_ShowPassword.AutoSize = true;
            this.Login_ShowPassword.Location = new System.Drawing.Point(580, 266);
            this.Login_ShowPassword.Name = "Login_ShowPassword";
            this.Login_ShowPassword.Size = new System.Drawing.Size(102, 17);
            this.Login_ShowPassword.TabIndex = 16;
            this.Login_ShowPassword.Text = "Show Password";
            this.Login_ShowPassword.UseVisualStyleBackColor = true;
            // 
            // Exit
            // 
            this.Exit.AutoSize = true;
            this.Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exit.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.Location = new System.Drawing.Point(665, 9);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(17, 18);
            this.Exit.TabIndex = 10;
            this.Exit.Text = "X";
            // 
            // SIGNIPbtn
            // 
            this.SIGNIPbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.SIGNIPbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SIGNIPbtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.SIGNIPbtn.FlatAppearance.BorderSize = 0;
            this.SIGNIPbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.SIGNIPbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.SIGNIPbtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SIGNIPbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SIGNIPbtn.Location = new System.Drawing.Point(270, 320);
            this.SIGNIPbtn.Name = "SIGNIPbtn";
            this.SIGNIPbtn.Size = new System.Drawing.Size(100, 40);
            this.SIGNIPbtn.TabIndex = 25;
            this.SIGNIPbtn.Text = "SIGNUP";
            this.SIGNIPbtn.UseVisualStyleBackColor = false;
            this.SIGNIPbtn.Click += new System.EventHandler(this.SIGNUPbtn_Click);
            // 
            // SIGNEUP_showpassword
            // 
            this.SIGNEUP_showpassword.AutoSize = true;
            this.SIGNEUP_showpassword.Location = new System.Drawing.Point(459, 266);
            this.SIGNEUP_showpassword.Name = "SIGNEUP_showpassword";
            this.SIGNEUP_showpassword.Size = new System.Drawing.Size(102, 17);
            this.SIGNEUP_showpassword.TabIndex = 24;
            this.SIGNEUP_showpassword.Text = "Show Password";
            this.SIGNEUP_showpassword.UseVisualStyleBackColor = true;
            this.SIGNEUP_showpassword.CheckedChanged += new System.EventHandler(this.SIGNEUP_showpassword_CheckedChanged);
            // 
            // SIGNEUP_Password
            // 
            this.SIGNEUP_Password.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SIGNEUP_Password.Location = new System.Drawing.Point(264, 230);
            this.SIGNEUP_Password.Multiline = true;
            this.SIGNEUP_Password.Name = "SIGNEUP_Password";
            this.SIGNEUP_Password.PasswordChar = '*';
            this.SIGNEUP_Password.Size = new System.Drawing.Size(297, 30);
            this.SIGNEUP_Password.TabIndex = 23;
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.Location = new System.Drawing.Point(264, 206);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(86, 21);
            this.Password.TabIndex = 22;
            this.Password.Text = "Password:";
            // 
            // SIGNEUP_Username
            // 
            this.SIGNEUP_Username.Location = new System.Drawing.Point(264, 161);
            this.SIGNEUP_Username.Multiline = true;
            this.SIGNEUP_Username.Name = "SIGNEUP_Username";
            this.SIGNEUP_Username.Size = new System.Drawing.Size(297, 30);
            this.SIGNEUP_Username.TabIndex = 21;
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username.Location = new System.Drawing.Point(264, 136);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(91, 21);
            this.Username.TabIndex = 20;
            this.Username.Text = "Username:";
            // 
            // RegisterAccount
            // 
            this.RegisterAccount.AutoSize = true;
            this.RegisterAccount.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterAccount.Location = new System.Drawing.Point(264, 56);
            this.RegisterAccount.Name = "RegisterAccount";
            this.RegisterAccount.Size = new System.Drawing.Size(185, 24);
            this.RegisterAccount.TabIndex = 19;
            this.RegisterAccount.Text = "Register Account";
            // 
            // ExitRegister
            // 
            this.ExitRegister.AutoSize = true;
            this.ExitRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitRegister.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitRegister.Location = new System.Drawing.Point(544, 9);
            this.ExitRegister.Name = "ExitRegister";
            this.ExitRegister.Size = new System.Drawing.Size(17, 18);
            this.ExitRegister.TabIndex = 18;
            this.ExitRegister.Text = "X";
            this.ExitRegister.Click += new System.EventHandler(this.ExitRegister_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(11)))), ((int)(((byte)(186)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.loginpbtn);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(256, 400);
            this.panel1.TabIndex = 17;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::emplyesapp.Properties.Resources.emplyee_pic_1;
            this.pictureBox1.Location = new System.Drawing.Point(78, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
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
            // 
            // loginpbtn
            // 
            this.loginpbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.loginpbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginpbtn.FlatAppearance.BorderSize = 0;
            this.loginpbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Purple;
            this.loginpbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.loginpbtn.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginpbtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.loginpbtn.Location = new System.Drawing.Point(11, 354);
            this.loginpbtn.Name = "loginpbtn";
            this.loginpbtn.Size = new System.Drawing.Size(240, 33);
            this.loginpbtn.TabIndex = 10;
            this.loginpbtn.Text = "LOGIN";
            this.loginpbtn.UseVisualStyleBackColor = false;
            this.loginpbtn.Click += new System.EventHandler(this.loginpbtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(55, 326);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Login Your Aaccount";
            // 
            // RegisterForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(575, 400);
            this.Controls.Add(this.SIGNIPbtn);
            this.Controls.Add(this.SIGNEUP_showpassword);
            this.Controls.Add(this.SIGNEUP_Password);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.SIGNEUP_Username);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.RegisterAccount);
            this.Controls.Add(this.ExitRegister);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Login_ShowPassword);
            this.Controls.Add(this.Exit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox Login_ShowPassword;
        private System.Windows.Forms.Label Exit;
        private System.Windows.Forms.Button SIGNIPbtn;
        private System.Windows.Forms.CheckBox SIGNEUP_showpassword;
        private System.Windows.Forms.TextBox SIGNEUP_Password;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.TextBox SIGNEUP_Username;
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.Label RegisterAccount;
        private System.Windows.Forms.Label ExitRegister;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button loginpbtn;
        private System.Windows.Forms.Label label5;
    }
}