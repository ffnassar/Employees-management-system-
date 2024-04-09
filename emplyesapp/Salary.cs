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
using EmployeeManagementSystem;

namespace emplyesapp
{
    public partial class Salary : UserControl
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Fady\OneDrive - Notre Dame University-Louaize\Documents\emplyee.mdf"";Integrated Security=True;Connect Timeout=30");
      
        public Salary()
        {
            InitializeComponent();

            displayEmployees();
            //disableFields();

        }

        public void RefreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)RefreshData);
                return;
            }

            displayEmployees();
            //disableFields();

        }

       

        public void displayEmployees()
        {
            SalaryData ed = new SalaryData();
            List<SalaryData> listData = ed.salaryEmployeeListData();

            dataGridView1.DataSource = listData;
        }
        //public void disableFields()
        //{
        //    SalaryEmplyeeIDTextBox.Enabled = false;
        //    FullNameTextBox2.Enabled = false;
        //    PositionTextBox.Enabled = false;
        //}




        private void Updatebutton_Click(object sender, EventArgs e)
        {
            if (SalaryEmplyeeIDTextBox.Text == ""
                 || PositionTextBox.Text == ""
                 || PositionTextBox.Text == ""
                 || SalaryTextBox.Text == "")
            {
                MessageBox.Show("Please fill all blank fields", "Error Message"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult check = MessageBox.Show("Are you sure you want to UPDATE Employee ID: "
                    + SalaryEmplyeeIDTextBox.Text.Trim() + "?", "Confirmation Message"
                    , MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (check == DialogResult.Yes)
                {
                    if (connect.State == ConnectionState.Closed)
                    {
                        try
                        {
                            connect.Open();
                            DateTime today = DateTime.Today;

                            string updateData = "UPDATE employees SET salary = @salary" +
                                ", update_date = @updateData WHERE employee_id = @employeeID";

                            using (SqlCommand cmd = new SqlCommand(updateData, connect))
                            {
                                cmd.Parameters.AddWithValue("@salary", SalaryTextBox.Text.Trim());
                                cmd.Parameters.AddWithValue("@updateData", today);
                                cmd.Parameters.AddWithValue("@employeeID", SalaryEmplyeeIDTextBox.Text.Trim());

                                cmd.ExecuteNonQuery();

                                displayEmployees();

                                MessageBox.Show("Updated successfully!"
                                    , "Information Message", MessageBoxButtons.OK
                                    , MessageBoxIcon.Information);

                                clearFields();

                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex, "Error Message"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            connect.Close();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Cancelled", "Information Message"
                    , MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void addSalaryAddbtn_Click(object sender, EventArgs e)
        {

        }

        private void Clearbutton_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                SalaryEmplyeeIDTextBox.Text = row.Cells[0].Value.ToString();
                FullNameTextBox2.Text = row.Cells[1].Value.ToString();
                PositionTextBox.Text = row.Cells[4].Value.ToString();
                SalaryTextBox.Text = row.Cells[5].Value.ToString();
            }
        }
        public void clearFields()
        {
            SalaryEmplyeeIDTextBox.Text = "";
            FullNameTextBox2.Text = "";
            PositionTextBox.Text = "";
            SalaryTextBox.Text = "";
           

        }

       
    }
}
