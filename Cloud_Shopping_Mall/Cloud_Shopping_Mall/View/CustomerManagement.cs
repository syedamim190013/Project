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
    public partial class CustomerManagement : Form
    {
        public CustomerManagement()
        {
            InitializeComponent();
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (e.CloseReason != CloseReason.WindowsShutDown)
                Application.Exit();
        }
        private void CustomerManagement_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            new CustomerList().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new CustomerReg().Show();
        }

        private void Remove(object sender, EventArgs e)
        {
            this.Hide();
            new RemoveCustomer().Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            new EmployeePortal().Show();
        }
    }
}
