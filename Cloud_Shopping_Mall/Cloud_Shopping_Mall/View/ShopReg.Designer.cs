namespace Cloud_Shopping_Mall.View
{
    partial class ShopReg
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.shopId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.shopName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.outlet = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.idallert = new System.Windows.Forms.PictureBox();
            this.nameallert = new System.Windows.Forms.PictureBox();
            this.locallert = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.idallert)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameallert)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.locallert)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 19.8F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(320, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Shopping Mall";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(114, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Shop ID";
            // 
            // shopId
            // 
            this.shopId.Location = new System.Drawing.Point(294, 126);
            this.shopId.Name = "shopId";
            this.shopId.Size = new System.Drawing.Size(324, 22);
            this.shopId.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(114, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Shop Name";
            // 
            // shopName
            // 
            this.shopName.Location = new System.Drawing.Point(294, 193);
            this.shopName.Name = "shopName";
            this.shopName.Size = new System.Drawing.Size(324, 22);
            this.shopName.TabIndex = 4;
            this.shopName.TextChanged += new System.EventHandler(this.shopName_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(114, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Outlet Location";
            // 
            // outlet
            // 
            this.outlet.Location = new System.Drawing.Point(294, 257);
            this.outlet.Name = "outlet";
            this.outlet.Size = new System.Drawing.Size(324, 22);
            this.outlet.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Blue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(313, 324);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 45);
            this.button1.TabIndex = 7;
            this.button1.Text = "Register";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.register);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Lime;
            this.button5.Location = new System.Drawing.Point(690, 24);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(83, 30);
            this.button5.TabIndex = 8;
            this.button5.Text = "Back";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // idallert
            // 
            this.idallert.BackgroundImage = global::Cloud_Shopping_Mall.Properties.Resources.cancel;
            this.idallert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.idallert.Location = new System.Drawing.Point(585, 126);
            this.idallert.Name = "idallert";
            this.idallert.Size = new System.Drawing.Size(33, 24);
            this.idallert.TabIndex = 15;
            this.idallert.TabStop = false;
            this.idallert.Visible = false;
            // 
            // nameallert
            // 
            this.nameallert.BackgroundImage = global::Cloud_Shopping_Mall.Properties.Resources.cancel;
            this.nameallert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.nameallert.Location = new System.Drawing.Point(585, 193);
            this.nameallert.Name = "nameallert";
            this.nameallert.Size = new System.Drawing.Size(33, 24);
            this.nameallert.TabIndex = 16;
            this.nameallert.TabStop = false;
            this.nameallert.Visible = false;
            // 
            // locallert
            // 
            this.locallert.BackgroundImage = global::Cloud_Shopping_Mall.Properties.Resources.cancel;
            this.locallert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.locallert.Location = new System.Drawing.Point(585, 254);
            this.locallert.Name = "locallert";
            this.locallert.Size = new System.Drawing.Size(33, 24);
            this.locallert.TabIndex = 17;
            this.locallert.TabStop = false;
            this.locallert.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(204, 430);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(414, 307);
            this.dataGridView1.TabIndex = 18;
            // 
            // ShopReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.ClientSize = new System.Drawing.Size(907, 749);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.locallert);
            this.Controls.Add(this.nameallert);
            this.Controls.Add(this.idallert);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.outlet);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.shopName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.shopId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ShopReg";
            this.Text = "ShopReg";
            this.Load += new System.EventHandler(this.ShopReg_Load);
            ((System.ComponentModel.ISupportInitialize)(this.idallert)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameallert)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.locallert)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox shopId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox shopName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox outlet;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.PictureBox idallert;
        private System.Windows.Forms.PictureBox nameallert;
        private System.Windows.Forms.PictureBox locallert;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}