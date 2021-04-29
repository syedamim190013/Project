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
    public partial class updateAdmin : Form
    {
        public updateAdmin()
        {
            InitializeComponent();
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (e.CloseReason != CloseReason.WindowsShutDown)
                Application.Exit();
        }
        private void updateAdmin_Load(object sender, EventArgs e)
        {
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                var admin = new
                {
                   Name = name.Text.Trim(),
                   PresentAddress = address.Text.Trim(),
                   MobileNo = Convert.ToInt32(mobile.Text),
                   Email = email.Text,
                   Password = password.Text
                };
                var result = AdminController.UpdateAdmin(admin);
                if (result)
                {
                    MessageBox.Show("Information Updated", "Update information", MessageBoxButtons.OK, MessageBoxIcon.None);
                    panel1.Visible = false;
                    email.Text = null;
                    password.Text = null;

                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter all information", "Invalid Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(email.Text.Trim()) || string.IsNullOrEmpty(password.Text.Trim()))
            {
                MessageBox.Show("Please enter all information", "Invalid Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string Email = email.Text.Trim();
                string Password = password.Text.Trim();
                var result = AdminController.GetAdmin1(Email, Password);
                if (result!=null)
                {
                    panel1.Visible = true;
                    name.Text = String.Format(result.Name);
                    address.Text = String.Format(result.PresentAddress);
                    mobile.Text = String.Format(Convert.ToString(result.MobileNo));
                }
                else
                {
                    MessageBox.Show("No user found", "Invalid Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            name.Enabled = true;
            address.Enabled = true;
            mobile.Enabled = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AdminPortal().Show();
        }
    }
}
