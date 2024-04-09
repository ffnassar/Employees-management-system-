using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace emplyesapp
{
    public partial class Form1 : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Fady\OneDrive - Notre Dame University-Louaize\Documents\emplyee.mdf"";Integrated Security=True;Connect Timeout=30");
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Signupbtn_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
            this.Hide();
        }

        private void Login_ShowPassword_CheckedChanged(object sender, EventArgs e)
        {

            Login_Password.PasswordChar = Login_ShowPassword.Checked ? '\0' : '*';

        }

        private void Loginbtn_Click(object sender, EventArgs e)
        {
            if (Login_Username.Text == "" || Login_Password.Text == "")
            {
                MessageBox.Show("Please fill all blank feilds", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
            else
            {
                if (connect.State == ConnectionState.Closed)
                {
                    try
                    {
                        connect.Open();
                        string SelectData = "SELECT * FROM users WHERE username = @username" + " AND password = @password";
                        using (SqlCommand cmd = new SqlCommand(SelectData, connect))
                        {
                            cmd.Parameters.AddWithValue("@username", Login_Username.Text.Trim());
                            cmd.Parameters.AddWithValue("@password", Login_Password.Text.Trim());

                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            if (table.Rows.Count >= 1)
                            {
                                MessageBox.Show("Login successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                MainForm mainForm = new MainForm();
                                mainForm.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Incorrect Username/Password"
                                    , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }


                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error" + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            }

        }

       
    }
}
