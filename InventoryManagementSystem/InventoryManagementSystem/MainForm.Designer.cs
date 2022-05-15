namespace InventoryManagementSystem
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOrders = new InventoryManagementSystem.CustomerButton();
            this.btnUsers = new InventoryManagementSystem.CustomerButton();
            this.btnCategories = new InventoryManagementSystem.CustomerButton();
            this.btnCustomer = new InventoryManagementSystem.CustomerButton();
            this.btnProduct = new InventoryManagementSystem.CustomerButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PanelMain = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCategories)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnProduct)).BeginInit();
            this.PanelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnOrders);
            this.panel1.Controls.Add(this.btnUsers);
            this.panel1.Controls.Add(this.btnCategories);
            this.panel1.Controls.Add(this.btnCustomer);
            this.panel1.Controls.Add(this.btnProduct);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 92);
            this.panel1.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(534, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 15);
            this.label7.TabIndex = 18;
            this.label7.Text = "Orders";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(464, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 15);
            this.label5.TabIndex = 17;
            this.label5.Text = "Users";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(384, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 15);
            this.label6.TabIndex = 16;
            this.label6.Text = "Categories";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(311, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 15);
            this.label4.TabIndex = 15;
            this.label4.Text = "Customers";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(249, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 15);
            this.label2.TabIndex = 14;
            this.label2.Text = "Product";
            // 
            // btnOrders
            // 
            this.btnOrders.Image = ((System.Drawing.Image)(resources.GetObject("btnOrders.Image")));
            this.btnOrders.ImageHover = ((System.Drawing.Image)(resources.GetObject("btnOrders.ImageHover")));
            this.btnOrders.ImageNormal = ((System.Drawing.Image)(resources.GetObject("btnOrders.ImageNormal")));
            this.btnOrders.Location = new System.Drawing.Point(541, 26);
            this.btnOrders.Name = "btnOrders";
            this.btnOrders.Size = new System.Drawing.Size(31, 30);
            this.btnOrders.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnOrders.TabIndex = 13;
            this.btnOrders.TabStop = false;
            this.btnOrders.Click += new System.EventHandler(this.btnOrders_Click);
            // 
            // btnUsers
            // 
            this.btnUsers.Image = ((System.Drawing.Image)(resources.GetObject("btnUsers.Image")));
            this.btnUsers.ImageHover = ((System.Drawing.Image)(resources.GetObject("btnUsers.ImageHover")));
            this.btnUsers.ImageNormal = ((System.Drawing.Image)(resources.GetObject("btnUsers.ImageNormal")));
            this.btnUsers.Location = new System.Drawing.Point(470, 26);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(31, 30);
            this.btnUsers.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnUsers.TabIndex = 12;
            this.btnUsers.TabStop = false;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // btnCategories
            // 
            this.btnCategories.Image = ((System.Drawing.Image)(resources.GetObject("btnCategories.Image")));
            this.btnCategories.ImageHover = ((System.Drawing.Image)(resources.GetObject("btnCategories.ImageHover")));
            this.btnCategories.ImageNormal = ((System.Drawing.Image)(resources.GetObject("btnCategories.ImageNormal")));
            this.btnCategories.Location = new System.Drawing.Point(400, 26);
            this.btnCategories.Name = "btnCategories";
            this.btnCategories.Size = new System.Drawing.Size(31, 30);
            this.btnCategories.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnCategories.TabIndex = 11;
            this.btnCategories.TabStop = false;
            this.btnCategories.Click += new System.EventHandler(this.btnCategories_Click);
            // 
            // btnCustomer
            // 
            this.btnCustomer.Image = ((System.Drawing.Image)(resources.GetObject("btnCustomer.Image")));
            this.btnCustomer.ImageHover = ((System.Drawing.Image)(resources.GetObject("btnCustomer.ImageHover")));
            this.btnCustomer.ImageNormal = ((System.Drawing.Image)(resources.GetObject("btnCustomer.ImageNormal")));
            this.btnCustomer.Location = new System.Drawing.Point(329, 26);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(31, 30);
            this.btnCustomer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnCustomer.TabIndex = 10;
            this.btnCustomer.TabStop = false;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // btnProduct
            // 
            this.btnProduct.Image = ((System.Drawing.Image)(resources.GetObject("btnProduct.Image")));
            this.btnProduct.ImageHover = ((System.Drawing.Image)(resources.GetObject("btnProduct.ImageHover")));
            this.btnProduct.ImageNormal = ((System.Drawing.Image)(resources.GetObject("btnProduct.ImageNormal")));
            this.btnProduct.Location = new System.Drawing.Point(259, 26);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(31, 30);
            this.btnProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnProduct.TabIndex = 0;
            this.btnProduct.TabStop = false;
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 31);
            this.label1.TabIndex = 9;
            this.label1.Text = "Mdemy";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(3, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(243, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "INVENTORY MANAGEMENT SYSTEM";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Red;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 435);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 15);
            this.panel2.TabIndex = 1;
            // 
            // PanelMain
            // 
            this.PanelMain.Controls.Add(this.label9);
            this.PanelMain.Controls.Add(this.pictureBox1);
            this.PanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PanelMain.Location = new System.Drawing.Point(0, 92);
            this.PanelMain.Name = "PanelMain";
            this.PanelMain.Size = new System.Drawing.Size(800, 343);
            this.PanelMain.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(190, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(336, 305);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label9.Location = new System.Drawing.Point(579, 321);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(216, 15);
            this.label9.TabIndex = 2;
            this.label9.Text = "INVENTORY MANAGEMENT SYSTEM";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PanelMain);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCategories)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnProduct)).EndInit();
            this.PanelMain.ResumeLayout(false);
            this.PanelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel PanelMain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private CustomerButton btnProduct;
        private CustomerButton btnOrders;
        private CustomerButton btnUsers;
        private CustomerButton btnCategories;
        private CustomerButton btnCustomer;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}