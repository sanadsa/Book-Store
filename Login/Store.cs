using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookLib;

namespace Login
{
    public partial class Store : Form
    {
        BookStore bs = BookStore.GetInstance();
        int ID;
        AddItem addItem = AddItem.AddItemInstance;
        AddPurchase addPurchase = AddPurchase.PurchaseInstance;
        Purchases purchases = Purchases.PurchasesInstance;

        private static Store _store;
        public static Store StoreInstance
        {            
            get
            {
                if (_store == null)
                {
                    _store = new Store();
                }
                return _store;
            }
        }

        private Store()
        {
            InitializeComponent();                    
            Display();
            this.ControlBox = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            addItem.ClearFields();
            addItem.Show();
            addItem.PUpdateButton.Visible = false;
            addItem.PAddButton.Visible = true;
        }

        //private void AddItemType(int itemId)
        //{
        //    if (rbtnBook.Checked)
        //    {
        //        if (txtEdition.Text == "")
        //        {
        //            MessageBox.Show("Fill all fields");
        //        }
        //        else
        //        {
        //            Book book = new Book((int.Parse(txtEdition.Text)));
        //            bs.AddBook(book, itemId);
        //        }
        //    }
        //    else if (rbtnJournal.Checked)
        //    {
        //        if (txtVolume.Text == "")
        //        {
        //            MessageBox.Show("Fill all fields");
        //        }
        //        else
        //        {
        //            Journal journal = new Journal(txtVolume.Text);
        //            bs.AddJournal(journal, itemId);
        //        }
        //    }
        //}       

        public void Display()
        {
            dGVBooks.DataSource = bs.GetItemsTable("Book");
            dGVJournals.DataSource = bs.GetItemsTable("Journal");
        }

        public DataGridView getGrid()
        {
            return dGVBooks;
        }
  
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            this.Hide();
            Login login = Login.LoginInstance;
            login.Show();                      
        }

        private void dGVBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            FillItemValues(dGVBooks, e);
            addItem.PEdition = dGVBooks.Rows[e.RowIndex].Cells[9].Value.ToString();
            addItem.PBook.Checked = true;
            addPurchase.PItemType = "Book";
        }

        private void dGVJournals_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            FillItemValues(dGVJournals, e);
            addItem.PVolume = dGVJournals.Rows[e.RowIndex].Cells[9].Value.ToString();
            addItem.PJournal.Checked = true;
            addPurchase.PItemType = "Journal";
        }

        private void FillItemValues(DataGridView dgv, DataGridViewCellEventArgs e)
        {
            ID = int.Parse(dgv.Rows[e.RowIndex].Cells[0].Value.ToString());
            addItem.PIsbn = dgv.Rows[e.RowIndex].Cells[1].Value.ToString();
            addItem.PItemName = dgv.Rows[e.RowIndex].Cells[2].Value.ToString();
            addItem.PDate = dgv.Rows[e.RowIndex].Cells[3].Value.ToString();
            addItem.PPrice = dgv.Rows[e.RowIndex].Cells[4].Value.ToString();
            addItem.PCopyNumber = dgv.Rows[e.RowIndex].Cells[5].Value.ToString();
            addItem.PTopic = dgv.Rows[e.RowIndex].Cells[6].Value.ToString();
            addItem.PCategory = dgv.Rows[e.RowIndex].Cells[7].Value.ToString();
            addItem.PStock = dgv.Rows[e.RowIndex].Cells[8].Value.ToString();

            addPurchase.PItemName = dgv.Rows[e.RowIndex].Cells[2].Value.ToString();
            addPurchase.PPrice = dgv.Rows[e.RowIndex].Cells[4].Value.ToString();
            addPurchase.PStock = dgv.Rows[e.RowIndex].Cells[8].Value.ToString();
        }        

        public int Id
        {
            get { return ID; }
            set { ID = value; }
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (addItem.PItemName != "")
            {
                addItem.Show();
                addItem.PAddButton.Visible = false;
                addItem.PUpdateButton.Visible = true;
            }
            else
            {
                MessageBox.Show("Click row to update");
            }
        }

        private void btnSell_Click(object sender, EventArgs e)
        {
            try
            {
                if (addPurchase.PItemName != "")
                {
                    if (Int32.Parse(addPurchase.PStock) > 0)
                    {
                        addPurchase.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Click item to sell");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnPurchase_Click(object sender, EventArgs e)
        {
            purchases.Display();
            purchases.Show();
        }

        public Button PAddButton
        {
            get { return btnAdd; }
            set { btnAdd = value; }
        }

        public Button PUpdateButton
        {
            get { return btnUpdate; }
            set { btnUpdate = value; }
        }

        public Button PPurchaseButton
        {
            get { return btnPurchase; }
            set { btnPurchase = value; }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dGVBooks.DataSource = bs.SearchItem("Book", txtSearchByName.Text, "itemName");
            dGVJournals.DataSource = bs.SearchItem("Journal", txtSearchByName.Text, "itemName");
        }

        private void txtSearchByIsbn_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtSearchByIsbn.Text == "")
                {
                    dGVBooks.DataSource = bs.SearchItemByIsbn("Book", 0);
                    dGVJournals.DataSource = bs.SearchItemByIsbn("Journal", 0);
                }
                else
                {
                    dGVBooks.DataSource = bs.SearchItemByIsbn("Book", Convert.ToInt32(txtSearchByIsbn.Text));
                    dGVJournals.DataSource = bs.SearchItemByIsbn("Journal", Convert.ToInt32(txtSearchByIsbn.Text));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
