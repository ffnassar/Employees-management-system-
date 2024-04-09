using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace emplyesapp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SIGNOUTbtn_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Are you sure you want to logout?"
                , "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (check == DialogResult.Yes)
            {
                Form1 loginForm = new Form1();
                loginForm.Show();
                this.Hide();
            }
        }

       

        private void salary1_Load(object sender, EventArgs e)
        {

        }

        private void DASHBOARDBtn_Click(object sender, EventArgs e)
        {
            dashboard1.Visible = true;
            addEmplyee1.Visible = false;
            salary1.Visible = false;

            Dashboard dashForm = dashboard1 as Dashboard;

            if (dashForm != null)
            {
                dashForm.RefreshData();
            }
        }

        private void ADDEMPLYEEbtn_Click(object sender, EventArgs e)
        {

            dashboard1.Visible = false;
            addEmplyee1.Visible = true;
            salary1.Visible = false;

            AddEmplyee addEmForm = addEmplyee1 as AddEmplyee;

            if (addEmForm != null)
            {
                addEmForm.RefreshData();
            }
        }

        private void SALARYbtn_Click(object sender, EventArgs e)
        {
            dashboard1.Visible = false;
            addEmplyee1.Visible = false;
            salary1.Visible = true;

            Salary salaryForm = salary1 as Salary;

            if (salaryForm != null)
            {
                salaryForm.RefreshData();
            }

        }
    }
}
