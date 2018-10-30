using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using BookLib;

namespace Login
{
    public partial class Registration : Form
    {
        BookStore bs = BookStore.GetInstance();
        public Registration()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtEmail.Text == "" || txtPassword.Text == "" || (!rbtnAdmin.Checked && !rbtnEmployee.Checked))
            {
                MessageBox.Show("Fill all fields");
            }
            else
            {
                try
                {
                    eUserType userType;
                    if (rbtnAdmin.Checked)
                    {
                        userType = eUserType.admin;
                    }
                    else
                    {
                        userType = eUserType.employee;
                    }
                    User user = new User(txtName.Text, txtEmail.Text, txtPassword.Text, userType);

                    bs.AddUser(user);
                    txtName.Text = "";
                    txtEmail.Text = "";
                    txtPassword.Text = "";

                    Login login = Login.LoginInstance;
                    this.Hide();
                    login.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }    
    }
}
