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
    public partial class Home : Form
    {
        public DbLink dbLink;
        public User user;
        public LoginForm previous;
        public Home()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {            
            ReplacingBooksForm form = new ReplacingBooksForm();
            form.user = user;
            form.dbLink = dbLink;
            form.previous = this;
            form.loadProfile();
            form.Show();
            this.Hide();            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginForm l1 = new LoginForm();
            l1.Show();
            this.Close();
        }

        private void btnIdentifyingAreas_Click(object sender, EventArgs e)
        {
            IdentifyingAreasForm I1 = new IdentifyingAreasForm();
            I1.user = user;
            I1.previous = this;
            I1.dbLink = dbLink;
            I1.loadProfile();
            I1.loadGameData();
            I1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FindingCallNumbersForm f1 = new FindingCallNumbersForm();
            f1.user = user;
            f1.previous = this;
            f1.dbLink = dbLink;
            f1.loadProfile();
            f1.Show();
            this.Hide();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }
        public void loadProfile()
        {
            string profile = "";
            profile += "Username:\t" + user.getUsername() + "\n";
            profile += "Points:\t\t" + user.getTotalPoints() + "\n";
            profile += "Currency:\t" + user.getTotalCurrency() + "\n";
            txtProfileHome.Text = profile;
            txtLeaderboard.Text = dbLink.getLeaderBoard();            
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This will show a help message");
        }
    }
}
