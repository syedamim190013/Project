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
    public partial class RemoveProduct : Form
    {
        public RemoveProduct()
        {
            InitializeComponent();
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (e.CloseReason != CloseReason.WindowsShutDown)
                Application.Exit();
        }
        private void RemoveProduct_Load(object sender, EventArgs e)
        {
            var result = ProductController.GetAllProduct1();
            dataGridView1.DataSource = result;
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
            if (string.IsNullOrEmpty(id.Text))
            {
                MessageBox.Show("Please give all information", "Invalid Information",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    int Id = Convert.ToInt32(id.Text);
                    var result = ProductController.DeleteProduct(Id);
                    if (result)
                    {
                        MessageBox.Show("Product remove", "Remove product", MessageBoxButtons.OK, MessageBoxIcon.None);
                        id.Text = null;
                        var result1= ProductController.GetAllProduct1();
                        dataGridView1.DataSource = result1;
                    }
                    else
                    {
                        MessageBox.Show("Product not found", "Invalid Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Invalid Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ProductManagement().Show();
        }
    }
}
