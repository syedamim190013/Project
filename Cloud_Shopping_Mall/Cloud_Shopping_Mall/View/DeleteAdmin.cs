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
    public partial class DeleteAdmin : Form
    {
        public DeleteAdmin()
        {
            InitializeComponent();
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (e.CloseReason != CloseReason.WindowsShutDown)
                Application.Exit();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string Email = email.Text.Trim();
            string Password = password.Text.Trim();
            if (string.IsNullOrEmpty(Email) || string.IsNullOrEmpty(Password))
            {
                MessageBox.Show("Please enter all information", "Invalid Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var result = AdminController.DeleteAdmin(Email, Password);
                if (result)
                {
                    MessageBox.Show("Account Delete", "Invalid Information", MessageBoxButtons.OK, MessageBoxIcon.None);
                    this.Hide();
                    new LoginPage().Show();
                }
                else
                {
                    MessageBox.Show("No user found", "Invalid Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void DeleteAdmin_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AdminPortal().Show();
        }
    }
}
