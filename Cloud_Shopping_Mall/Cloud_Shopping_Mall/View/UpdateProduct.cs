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
    public partial class UpdateProduct : Form
    {
        public UpdateProduct()
        {
            InitializeComponent();
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (e.CloseReason != CloseReason.WindowsShutDown)
                Application.Exit();
        }
        private void search(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(id.Text.Trim()))
            {
                MessageBox.Show("Please give all Information", "Invalid Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    int Id = Convert.ToInt32(id.Text);
                    var result = ProductController.GetProduct(Id);
                    if (result!=null)
                    {
                        panel1.Visible = true;
                        quantity.Text =Convert.ToString( result.Quantity);
                        price.Text = Convert.ToString( result.Price);
                    }
                    else
                    {
                        MessageBox.Show("Product Not found", "Invalid Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Invalid Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void UpdateProduct_Load(object sender, EventArgs e)
        {

        }

        private void edit(object sender, EventArgs e)
        {
            quantity.Enabled = true;
            price.Enabled = true;
        }

        private void update(object sender, EventArgs e)
        {
            try
            {
                var product = new
                {
                    Id = Convert.ToInt32(id.Text),
                    Quantity = Convert.ToInt32(quantity.Text),
                    Price = Convert.ToInt32(price.Text)
                };
                var result = ProductController.UpdateProduct(product);
                if (result)
                {
                    MessageBox.Show("Product Update", "Update Info", MessageBoxButtons.OK, MessageBoxIcon.None);
                    panel1.Visible = false;
                    id.Text = null;
                    quantity.Enabled = false;
                    price.Enabled = false;
                }
                else {
                    MessageBox.Show("Product Not found", "Invalid Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception ex )
            {
                MessageBox.Show(ex.Message, "Invalid Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void back(object sender, EventArgs e)
        {
            this.Hide();
            new ProductManagement().Show();
        }
    }
}
