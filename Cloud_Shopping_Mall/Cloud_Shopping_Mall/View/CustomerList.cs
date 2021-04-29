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
    public partial class CustomerList : Form
    {
        public CustomerList()
        {
            InitializeComponent();
            var result = CustomerController.GetAllCustomer();
            dataGridView1.DataSource = result;
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (e.CloseReason != CloseReason.WindowsShutDown)
                Application.Exit();
        }
        private void CustomerList_Load(object sender, EventArgs e)
        {
        
        }
    }
}
