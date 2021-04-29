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
    public partial class order : Form
    {
        public order()
        {
            InitializeComponent();
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (e.CloseReason != CloseReason.WindowsShutDown)
                Application.Exit();
        }
        private void order_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int Quantity = Convert.ToInt32(quantity.Text);
            Quantity++;
            quantity.Text = String.Format(Convert.ToString(Quantity));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int Quantity = Convert.ToInt32(quantity.Text);
            if (Quantity > 0)
            {
                Quantity--;
                quantity.Text = String.Format(Convert.ToString(Quantity));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(id.Text.Trim()) || string.IsNullOrEmpty(quantity.Text.Trim()))
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
                        panel2.Visible = true;
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

        private void button4_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(id.Text.Trim()) || string.IsNullOrEmpty(quantity.Text.Trim()) || string.IsNullOrEmpty(userName.Text.Trim()) || string.IsNullOrEmpty(password.Text.Trim()))
            {
                MessageBox.Show("Please give all Information", "Invalid Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
               {
                    var order = new
                    {
                        OrderId = 1,
                        ProductId = Convert.ToInt32(id.Text),
                        Quantity = Convert.ToInt32(quantity.Text),
                        CustomerUser= userName.Text.Trim()

                    };
                    var productCheck = ProductController.GetProduct(order.ProductId);
                    if (productCheck != null)
                    {
                        if ((productCheck.Quantity - order.Quantity) >= 0)
                        {
                            var customerCheck = CustomerController.GetCustomer(order.CustomerUser, password.Text.Trim());
                            if (customerCheck!=null)
                            {
                                if ((customerCheck.Balance - productCheck.Price) >= 0)
                                {
                                    var orderConfirm = OrderController.AddOrder(order);
                                    if (orderConfirm)
                                    {
                                        MessageBox.Show("Order confirm successfully", "Order", MessageBoxButtons.OK, MessageBoxIcon.None);
                                        int totalQuantity = productCheck.Quantity - order.Quantity;
                                        int totalBalance = customerCheck.Balance - productCheck.Price;
                                        var balance = new
                                        {
                                            Balance = totalBalance,
                                            UserName = userName.Text.Trim()
                                        };
                                        var quantity1 = new
                                        {
                                            Id = Convert.ToInt32( id.Text),
                                            Quantity = totalQuantity
                                        };
                                        var customerUpdate = CustomerController.UpdateCustomer1(balance);
                                        var ProductUpdate = ProductController.UpdateProduct1(quantity1);
                                        userName.Text = null;
                                        password.Text = null;
                                        panel2.Visible = false;
                                        id.Text = null;
                                        quantity.Text = string.Format("0");
                                    }
                                    else
                                    {
                                        MessageBox.Show("Order failed", "Order", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Not enough sufficient balance", "Invalid Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Wrong user", "Invalid Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Product Not available", "Invalid Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
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

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Customer_Portal().Show();
        }
    }
}
