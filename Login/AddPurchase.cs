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
    public partial class AddPurchase : Form
    {
        BookStore bs = BookStore.GetInstance();
        Store store;
        private Book book;
        private Journal journal;
        private string itemType;
        private static AddPurchase _pruchase;
        public static AddPurchase PurchaseInstance
        {
            get
            {
                if (_pruchase == null)
                {
                    _pruchase = new AddPurchase();
                }
                return _pruchase;
            }
        }

        private AddPurchase()
        {
            InitializeComponent();
            txtItemName.Enabled = false;
            txtPrice.Enabled = false;
            txtStock.Enabled = false;
            this.ControlBox = false;
        }

        public string PItemName
        {
            get { return txtItemName.Text; }
            set { txtItemName.Text = value; }
        }

        public string PPrice
        {
            get { return txtPrice.Text; }
            set { txtPrice.Text = value; }
        }

        public string PStock
        {
            get { return txtStock.Text; }
            set { txtStock.Text = value; }
        }

        public string PItemType
        {
            get { return itemType; }
            set { itemType = value; }
        }

        public Book PBook
        {
            get { return book; }
            set { book = value; }
        }

        public Journal PJournal
        {
            get { return journal; }
            set { journal = value; }
        }

        private void btnSell_Click(object sender, EventArgs e)
        {
            try
            {
                int maxToSell = Int32.Parse(txtStock.Text);
                int newStock = maxToSell - Convert.ToInt32(nUDQuantity.Value);
                if (txtCustomerName.Text == "" || txtItemName.Text == "" || txtPrice.Text == "")
                {
                    MessageBox.Show("Fill all fields correct");
                }
                else if (Convert.ToInt32(nUDQuantity.Value) == 0 || Convert.ToInt32(nUDQuantity.Value) > maxToSell)
                {
                    MessageBox.Show("Quantity must be between 1 and  " + txtStock.Text);
                }
                else
                {
                    store = Store.StoreInstance;
                    Purchase purchase = new Purchase(txtCustomerName.Text, txtItemName.Text, Convert.ToDouble(txtPrice.Text), Convert.ToInt32(nUDQuantity.Value), DateTime.Parse(dateTimePurchase.Text));
                    bs.AddPurchase(purchase);                   
                    if (itemType == "Book")
                    {
                        bs.SellBook(store.Id, newStock);
                    }
                    else if (itemType == "Journal")
                    {
                        bs.SellJournal(store.Id, newStock);
                    }                    
                    MessageBox.Show("You have successfully selled " + txtItemName.Text + " to " + txtCustomerName.Text);
                    store.Display();
                    ClearFields();
                    AddItem add = AddItem.AddItemInstance;
                    add.ClearFields();
                    this.Hide();                    
                    store.Hide();
                    store.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void ClearFields()
        {
            txtItemName.Text = "";
            txtPrice.Text = "";
            txtCustomerName.Text = "";
            txtStock.Text = "";
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            store = Store.StoreInstance;
            store.Show();
        }
    }
}
