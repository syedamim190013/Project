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
    public partial class ShopReg : Form
    {
        public ShopReg()
        {
            InitializeComponent();
            var shop = ShopController.GetAllShop();
            dataGridView1.DataSource = shop;

        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (e.CloseReason != CloseReason.WindowsShutDown)
                Application.Exit();
        }
        private void ShopReg_Load(object sender, EventArgs e)
        {

        }

        private void shopName_TextChanged(object sender, EventArgs e)
        {

        }

        private void register(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(shopId.Text) || string.IsNullOrEmpty(shopName.Text) || string.IsNullOrEmpty(outlet.Text))
            {
                if (string.IsNullOrEmpty(shopId.Text))
                {
                    idallert.Visible = true;
                  
                }
                else
                {
                    idallert.Visible = false;
                }
                if (string.IsNullOrEmpty(shopName.Text))
                {
                    nameallert.Visible = true;
                 
                }
                else
                {
                    idallert.Visible = false;
                }
                if (string.IsNullOrEmpty(outlet.Text))
                {
                    locallert.Visible = true;
               
                }
                else
                {
                    locallert.Visible = false;
                }
                MessageBox.Show("Please enter all information", "Restaurant Registration", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    var shop = new
                    {
                        Id = Convert.ToInt32(shopId.Text),
                        Name = shopName.Text.Trim(),
                        Location = outlet.Text.Trim()
                    };
                    var result = ShopController.AddShop(shop);
                    if (result)
                    {
                        MessageBox.Show("Shop Added", "Restaurant Registration", MessageBoxButtons.OK, MessageBoxIcon.None);
                        shopId.Text = null;
                        shopName.Text = null;
                        outlet.Text = null;
                        var shop1 = ShopController.GetAllShop();
                        dataGridView1.DataSource = shop1;

                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show("Please use numeric number in shop id", "Restaurant Registration", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
               

            }
                
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ShopManagement().Show();
        }
    }
}
