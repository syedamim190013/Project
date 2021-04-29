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
    public partial class RemoveCustomer : Form
    {
        public RemoveCustomer()
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
            try
            {
                string User = userName.Text;
                var result = CustomerController.DeleteCustomer(User);
                if (result)
                {
                    MessageBox.Show("Account Delete", "Delete", MessageBoxButtons.OK, MessageBoxIcon.None);
                    User = null;
                }
                else
                {
                    MessageBox.Show("Customer not found", "Invalid Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void back(object sender, EventArgs e)
        {
            this.Hide();
            new CustomerManagement().Show();
        }

        private void RemoveCustomer_Load(object sender, EventArgs e)
        {

        }
    }
}
