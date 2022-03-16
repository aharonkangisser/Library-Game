using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog7312POE
{
    public partial class RegistrationForm : Form
    {
        public LoginForm previous;
        public DbLink dbLink;
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtRegisterUsername.TextLength == 0 || txtRegisterPassword.TextLength == 0 || txtRegisterName.TextLength == 0 || txtRegisterEmail.TextLength == 0)
            {
                MessageBox.Show("Please fill in all the fields", "Error");
            }
            else
            {
                User user = new User(txtRegisterUsername.Text, txtRegisterPassword.Text, txtRegisterEmail.Text, 0, txtRegisterName.Text);
                dbLink.RegisterUser(user);
                dbLink.updateCurrency(user, "initial currency for registration", 100);
                previous.Show();
                this.Close();
            }
        }

        private void btnRegisterCancel_Click(object sender, EventArgs e)
        {
            previous.Show();
            this.Close();
        }
    }
}
