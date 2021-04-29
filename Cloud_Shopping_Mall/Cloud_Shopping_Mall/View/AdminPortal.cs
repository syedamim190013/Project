﻿using System;
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
    public partial class AdminPortal : Form
    {
       
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (e.CloseReason != CloseReason.WindowsShutDown)
                Application.Exit();
        }
        public AdminPortal()
        {
            InitializeComponent();
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AdminPortal_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new EmployeeManagement().Show();
        }

        private void ShopManagement(object sender, EventArgs e)
        {
            
            new ShopManagement().Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
            new updateAdmin().Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
            new DeleteAdmin().Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            new AllAdmin().Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            new LoginPage().Show();
        }
    }
}
