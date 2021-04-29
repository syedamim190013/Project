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
    public partial class updateShop : Form
    {
        public updateShop()
        {
            InitializeComponent();
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (e.CloseReason != CloseReason.WindowsShutDown)
                Application.Exit();
        }
        private void updateShop_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(id.Text))
            {
                MessageBox.Show("Please enter shop Id", "Invalid Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    int Id = Convert.ToInt32(id.Text);
                    var result = ShopController.GetShop(Id);
                    if (result!=null)
                    {
                        panel1.Visible = true;
                        name.Text = String.Format(result.Name);
                        location.Text = String.Format(result.Location);
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show("Please enter shop Id in correct formate", "Invalid Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            name.Enabled = true;
            location.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(id.Text.Trim()) || string.IsNullOrEmpty(name.Text.Trim()) || string.IsNullOrEmpty(location.Text.Trim()))
            {
                MessageBox.Show("Please enter your shop information", "Invalid Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var shop = new
                {
                    Id = Convert.ToInt32(id.Text),
                    Name = name.Text.Trim(),
                    Location = location.Text.Trim()
                };
                var result = ShopController.UpdateShop(shop);
                if (result)
                {
                    MessageBox.Show("Information Updated", "Update Information", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
                
            }
        }

        private void id_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void location_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ShopManagement().Show();
        }
    }
}
