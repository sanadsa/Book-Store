namespace Login
{
    partial class Store
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
            this.grpbItems = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dGVJournals = new System.Windows.Forms.DataGridView();
            this.lblBook = new System.Windows.Forms.Label();
            this.dGVBooks = new System.Windows.Forms.DataGridView();
            this.grpbOperations = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSell = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BottomToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.TopToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.RightToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.LeftToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.ContentPanel = new System.Windows.Forms.ToolStripContentPanel();
            this.btnPurchase = new System.Windows.Forms.Button();
            this.grpbItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVJournals)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVBooks)).BeginInit();
            this.grpbOperations.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpbItems
            // 
            this.grpbItems.Controls.Add(this.label2);
            this.grpbItems.Controls.Add(this.dGVJournals);
            this.grpbItems.Controls.Add(this.lblBook);
            this.grpbItems.Controls.Add(this.dGVBooks);
            this.grpbItems.Location = new System.Drawing.Point(13, 29);
            this.grpbItems.Name = "grpbItems";
            this.grpbItems.Size = new System.Drawing.Size(581, 508);
            this.grpbItems.TabIndex = 0;
            this.grpbItems.TabStop = false;
            this.grpbItems.Text = "Items";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 252);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Journals:";
            // 
            // dGVJournals
            // 
            this.dGVJournals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVJournals.Location = new System.Drawing.Point(6, 276);
            this.dGVJournals.Name = "dGVJournals";
            this.dGVJournals.Size = new System.Drawing.Size(569, 212);
            this.dGVJournals.TabIndex = 11;
            this.dGVJournals.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVJournals_CellClick);
            // 
            // lblBook
            // 
            this.lblBook.AutoSize = true;
            this.lblBook.Location = new System.Drawing.Point(7, 20);
            this.lblBook.Name = "lblBook";
            this.lblBook.Size = new System.Drawing.Size(40, 13);
            this.lblBook.TabIndex = 10;
            this.lblBook.Text = "Books:";
            // 
            // dGVBooks
            // 
            this.dGVBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVBooks.Location = new System.Drawing.Point(6, 44);
            this.dGVBooks.Name = "dGVBooks";
            this.dGVBooks.Size = new System.Drawing.Size(569, 198);
            this.dGVBooks.TabIndex = 9;
            this.dGVBooks.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVBooks_CellClick);
            // 
            // grpbOperations
            // 
            this.grpbOperations.Controls.Add(this.btnPurchase);
            this.grpbOperations.Controls.Add(this.btnUpdate);
            this.grpbOperations.Controls.Add(this.btnSell);
            this.grpbOperations.Controls.Add(this.btnAdd);
            this.grpbOperations.Location = new System.Drawing.Point(600, 29);
            this.grpbOperations.Name = "grpbOperations";
            this.grpbOperations.Size = new System.Drawing.Size(164, 231);
            this.grpbOperations.TabIndex = 1;
            this.grpbOperations.TabStop = false;
            this.grpbOperations.Text = "Operations";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(6, 76);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(152, 37);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSell
            // 
            this.btnSell.Location = new System.Drawing.Point(6, 124);
            this.btnSell.Name = "btnSell";
            this.btnSell.Size = new System.Drawing.Size(152, 37);
            this.btnSell.TabIndex = 2;
            this.btnSell.Text = "Sell";
            this.btnSell.UseVisualStyleBackColor = true;
            this.btnSell.Click += new System.EventHandler(this.btnSell_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(6, 26);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(152, 37);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add Item";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(776, 24);
            this.menuStrip1.TabIndex = 2;
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
            // BottomToolStripPanel
            // 
            this.BottomToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.BottomToolStripPanel.Name = "BottomToolStripPanel";
            this.BottomToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.BottomToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.BottomToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // TopToolStripPanel
            // 
            this.TopToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.TopToolStripPanel.Name = "TopToolStripPanel";
            this.TopToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.TopToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.TopToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // RightToolStripPanel
            // 
            this.RightToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.RightToolStripPanel.Name = "RightToolStripPanel";
            this.RightToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.RightToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.RightToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // LeftToolStripPanel
            // 
            this.LeftToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftToolStripPanel.Name = "LeftToolStripPanel";
            this.LeftToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.LeftToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.LeftToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // ContentPanel
            // 
            this.ContentPanel.Size = new System.Drawing.Size(150, 150);
            // 
            // btnPurchase
            // 
            this.btnPurchase.Location = new System.Drawing.Point(6, 176);
            this.btnPurchase.Name = "btnPurchase";
            this.btnPurchase.Size = new System.Drawing.Size(152, 37);
            this.btnPurchase.TabIndex = 3;
            this.btnPurchase.Text = "Purhcase History";
            this.btnPurchase.UseVisualStyleBackColor = true;
            this.btnPurchase.Click += new System.EventHandler(this.btnPurchase_Click);
            // 
            // Store
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(776, 549);
            this.Controls.Add(this.grpbOperations);
            this.Controls.Add(this.grpbItems);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Store";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Store";
            this.grpbItems.ResumeLayout(false);
            this.grpbItems.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVJournals)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVBooks)).EndInit();
            this.grpbOperations.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbItems;
        private System.Windows.Forms.DataGridView dGVBooks;
        private System.Windows.Forms.GroupBox grpbOperations;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSell;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dGVJournals;
        private System.Windows.Forms.Label lblBook;
        private System.Windows.Forms.ToolStripPanel BottomToolStripPanel;
        private System.Windows.Forms.ToolStripPanel TopToolStripPanel;
        private System.Windows.Forms.ToolStripPanel RightToolStripPanel;
        private System.Windows.Forms.ToolStripPanel LeftToolStripPanel;
        private System.Windows.Forms.ToolStripContentPanel ContentPanel;
        private System.Windows.Forms.Button btnPurchase;
    }
}