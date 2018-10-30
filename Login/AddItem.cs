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
    public partial class AddItem : Form
    {
        BookStore bs = BookStore.GetInstance();
        Store store;
        
        private static AddItem _addItem;
        public static AddItem AddItemInstance
        {
            get
            {
                if (_addItem == null)
                {
                    _addItem = new AddItem();
                }
                return _addItem;
            }
        }

        private AddItem()
        {
            InitializeComponent();
            foreach (var item in Enum.GetValues(typeof(eCategory)))
            {
                comboCategory.Items.Add(item);
            }
            grpbBook.Enabled = false;
            grpbJournal.Enabled = false;
            this.ControlBox = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (rbtnBook.Checked)
                {
                    UpdateBook();
                    ItemChanged();
                }
                else if (rbtnJournal.Checked)
                {
                    UpdateJournal();
                    ItemChanged();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UpdateBook()
        {
            store = Store.StoreInstance;
            Enum.TryParse(comboCategory.Text, out eCategory category);
            Book item = new Book(Int32.Parse(txtEdition.Text), Int32.Parse(txtIsbn.Text), txtItemName.Text, DateTime.Parse(dateTime.Text),
                                 Convert.ToDouble(txtPrice.Text), Int32.Parse(txtCopyNumber.Text), txtTopic.Text, category, Convert.ToInt32(nUDStock.Value));
            bs.UpdateBook(item, store.Id);
        }

        private void UpdateJournal()
        {
            store = Store.StoreInstance;
            Enum.TryParse(comboCategory.Text, out eCategory category);
            Journal item = new Journal(txtVolume.Text, Int32.Parse(txtIsbn.Text), txtItemName.Text, DateTime.Parse(dateTime.Text),
                                 Convert.ToDouble(txtPrice.Text), Int32.Parse(txtCopyNumber.Text), txtTopic.Text, category, Convert.ToInt32(nUDStock.Value));
            bs.UpdateJournal(item, store.Id);
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (txtCopyNumber.Text == "" || txtIsbn.Text == "" || txtItemName.Text == ""
                    || txtPrice.Text == "" || txtTopic.Text == "" ||
                    (!rbtnBook.Checked && !rbtnJournal.Checked) || comboCategory.Text == "" || Convert.ToInt32(nUDStock.Value) < 1)
                {
                    MessageBox.Show("Fill all fields correct");
                }
                else
                {
                    if (rbtnBook.Checked)
                    {
                        if (txtEdition.Text == "")
                        {
                            MessageBox.Show("Fill all book fields");
                        }
                        else
                        {
                            AddBook();
                            ItemChanged();
                        }
                    }
                    else if (rbtnJournal.Checked)
                    {
                        if (txtVolume.Text == "")
                        {
                            MessageBox.Show("Fill all journal fields");
                        }
                        else
                        {
                            AddJournal();
                            ItemChanged();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ItemChanged()
        {
            MessageBox.Show("You have successfully changed " + txtItemName.Text);
            ClearFields();
            this.Hide();
            store = Store.StoreInstance;
            store.Display();
            store.Hide();
            store.Show();
        }        

        private void AddBook()
        {
            Enum.TryParse(comboCategory.Text, out eCategory category);
            Book item = new Book(Int32.Parse(txtEdition.Text), Int32.Parse(txtIsbn.Text), txtItemName.Text, DateTime.Parse(dateTime.Text),
                                 Convert.ToDouble(txtPrice.Text), Int32.Parse(txtCopyNumber.Text), txtTopic.Text, category, Convert.ToInt32(nUDStock.Value));
            bs.AddBook(item);
        }

        private void AddJournal()
        {
            Enum.TryParse(comboCategory.Text, out eCategory category);
            Journal item = new Journal(txtVolume.Text, Int32.Parse(txtIsbn.Text), txtItemName.Text, DateTime.Parse(dateTime.Text),
                                 Convert.ToDouble(txtPrice.Text), Int32.Parse(txtCopyNumber.Text), txtTopic.Text, category, Convert.ToInt32(nUDStock.Value));
            bs.AddJournal(item);
        }

        public void ClearFields()
        {
            txtCopyNumber.Text = "";
            txtEdition.Text = "";
            txtIsbn.Text = "";
            txtItemName.Text = "";
            txtPrice.Text = "";
            txtTopic.Text = "";
            txtVolume.Text = "";
            dateTime.Text = "";
            comboCategory.Text = "";
            nUDStock.Value = 0;
            rbtnBook.Checked = false;
            rbtnJournal.Checked = false;
        }       

        private void rbtnBook_CheckedChanged_1(object sender, EventArgs e)
        {
            grpbBook.Enabled = true;
            grpbJournal.Enabled = false;
        }

        private void rbtnJournal_CheckedChanged(object sender, EventArgs e)
        {
            grpbBook.Enabled = false;
            grpbJournal.Enabled = true;
        }        

        public string PItemName
        {
            get { return txtItemName.Text; }
            set { txtItemName.Text = value; }
        }
        public string PCopyNumber
        {
            get { return txtCopyNumber.Text; }
            set { txtCopyNumber.Text = value; }
        }
        public string PEdition
        {
            get { return txtEdition.Text; }
            set { txtEdition.Text = value; }
        }

        public string PIsbn
        {
            get { return txtIsbn.Text; }
            set { txtIsbn.Text = value; }
        }

        public string PPrice
        {
            get { return txtPrice.Text; }
            set { txtPrice.Text = value; }
        }

        public string PTopic
        {
            get { return txtTopic.Text; }
            set { txtTopic.Text = value; }
        }

        public string PVolume
        {
            get { return txtVolume.Text; }
            set { txtVolume.Text = value; }
        }

        public string PDate
        {
            get { return dateTime.Text; }
            set { dateTime.Text = value; }
        }

        public string PCategory
        {
            get { return comboCategory.Text; }
            set { comboCategory.Text = value; }
        }

        public string PStock
        {
            get { return nUDStock.Text; }
            set { nUDStock.Text = value; }
        }

        public RadioButton PBook
        {
            get { return rbtnBook; }
            set { rbtnBook = value; }
        }

        public RadioButton PJournal
        {
            get { return rbtnJournal; }
            set { rbtnJournal = value; }
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

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            store = Store.StoreInstance;
            store.Show();
        }       
    }
}
