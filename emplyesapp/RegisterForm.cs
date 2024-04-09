using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace emplyesapp
{
    public partial class RegisterForm : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Fady\OneDrive - Notre Dame University-Louaize\Documents\emplyee.mdf"";Integrated Security=True;Connect Timeout=30");
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void ExitRegister_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loginpbtn_Click(object sender, EventArgs e)
        {
            Form1 loginForm = new Form1();
            loginForm.Show();
            this.Hide();
        }

        private void SIGNEUP_showpassword_CheckedChanged(object sender, EventArgs e)
        {
            SIGNEUP_Password.PasswordChar = SIGNEUP_showpassword.Checked ? '\0' : '*';
        }

        private void SIGNUPbtn_Click(object sender, EventArgs e)
        {
            if (SIGNEUP_Username.Text == "" || SIGNEUP_Password.Text == "")
            {
                MessageBox.Show("Please fill all blank feilds", "Error Message",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                if (connect.State != ConnectionState.Open)
                {
                    try
                    {
                        connect.Open();

                        string selectUsername = "SELECT count(id) FROM users WHERE username =@user ";
                        using (SqlCommand CheckUser = new SqlCommand(selectUsername, connect))
                        {
                            CheckUser.Parameters.AddWithValue("@user", SIGNEUP_Username.Text.Trim());
                            int count = (int)CheckUser.ExecuteScalar();

                            if (count >= 1)
                            {
                                MessageBox.Show(SIGNEUP_Username.Text.Trim()+"is already taken", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            }
                            else
                            {
                                DateTime today = DateTime.Today;
                                string insertData = "INSERT INTO users" + "(username, password, date_register)" + "VALUES(@username, @password, @date_register)";
                                using (SqlCommand cmd = new SqlCommand(insertData, connect))
                                {
                                    cmd.Parameters.AddWithValue("@username", SIGNEUP_Username.Text.Trim());
                                    cmd.Parameters.AddWithValue("@password", SIGNEUP_Password.Text.Trim());
                                    cmd.Parameters.AddWithValue("@date_register", today);

                                    cmd.ExecuteNonQuery();

                                    MessageBox.Show("Registered successflly", "Info Mesaage", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    Form1 loginForm = new Form1();
                                    loginForm.Show();
                                    this.Hide();
                                }


                            }

                        }
                        
                        
                    }
                    catch (Exception ex )
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
        private void signup_showPass_CheckedChanged(object sender, EventArgs e)
        {
            SIGNEUP_Password.PasswordChar = SIGNEUP_showpassword.Checked ? '\0' : '*';
        }
    }
}
