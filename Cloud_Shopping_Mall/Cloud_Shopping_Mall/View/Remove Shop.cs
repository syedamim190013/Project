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
    public partial class Remove_Shop : Form
    {
        public Remove_Shop()
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
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Id = Convert.ToInt32(id.Text);
            if (string.IsNullOrEmpty(id.Text))
            {
                MessageBox.Show("Give Information", "Restaurant Registration", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    var result = ShopController.DeleteShop(Id);
                    if (result)
                    {
                        MessageBox.Show("Shop Remove", "Restaurant Registration", MessageBoxButtons.OK, MessageBoxIcon.None);
                        id.Text = null;
                        var shop = ShopController.GetAllShop();
                        dataGridView1.DataSource = shop;
                   
                    }
                    else
                    {
                        MessageBox.Show("No shop found", "Restaurant Registration", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show("Enter restaurnat id in correct formate", "Restaurant Registration", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
           
        }

        private void Remove_Shop_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ShopManagement().Show();
        }
    }
}
