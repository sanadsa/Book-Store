namespace Login
{
    partial class AddPurchase
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSell = new System.Windows.Forms.Button();
            this.grpbPurchase = new System.Windows.Forms.GroupBox();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nUDQuantity = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.dateTimePurchase = new System.Windows.Forms.DateTimePicker();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.grpbPurchase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUDQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(620, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.BackColor = System.Drawing.Color.Red;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // btnSell
            // 
            this.btnSell.Location = new System.Drawing.Point(528, 229);
            this.btnSell.Name = "btnSell";
            this.btnSell.Size = new System.Drawing.Size(75, 23);
            this.btnSell.TabIndex = 6;
            this.btnSell.Text = "Sell Item";
            this.btnSell.UseVisualStyleBackColor = true;
            this.btnSell.Click += new System.EventHandler(this.btnSell_Click);
            // 
            // grpbPurchase
            // 
            this.grpbPurchase.Controls.Add(this.txtStock);
            this.grpbPurchase.Controls.Add(this.label3);
            this.grpbPurchase.Controls.Add(this.nUDQuantity);
            this.grpbPurchase.Controls.Add(this.label11);
            this.grpbPurchase.Controls.Add(this.dateTimePurchase);
            this.grpbPurchase.Controls.Add(this.txtPrice);
            this.grpbPurchase.Controls.Add(this.label5);
            this.grpbPurchase.Controls.Add(this.label6);
            this.grpbPurchase.Controls.Add(this.txtItemName);
            this.grpbPurchase.Controls.Add(this.label2);
            this.grpbPurchase.Controls.Add(this.txtCustomerName);
            this.grpbPurchase.Controls.Add(this.label1);
            this.grpbPurchase.Location = new System.Drawing.Point(12, 27);
            this.grpbPurchase.Name = "grpbPurchase";
            this.grpbPurchase.Size = new System.Drawing.Size(591, 179);
            this.grpbPurchase.TabIndex = 5;
            this.grpbPurchase.TabStop = false;
            this.grpbPurchase.Text = "Purchase";
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(370, 110);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(164, 20);
            this.txtStock.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(297, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 35;
            this.label3.Text = "stock:";
            // 
            // nUDQuantity
            // 
            this.nUDQuantity.Location = new System.Drawing.Point(98, 110);
            this.nUDQuantity.Name = "nUDQuantity";
            this.nUDQuantity.Size = new System.Drawing.Size(168, 20);
            this.nUDQuantity.TabIndex = 33;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 110);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 13);
            this.label11.TabIndex = 31;
            this.label11.Text = "quantity to sell:";
            // 
            // dateTimePurchase
            // 
            this.dateTimePurchase.Location = new System.Drawing.Point(98, 66);
            this.dateTimePurchase.Name = "dateTimePurchase";
            this.dateTimePurchase.Size = new System.Drawing.Size(168, 20);
            this.dateTimePurchase.TabIndex = 2;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(370, 67);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(164, 20);
            this.txtPrice.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(297, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "item price:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "purchase date:";
            // 
            // txtItemName
            // 
            this.txtItemName.Location = new System.Drawing.Point(370, 26);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(164, 20);
            this.txtItemName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(297, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "itemName:";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(98, 26);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(168, 20);
            this.txtCustomerName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "cutomer name:";
            // 
            // AddPurchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 288);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnSell);
            this.Controls.Add(this.grpbPurchase);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AddPurchase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Purchase";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpbPurchase.ResumeLayout(false);
            this.grpbPurchase.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUDQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button btnSell;
        private System.Windows.Forms.GroupBox grpbPurchase;
        private System.Windows.Forms.NumericUpDown nUDQuantity;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dateTimePurchase;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Label label3;
    }
}