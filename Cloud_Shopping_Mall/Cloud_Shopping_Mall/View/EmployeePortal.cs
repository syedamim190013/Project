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
    public partial class EmployeePortal : Form
    {
        public EmployeePortal()
        {
            InitializeComponent();
            
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (e.CloseReason != CloseReason.WindowsShutDown)
                Application.Exit();
        }
        private void EmployeePortal_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new ProductManagement().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new CustomerManagement().Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            new LoginPage().Show();
        }
    }
}
