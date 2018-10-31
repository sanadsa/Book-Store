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
    public partial class Login : Form
    {        
        BookStore bs = BookStore.GetInstance();

        // only one instance of the login form
        private static Login _login;
        public static Login LoginInstance
        {            
            get
            {
                if (_login == null)
                {
                    _login = new Login();
                }
                return _login;
            }
        }

        private Login()
        {
            InitializeComponent();
        }     

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtEmail.Text == "" || txtPassword.Text == "")
                {
                    MessageBox.Show("Fill all fields");
                }
                else
                {
                    if (bs.IsUserExists(txtEmail.Text, txtPassword.Text))
                    {
                        MessageBox.Show("You have successfully signed in");
                        Store store = Store.StoreInstance;
                        if (bs.GetUserType(txtEmail.Text) == eUserType.employee)
                        {
                            store.PAddButton.Enabled = false;
                            store.PPurchaseButton.Enabled = false;
                            store.PUpdateButton.Enabled = false;
                        }
                        else
                        {
                            store.PAddButton.Enabled = true;
                            store.PPurchaseButton.Enabled = true;
                            store.PUpdateButton.Enabled = true;
                        }
                        this.Hide();
                        store.Show();
                    }
                    else
                    {
                        MessageBox.Show("User not exist, check email and password");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }            
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Registration rg = new Registration();
            this.Hide();
            rg.Show();
        }        
    }
}
