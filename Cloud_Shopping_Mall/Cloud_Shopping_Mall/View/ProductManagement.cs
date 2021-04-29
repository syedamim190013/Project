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
    public partial class ProductManagement : Form
    {
        public ProductManagement()
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
            new AddProduct().Show();
        }

        private void ProductManagement_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new RemoveProduct().Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            new UpdateProduct().Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ProductList().Show();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            new EmployeePortal().Show();
        }
    }
}
