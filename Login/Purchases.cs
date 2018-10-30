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
    public partial class Purchases : Form
    {
        BookStore bs = BookStore.GetInstance();

        private static Purchases _purchases;
        public static Purchases PurchasesInstance
        {
            get
            {
                if (_purchases == null)
                {
                    _purchases = new Purchases();
                }
                return _purchases;
            }
        }

        private Purchases()
        {
            InitializeComponent();
            Display();
            this.ControlBox = false;
        }

        public void Display()
        {
            dGVPurchases.DataSource = bs.GetItemsTable("Purchase");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
