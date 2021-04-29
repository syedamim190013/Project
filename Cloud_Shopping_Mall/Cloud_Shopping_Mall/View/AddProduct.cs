using Cloud_Shopping_Mall.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cloud_Shopping_Mall.View
{
    
    public partial class AddProduct : Form
    {
       
        public AddProduct()
        {
            InitializeComponent();
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (e.CloseReason != CloseReason.WindowsShutDown)
                Application.Exit();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void AddProduct_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
            var result = ProductController.GetAllProduct1();
            dataGridView1.DataSource = result;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Quantity = Convert.ToInt32(quantity.Text);
            Quantity++;
            quantity.Text = String.Format(Convert.ToString(Quantity)); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int Quantity = Convert.ToInt32(quantity.Text);
            if (Quantity >0)
            {
                Quantity--;
                quantity.Text = String.Format(Convert.ToString(Quantity));
            }
          
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(shopId.Text.Trim()) || string.IsNullOrEmpty(name.Text.Trim()) || string.IsNullOrEmpty(price.Text.Trim()) || string.IsNullOrEmpty(shopId.Text.Trim()) || string.IsNullOrEmpty(quantity.Text.Trim()))
            {
                MessageBox.Show("Please give all Information", "Invalid Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
               
                
                try
                {
                    var product = new
                    {
                        Id = Convert.ToInt32(id.Text.Trim()),
                        Name = name.Text.Trim(),
                        Quantity = Convert.ToInt32(quantity.Text.Trim()),
                        Price = Convert.ToInt32(price.Text.Trim()),
                        ShopId = Convert.ToInt32(shopId.Text.Trim())
                    };
                    var shopResult = ShopController.GetShop(product.ShopId);
                    if (shopResult!=null)
                    {
                        var Result = ProductController.AddProduct(product);
                        if (Result)
                        {
                            MessageBox.Show("Product Added", "Product Registration", MessageBoxButtons.OK, MessageBoxIcon.None);
                            id.Text = null;
                            name.Text = null;
                            quantity.Text = String.Format("0");
                            price.Text = null;
                            shopId.Text = null;
                            var result = ProductController.GetAllProduct1();
                            dataGridView1.DataSource = result;

                        }
                        else
                        {
                            MessageBox.Show("Product Couldn't added", "Product Registration", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("No Shop Found", "Product Registration", MessageBoxButtons.OK, MessageBoxIcon.None);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Invalid Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ProductManagement().Show();
        }
    }
}
