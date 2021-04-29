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
    public partial class EmployeeManagement : Form
    {
        public EmployeeManagement()
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
            this.Hide();
            new EmployeeReg().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new removeEmployee().Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            new EmployeeList().Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void EmployeeManagement_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            new AdminPortal().Show();
        }
    }
}
