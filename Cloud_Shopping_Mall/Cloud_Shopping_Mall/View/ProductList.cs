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
    public partial class ProductList : Form
    {
        public ProductList()
        {
            InitializeComponent();
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (e.CloseReason != CloseReason.WindowsShutDown)
                Application.Exit();
        }
        private void submit(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbId.Text.Trim()))
            {
                MessageBox.Show("Please give all Information", "Invalid Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    int Id = Convert.ToInt32(tbId.Text);
                    dynamic result = ProductController.GetAllProduct(Id);
                    if (result!=null)
                    {
                        dynamic shopResult = ShopController.GetShop(Id);
                        if (shopResult!=null)
                        {
                            name.Text = shopResult.Name;
                        }
                        else
                        {
                            MessageBox.Show("Shop Not found", "Invalid Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        dgView.DataSource = result;
                    }
                    else 
                    {
                        MessageBox.Show("Shop Not found", "Invalid Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Invalid Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ProductList_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Customer_Portal().Show();
        }
    }
}
