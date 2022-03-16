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
    public partial class LoginForm : Form
    {
        public DbLink dbLink; 
        public LoginForm()
        {
            InitializeComponent();
            dbLink = new DbLink();
            dbLink.connect();
            txtLoginPassword.Text = "password";
            txtLoginUsername.Text = "user10";

            DeweyDecimalTree tree = dbLink.buildTree();
            int x = 0;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            string username = txtLoginUsername.Text;
            string password = txtLoginPassword.Text;
            if (dbLink.autenticateUser(username, password))
            {
                User user = dbLink.getUser(username);
                Home h1 = new Home();
                h1.user = user;
                h1.dbLink = dbLink;
                h1.previous = this;
                h1.loadProfile();
                h1.Show();
                this.Hide();
            }
            else {
                MessageBox.Show("Incorrect username or password", "Error");
            }
            
            
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegistrationForm f1 = new RegistrationForm();
            f1.dbLink = dbLink;
            f1.previous = this;
            f1.Show();
            this.Hide();
            
        }

        private void btnLoginCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
