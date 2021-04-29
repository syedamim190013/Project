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
    public partial class removeEmployee : Form
    {
        public removeEmployee()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (e.CloseReason != CloseReason.WindowsShutDown)
                Application.Exit();
        }
        private void removeEmployee_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string User = userName.Text.Trim();
            dynamic custDelete = EmployeeController.DeleteEmployee(User);
            if (custDelete)
            {
                label3.Visible = true;
                MessageBox.Show("Employee Removed", "Employee Remove", MessageBoxButtons.OK, MessageBoxIcon.Error);
                new EmployeeManagement().Show();
            }
            else
            {
                MessageBox.Show("Employee not found", "Employee Remove", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            new EmployeeManagement().Show();
        }
    }
}
