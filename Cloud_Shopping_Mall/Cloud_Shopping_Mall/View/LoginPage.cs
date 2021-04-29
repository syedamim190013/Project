using Cloud_Shopping_Mall.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cloud_Shopping_Mall.View
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (e.CloseReason != CloseReason.WindowsShutDown)
                Application.Exit();
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {
            panel1.BackColor= Color.FromArgb(100, 0, 0, 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
              string Email = email.Text.Trim();
            string Password = password.Text.Trim();
            if (admin.Checked == false && employee.Checked == false && customer.Checked == false)
            {
                MessageBox.Show("Please select a category", "Invalid Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (string.IsNullOrEmpty(Email) || string.IsNullOrEmpty(Password))
            {
                if (string.IsNullOrEmpty(Email))
                {
                    emailallert.Visible = true;
                }
                else
                {
                    emailallert.Visible = false;
                }
                if (string.IsNullOrEmpty(Password))
                {
                    passwordallert.Visible = true;

                }
                else
                {
                    passwordallert.Visible = false;
                }
                MessageBox.Show("Please enter your Information", "Invalid Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (admin.Checked == true)
                {
                    dynamic AdminResult = AdminController.AuthenticateAdmin(Email, Password);
                    if (AdminResult != null)
                    {
                        this.Hide();
                       
                        new AdminPortal().Show();
                    }
                    else
                    {
                        MessageBox.Show("User Not Valid", "Invalid Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (employee.Checked == true)
                {
                    dynamic EmployeeResult = EmployeeController.AuthenticEmployee(Email,Email,Password);
                    if(EmployeeResult != null)
                    {
                        this.Hide();
                        new EmployeePortal().Show();
                    }
                    else
                    {
                        MessageBox.Show("User Not Valid", "Invalid Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (customer.Checked == true)
                {
                    dynamic CustomerResult = CustomerController.AuthenticateCustomer(Email, Email, Password);
                    if(CustomerResult != null)
                    {
                        this.Hide();
                        new Customer_Portal().Show();
                    }
                    else
                    {
                        MessageBox.Show("User Not Valid", "Invalid Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void passcheck_CheckedChanged(object sender, EventArgs e)
        {
            if (passcheck.Checked)
            {
                password.UseSystemPasswordChar = false;
            }
            else
            {
                password.UseSystemPasswordChar = true;
            }
        }

        private void forget_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new ForgetPassword().Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new Register().Show();
        }
    }
}
