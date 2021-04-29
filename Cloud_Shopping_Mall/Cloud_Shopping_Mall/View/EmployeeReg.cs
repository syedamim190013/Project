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
    public partial class EmployeeReg : Form
    {
        public EmployeeReg()
        {
            InitializeComponent();
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (e.CloseReason != CloseReason.WindowsShutDown)
                Application.Exit();
        }
        private void EmployeeReg_Load(object sender, EventArgs e)
        {
           // panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (addresscheck.Checked)
            {
                Peddress.Text = prAddress.Text;
                Peddress.Enabled = false;
            }
            else
            {
                Peddress.Enabled = true;
            }
        }

        private void confirmpass_TextChanged(object sender, EventArgs e)
        {
            if (!(confirmpass.Text.Trim()).Equals(password.Text.Trim()))
            {
                passerror.Visible = true;
            }
            else
            {
                passerror.Visible = false;
            }
        }

        private void password_TextChanged(object sender, EventArgs e)
        {
            if (!(password.Text.Trim()).Equals(confirmpass.Text.Trim()))
            {
                passerror.Visible = true;
            }
            else
            {
                passerror.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(name.Text.Trim())||string.IsNullOrEmpty(number.Text.Trim())||gender.SelectedItem==null||division.SelectedItem==null||string.IsNullOrEmpty(zip.Text.Trim())||string.IsNullOrEmpty(Peddress.Text.Trim())||string.IsNullOrEmpty(prAddress.Text.Trim())||string.IsNullOrEmpty(nid.Text.Trim())||string.IsNullOrEmpty(bcertificate.Text.Trim())||string.IsNullOrEmpty(email.Text.Trim())||string.IsNullOrEmpty(username.Text.Trim())||string.IsNullOrEmpty(password.Text.Trim())||!termCheck.Checked)
            {
                if (string.IsNullOrEmpty(name.Text.Trim()))
                {
                    namerror.Visible = true;
                }
                else
                {
                    namerror.Visible = false;
                }
                if (string.IsNullOrEmpty(number.Text.Trim()))
                {
                    mobileerror.Visible = true;
                }
                else
                {
                    mobileerror.Visible = false;
                }
                if (gender.SelectedItem == null)
                {
                    gendererror.Visible = true;
                }
                else
                {
                    gendererror.Visible = false;
                }
                if(division.SelectedItem == null)
                {
                    divisionerror.Visible = true;
                }
                else
                {
                    divisionerror.Visible = false;
                }
                if (string.IsNullOrEmpty(zip.Text.Trim()))
                {
                    ziperror.Visible = true;
                }
                else
                {
                    ziperror.Visible = false;
                }
                if (string.IsNullOrEmpty(prAddress.Text.Trim()))
                {
                    prerror.Visible = true;
                }
                else
                {
                    prerror.Visible = false;
                }
                if (string.IsNullOrEmpty(Peddress.Text.Trim()))
                {
                    peerror.Visible = true;
                }
                else
                {
                    peerror.Visible = false;
                }
                if (string.IsNullOrEmpty(nid.Text.Trim()))
                {
                    niderror.Visible = true;
                }
                else
                {
                    niderror.Visible = false;
                }
                if (string.IsNullOrEmpty(bcertificate.Text.Trim()))
                {
                    bcerror.Visible = true;
                }
                else
                {
                    bcerror.Visible = false;
                }
                if (string.IsNullOrEmpty(email.Text.Trim()))
                {
                    emailerror.Visible = true;
                }
                else
                {
                    emailerror.Visible = false;
                }
                if (string.IsNullOrEmpty(username.Text.Trim()))
                {
                    usererror.Visible = true;
                }
                else
                {
                    usererror.Visible = false;
                }
                if (string.IsNullOrEmpty(password.Text.Trim()))
                {
                    passworderror.Visible = true;
                }
                else
                {
                    passworderror.Visible = false;
                }
                if (string.IsNullOrEmpty(confirmpass.Text))
                {
                    confirmerror.Visible = true;
                }
                else
                {
                    confirmerror.Visible = false;
                }
                if (!termCheck.Checked)
                {
                    termerror.Visible = true;
                }
                else
                {
                    termerror.Visible = false;
                }
               
                MessageBox.Show("Please enter your all Information", "Invalid Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           else if (confirmReg.Text.Trim().Equals(password.Text.Trim()))
            {
                confirmerror.Visible = true;
                passerror.Visible = true;
                
            }
           
           else if (email.Text.Trim().Contains(".com") == false)
            {
                emailerror.Visible = true;
                emailmsg.Visible = true;
            }
            
           else if (number.Text.Trim().Length != 11)
            {
                mobileerror.Visible = true;
                mobilemsg.Visible = true;
                mobilemsg.Text = String.Format("Enter at 11 digit phone number you enter {0} digits",number.Text.Trim().Length);
            }
           
           else if (number.Text.Trim().Substring(0, 2) != ("01"))
            {
                mobileerror.Visible = true;
                mobilemsg.Visible = true;
                mobilemsg.Text = String.Format("Wrong operator");
            }
           
          else if (password.Text.Trim().Length < 6)
            {
                passworderror.Visible = true;               
            }
            
            else
            {
                try
                {
                    var employee = new
                    {
                        Name = name.Text.Trim(),
                        MobileNo = Convert.ToInt32(number.Text.Trim()),
                        Gender = gender.SelectedItem.ToString().Trim(),
                        Division = division.SelectedItem.ToString().Trim(),
                        ZipCode = Convert.ToInt32(zip.Text.Trim()),
                        PresentAddress = prAddress.Text.Trim(),
                        PermanentAddress = Peddress.Text.Trim(),
                        Nid = Convert.ToInt32(nid.Text.Trim()),
                        BirthCertificate = Convert.ToInt32(bcertificate.Text.Trim()),
                        Email = email.Text.Trim(),
                        UserName = username.Text.Trim(),
                        Password = password.Text.Trim()


                    };
                    var result = EmployeeController.AddEmployee(employee);
                    if (result)
                    {
                        confirmReg.Visible = true;
                        this.Hide();
                        new LoginPage().Show();
                    }
                }
                catch (FormatException)
                {
                    reject.Visible = true;
                    
                }
               
                   
                
                
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new LoginPage().Show();
        }

        private void reject_Click(object sender, EventArgs e)
        {

        }

        private void mobilemsg_Click(object sender, EventArgs e)
        {

        }

        private void emailmsg_Click(object sender, EventArgs e)
        {

        }

        private void gendererror_Click(object sender, EventArgs e)
        {

        }

        private void termerror_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void gender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void confirmerror_Click(object sender, EventArgs e)
        {

        }

        private void passworderror_Click(object sender, EventArgs e)
        {

        }

        private void usererror_Click(object sender, EventArgs e)
        {

        }

        private void emailerror_Click(object sender, EventArgs e)
        {

        }

        private void bcerror_Click(object sender, EventArgs e)
        {

        }

        private void niderror_Click(object sender, EventArgs e)
        {

        }

        private void peerror_Click(object sender, EventArgs e)
        {

        }

        private void prerror_Click(object sender, EventArgs e)
        {

        }

        private void ziperror_Click(object sender, EventArgs e)
        {

        }

        private void divisionerror_Click(object sender, EventArgs e)
        {

        }

        private void mobileerror_Click(object sender, EventArgs e)
        {

        }

        private void namerror_Click(object sender, EventArgs e)
        {

        }

        private void termCheck_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void confirmReg_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void passerror_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void username_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void email_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void bcertificate_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void nid_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void Peddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void zip_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void division_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void prAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void number_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void name_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
