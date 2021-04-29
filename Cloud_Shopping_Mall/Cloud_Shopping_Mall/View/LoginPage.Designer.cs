namespace Cloud_Shopping_Mall.View
{
    partial class LoginPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.passwordallert = new System.Windows.Forms.PictureBox();
            this.emailallert = new System.Windows.Forms.PictureBox();
            this.forget = new System.Windows.Forms.LinkLabel();
            this.customer = new System.Windows.Forms.RadioButton();
            this.employee = new System.Windows.Forms.RadioButton();
            this.admin = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.passcheck = new System.Windows.Forms.CheckBox();
            this.password = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.passwordallert)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emailallert)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Controls.Add(this.passwordallert);
            this.panel1.Controls.Add(this.emailallert);
            this.panel1.Controls.Add(this.forget);
            this.panel1.Controls.Add(this.customer);
            this.panel1.Controls.Add(this.employee);
            this.panel1.Controls.Add(this.admin);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.passcheck);
            this.panel1.Controls.Add(this.password);
            this.panel1.Controls.Add(this.email);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(159, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(555, 336);
            this.panel1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(158, 283);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "If you have no account";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.linkLabel1.Location = new System.Drawing.Point(315, 283);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(94, 17);
            this.linkLabel1.TabIndex = 17;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Register here";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // passwordallert
            // 
            this.passwordallert.BackgroundImage = global::Cloud_Shopping_Mall.Properties.Resources.cancel;
            this.passwordallert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.passwordallert.Location = new System.Drawing.Point(452, 167);
            this.passwordallert.Name = "passwordallert";
            this.passwordallert.Size = new System.Drawing.Size(32, 18);
            this.passwordallert.TabIndex = 16;
            this.passwordallert.TabStop = false;
            this.passwordallert.Visible = false;
            // 
            // emailallert
            // 
            this.emailallert.BackgroundImage = global::Cloud_Shopping_Mall.Properties.Resources.cancel;
            this.emailallert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.emailallert.Location = new System.Drawing.Point(452, 123);
            this.emailallert.Name = "emailallert";
            this.emailallert.Size = new System.Drawing.Size(32, 18);
            this.emailallert.TabIndex = 15;
            this.emailallert.TabStop = false;
            this.emailallert.Visible = false;
            // 
            // forget
            // 
            this.forget.AutoSize = true;
            this.forget.BackColor = System.Drawing.Color.Transparent;
            this.forget.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.forget.Location = new System.Drawing.Point(408, 203);
            this.forget.Name = "forget";
            this.forget.Size = new System.Drawing.Size(114, 17);
            this.forget.TabIndex = 14;
            this.forget.TabStop = true;
            this.forget.Text = "Forget Password";
            this.forget.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.forget_LinkClicked);
            // 
            // customer
            // 
            this.customer.AutoSize = true;
            this.customer.BackColor = System.Drawing.Color.Transparent;
            this.customer.Cursor = System.Windows.Forms.Cursors.Default;
            this.customer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.customer.Location = new System.Drawing.Point(392, 74);
            this.customer.Name = "customer";
            this.customer.Size = new System.Drawing.Size(111, 24);
            this.customer.TabIndex = 13;
            this.customer.TabStop = true;
            this.customer.Text = "Customer";
            this.customer.UseVisualStyleBackColor = false;
            // 
            // employee
            // 
            this.employee.AutoSize = true;
            this.employee.BackColor = System.Drawing.Color.Transparent;
            this.employee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.employee.Location = new System.Drawing.Point(215, 74);
            this.employee.Name = "employee";
            this.employee.Size = new System.Drawing.Size(111, 24);
            this.employee.TabIndex = 12;
            this.employee.TabStop = true;
            this.employee.Text = "Employee";
            this.employee.UseVisualStyleBackColor = false;
            // 
            // admin
            // 
            this.admin.AutoSize = true;
            this.admin.BackColor = System.Drawing.Color.Transparent;
            this.admin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.admin.Location = new System.Drawing.Point(72, 74);
            this.admin.Name = "admin";
            this.admin.Size = new System.Drawing.Size(82, 24);
            this.admin.TabIndex = 11;
            this.admin.TabStop = true;
            this.admin.Text = "Admin";
            this.admin.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.Location = new System.Drawing.Point(206, 249);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 31);
            this.button1.TabIndex = 9;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // passcheck
            // 
            this.passcheck.AutoSize = true;
            this.passcheck.BackColor = System.Drawing.Color.Transparent;
            this.passcheck.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.passcheck.Location = new System.Drawing.Point(25, 202);
            this.passcheck.Name = "passcheck";
            this.passcheck.Size = new System.Drawing.Size(129, 21);
            this.passcheck.TabIndex = 8;
            this.passcheck.Text = "Show Password";
            this.passcheck.UseVisualStyleBackColor = false;
            this.passcheck.CheckedChanged += new System.EventHandler(this.passcheck_CheckedChanged);
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(215, 165);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(269, 22);
            this.password.TabIndex = 7;
            this.password.UseSystemPasswordChar = true;
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(215, 123);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(269, 22);
            this.email.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(21, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(21, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Email or UserName";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(229, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome";
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Cloud_Shopping_Mall.Properties.Resources._29nhJr;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(916, 526);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Name = "LoginPage";
            this.Text = "LoginPage";
            this.Load += new System.EventHandler(this.LoginPage_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.passwordallert)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emailallert)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox passcheck;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel forget;
        private System.Windows.Forms.RadioButton customer;
        private System.Windows.Forms.RadioButton employee;
        private System.Windows.Forms.RadioButton admin;
        private System.Windows.Forms.PictureBox passwordallert;
        private System.Windows.Forms.PictureBox emailallert;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}