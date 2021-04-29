using Cloud_Shopping_Mall.Controller;
using Cloud_Shopping_Mall.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
  
namespace Cloud_Shopping_Mall.View
{
    public partial class AdminRegistation : Form
    {

        
        public AdminRegistation()
        {
            InitializeComponent();
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (e.CloseReason != CloseReason.WindowsShutDown)
                Application.Exit();
        }
        private void AdminRegistation_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
           

            if (string.IsNullOrEmpty(name.Text) || string.IsNullOrEmpty(address.Text) || string.IsNullOrEmpty(mobile.Text) || string.IsNullOrEmpty(email.Text) || string.IsNullOrEmpty(password.Text) || gender.SelectedItem == null)
            {
                
               
                if (string.IsNullOrEmpty(name.Text))
                {
                    nameallert.Visible = true;
                }
                else
                {
                    nameallert.Visible = false;
                }
                if (string.IsNullOrEmpty(address.Text))
                {
                    addressallert.Visible = true;
                }
                else
                {
                    addressallert.Visible = false;
                }
                if (string.IsNullOrEmpty(mobile.Text))
                {
                    mobileallert.Visible = true;
                }
                else
                {
                    mobileallert.Visible = false;
                }
                if (string.IsNullOrEmpty(email.Text))
                {
                    emailallert.Visible = true;
                }
                else
                {
                    emailallert.Visible = false;
                }
                if (string.IsNullOrEmpty(password.Text))
                {
                    passwordallert.Visible = true;
                }
                else
                {
                   passwordallert.Visible = false;
                }
                if (gender.SelectedItem == null)
                {
                    genderallert.Visible = true;
                }
                else
                {
                    genderallert.Visible = false;
                }
                
                MessageBox.Show("Please enter your Information", "Invalid Information", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
          


            else
            {
                 try
                {
                    var admin = new
                    {
                        Name = name.Text.Trim(),
                        PresentAddress = address.Text.Trim(),
                        MobileNo = Convert.ToInt32(mobile.Text),
                        Gender = gender.SelectedItem.ToString().Trim(),

                        Email = email.Text.Trim(),
                        Password = password.Text.Trim()

                    };
                    var result = AdminController.AddAdmin(admin);
                    if (result)
                    {
                        confirm.Visible = true;
                        this.Hide();
                        new LoginPage().Show();
                    }
                }
                catch(Exception ex)
                {
                    mobileallert.Visible = true;
                    MessageBox.Show(ex.Message, "Invalid Mobile No", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                 

                
                
               
                   
                
                
                
               
            }
           
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new LoginPage().Show();
        }
    }
}
