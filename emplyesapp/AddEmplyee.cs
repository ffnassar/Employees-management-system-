using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace emplyesapp
{
    public partial class AddEmplyee : UserControl
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Fady\OneDrive - Notre Dame University-Louaize\Documents\emplyee.mdf"";Integrated Security=True;Connect Timeout=30");

        public AddEmplyee()
        {
            InitializeComponent();
            displayEmployeeData();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public void RefreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)RefreshData);
                return;
            }
            displayEmployeeData();
        }

        public void displayEmployeeData()
        {
            EmployeeData ed = new EmployeeData();
            List<EmployeeData> listData = ed.employeesListData();

            dataGridView1.DataSource = listData;
        }

        private void addEmplyeeAddbtn_Click(object sender, EventArgs e)
        {
            if (addEmplyeeEmployeeIDTextBox.Text == ""
                || addEmplyeeFullNamTextBox.Text == ""
                || addEmplyeeGenderComboBox.Text == ""
                || addEmplyeePhoneNumberTextBox.Text == ""
                || addEmplyeePositionComboBox.Text == ""
                || addEmplyeeStatusComboBox.Text == ""
                || addEmplyeePic.Image == null)
            {
                MessageBox.Show("Please fill all blank fields"
                    , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connect.State == ConnectionState.Closed)
                {
                    try
                    {
                        connect.Open();
                        string checkEmID = "SELECT COUNT(*) FROM employees WHERE employee_id = @emID AND delete_date IS NULL";

                        using (SqlCommand checkEm = new SqlCommand(checkEmID, connect))
                        {
                            checkEm.Parameters.AddWithValue("@emID", addEmplyeeEmployeeIDTextBox.Text.Trim());
                            int count = (int)checkEm.ExecuteScalar();

                            if (count >= 1)
                            {
                                MessageBox.Show(addEmplyeeEmployeeIDTextBox.Text.Trim() + " is already taken"
                                    , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                DateTime today = DateTime.Today;
                                string insertData = "INSERT INTO employees " +
                                    "(employee_id, full_name, gender, contact_number" +
                                    ", position, image, salary, insert_date, status) " +
                                    "VALUES(@employeeID, @fullName, @gender, @contactNum" +
                                    ", @position, @image, @salary, @insertDate, @status)";

                                string path = Path.Combine(@"F:\\visual studio\\emplyesapp\\emplyesapp\\Assets\\Directory\\"
                                    + addEmplyeeEmployeeIDTextBox.Text.Trim() + ".jpg");

                                string directoryPath = Path.GetDirectoryName(path);

                                if (!Directory.Exists(directoryPath))
                                {
                                    Directory.CreateDirectory(directoryPath);
                                }

                                File.Copy(addEmplyeePic.ImageLocation, path, true);

                                using (SqlCommand cmd = new SqlCommand(insertData, connect))
                                {
                                    cmd.Parameters.AddWithValue("@employeeID", addEmplyeeEmployeeIDTextBox.Text.Trim());
                                    cmd.Parameters.AddWithValue("@fullName", addEmplyeeFullNamTextBox.Text.Trim());
                                    cmd.Parameters.AddWithValue("@gender", addEmplyeeGenderComboBox.Text.Trim());
                                    cmd.Parameters.AddWithValue("@contactNum", addEmplyeePhoneNumberTextBox.Text.Trim());
                                    cmd.Parameters.AddWithValue("@position", addEmplyeePositionComboBox.Text.Trim());
                                    cmd.Parameters.AddWithValue("@image", path);
                                    cmd.Parameters.AddWithValue("@salary", 0);
                                    cmd.Parameters.AddWithValue("@insertDate", today);
                                    cmd.Parameters.AddWithValue("@status", addEmplyeeStatusComboBox.Text.Trim());

                                    cmd.ExecuteNonQuery();

                                    displayEmployeeData();

                                    MessageBox.Show("Added successfully!"
                                        , "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    clearFields();
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex
                    , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            }
        
        }

        private void addEmplyeeImportbtn_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Image Files (*.jpg; *.png)|*.jpg;*.png";
                string imagePath = "";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    imagePath = dialog.FileName;
                    addEmplyeePic.ImageLocation = imagePath;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex, "Error Message"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       

        public void clearFields()
        {
            addEmplyeeEmployeeIDTextBox.Text = "";
            addEmplyeeFullNamTextBox.Text = "";
            addEmplyeeGenderComboBox.SelectedIndex = -1;
            addEmplyeePhoneNumberTextBox.Text = "";
            addEmplyeePositionComboBox.SelectedIndex = -1;
            addEmplyeeStatusComboBox.SelectedIndex = -1;
            addEmplyeePic.Image = null;

        }
        private void addEmplyeepdatebtn_Click(object sender, EventArgs e)
        {
            if (addEmplyeeEmployeeIDTextBox.Text == ""
                || addEmplyeeFullNamTextBox.Text == ""
                || addEmplyeeGenderComboBox.Text == ""
                || addEmplyeePhoneNumberTextBox.Text == ""
                || addEmplyeePositionComboBox.Text == ""
                || addEmplyeeStatusComboBox.Text == ""
                )
            {
                MessageBox.Show("Please fill all blank fields"
                    , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult check = MessageBox.Show("Are you sure you want to UPDATE " +
                    "Employee ID: " + addEmplyeeEmployeeIDTextBox.Text.Trim() + "?", "Confirmation Message"
                    , MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (check == DialogResult.Yes)
                {
                    try
                    {
                        connect.Open();
                        DateTime today = DateTime.Today;

                        string updateData = "UPDATE employees SET full_name = @fullName" +
                            ", gender = @gender, contact_number = @contactNum" +
                            ", position = @position, update_date = @updateDate, status = @status " +
                            "WHERE employee_id = @employeeID";

                        using (SqlCommand cmd = new SqlCommand(updateData, connect))
                        {
                            cmd.Parameters.AddWithValue("@fullName", addEmplyeeFullNamTextBox.Text.Trim());
                            cmd.Parameters.AddWithValue("@gender", addEmplyeeGenderComboBox.Text.Trim());
                            cmd.Parameters.AddWithValue("@contactNum", addEmplyeePhoneNumberTextBox.Text.Trim());
                            cmd.Parameters.AddWithValue("@position", addEmplyeePositionComboBox.Text.Trim());
                            cmd.Parameters.AddWithValue("@updateDate", today);
                            cmd.Parameters.AddWithValue("@status", addEmplyeeStatusComboBox.Text.Trim());
                            cmd.Parameters.AddWithValue("@employeeID", addEmplyeeEmployeeIDTextBox.Text.Trim());

                            cmd.ExecuteNonQuery();

                            displayEmployeeData();

                            MessageBox.Show("Update successfully!"
                                , "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            clearFields();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex
                        , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Cancelled."
                        , "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }

        private void addEmplyeeDeletebtn_Click(object sender, EventArgs e)
        {
            if (addEmplyeeEmployeeIDTextBox.Text == ""
                || addEmplyeeFullNamTextBox.Text == ""
                )
            {
                MessageBox.Show("Please enter the id and full name"
                    , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult check = MessageBox.Show("Are you sure you want to DELETE " +
                    "Employee ID: " + addEmplyeeEmployeeIDTextBox.Text.Trim() + "?", "Confirmation Message"
                    , MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (check == DialogResult.Yes)
                {
                    try
                    {
                        connect.Open();
                        DateTime today = DateTime.Today;

                        string updateData = "UPDATE employees SET delete_date = @deleteDate " +
                            "WHERE employee_id = @employeeID";

                        using (SqlCommand cmd = new SqlCommand(updateData, connect))
                        {
                            cmd.Parameters.AddWithValue("@deleteDate", today);
                            cmd.Parameters.AddWithValue("@employeeID", addEmplyeeEmployeeIDTextBox.Text.Trim());

                            cmd.ExecuteNonQuery();

                            displayEmployeeData();

                            MessageBox.Show("Update successfully!"
                                , "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            clearFields();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex
                        , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Cancelled."
                        , "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }

        private void addEmplyeeClearbtn_Click(object sender, EventArgs e)
        {
            clearFields();
        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                addEmplyeeEmployeeIDTextBox.Text = row.Cells[1].Value.ToString();
                addEmplyeeFullNamTextBox.Text = row.Cells[2].Value.ToString();
                addEmplyeeGenderComboBox.Text = row.Cells[3].Value.ToString();
                addEmplyeePhoneNumberTextBox.Text = row.Cells[4].Value.ToString();
                addEmplyeePositionComboBox.Text = row.Cells[5].Value.ToString();

                string imagePath = row.Cells[6].Value.ToString();

                if (imagePath != null)
                {
                    addEmplyeePic.Image = Image.FromFile(imagePath);
                }
                else
                {
                    addEmplyeePic.Image = null;
                }

                addEmplyeeStatusComboBox.Text = row.Cells[8].Value.ToString();
            }
        }

       
    }
}
