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
    public partial class IdentifyingAreasForm : Form
    {
        private Dictionary<string, string> areaDict;
        private Dictionary<String, String> randomData;
        public Home previous;
        public User user;
        public DbLink dbLink;
        private int roundNumber;
        private int maxRoundNumber = 0;
        private int maxHintNumber = 0;

        private bool isCallGame = true;

        public IdentifyingAreasForm()
        {
            InitializeComponent();
            lblRoundsPlayed.Text = this.maxRoundNumber + " rounds played";
        }



        private void IdentifyingAreasForm_Load(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginForm f1 = new LoginForm();
            f1.Show();
            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            previous.Show();
            previous.loadProfile();
            this.Close();
        }

        private void btnMatch_Click(object sender, EventArgs e)
        {
            if (lstBoxA.SelectedItem == null || lstBoxB.SelectedItem == null)
            {
                MessageBox.Show("Please select an item from both columns", "Error");
            }
            else
            {
                string columnA = lstBoxA.SelectedItem.ToString();
                string columnB = lstBoxB.SelectedItem.ToString();
                if (!isCallGame)
                {
                    columnB = lstBoxA.SelectedItem.ToString();
                    columnA = lstBoxB.SelectedItem.ToString();
                }
                try
                {
                    if (areaDict[columnA].Equals(columnB))
                    {
                        MessageBox.Show("Answer Correct", "Correct");
                        lstBoxA.Items.RemoveAt(lstBoxA.SelectedIndex);
                        lstBoxB.Items.RemoveAt(lstBoxB.SelectedIndex);

                        //Add mini points
                        dbLink.updatePoints(user, "correct match in identifying areas game", 10);
                        dbLink.updateCurrency(user, "correct match in identifying areas game", 2);
                        user.updatePoints(10);
                        user.updateCurrency(2);
                        loadProfile();
                    }
                    else
                    {
                        MessageBox.Show("Answer incorrect", "Incorrect");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Couldn't find key", "Dictionary ERROR");
                    MessageBox.Show("Please Try Again", "Dictionary ERROR");
                    previous.Show();
                    previous.loadProfile();
                    this.Close();

                    return;
                }


                if (lstBoxA.Items.Count == 0)
                {
                    //Game is over

                    //Add extra points for completing entire game
                    dbLink.updatePoints(user, "Game won in identifying areas game", 50);
                    dbLink.updateCurrency(user, "Game won in identifying areas game", 20);
                    user.updatePoints(50);
                    user.updateCurrency(20);
                    loadProfile();

                    MessageBox.Show("Game Complete", "Congrats");
                    this.maxRoundNumber++;
                    lblRoundsPlayed.Text = this.maxRoundNumber + " rounds played";
                    //Hard reboot
                    loadGameData();


                }
            }
        }
        public void loadGameData()
        {
            maxHintNumber = 0;
            var rnd = new Random();

            if (rnd.Next(2) == 0)
            {
                isCallGame = false;
            }
            else
            {
                isCallGame = true;
            }


            areaDict = dbLink.getAreas(4);
            string roundText = "";

            if (roundNumber > 1)
            {

                roundText = "rounds played";
            }
            if (roundNumber <= 1)
            {

                roundText = "rounds played";
            }

            lblRoundsPlayed.Text = roundNumber.ToString() + " " + roundText;
            roundNumber++;


            var coloumnARnd = Enumerable.Range(0, areaDict.Count).OrderBy(x => rnd.Next()).Take(areaDict.Count).ToList();
            var coloumnBRnd = Enumerable.Range(0, areaDict.Count).OrderBy(x => rnd.Next()).Take(areaDict.Count).ToList();

            lstBoxA.Items.Clear();
            lstBoxB.Items.Clear();

            foreach (int x in coloumnARnd)
            {
                if (isCallGame)
                {
                    lstBoxA.Items.Add(areaDict.ElementAt(x).Key);
                }
                else
                {
                    lstBoxA.Items.Add(areaDict.ElementAt(x).Value);
                }

            }

            foreach (int x in coloumnBRnd)
            {
                if (isCallGame)
                {
                    lstBoxB.Items.Add(areaDict.ElementAt(x).Value);
                }
                else
                {
                    lstBoxB.Items.Add(areaDict.ElementAt(x).Key);
                }
            }

            randomData = dbLink.getAreas(3);
            var coloumnBTrash = Enumerable.Range(0, areaDict.Count).OrderBy(x => rnd.Next()).Take(randomData.Count).ToList();
            int count = 0;
            foreach (int x in coloumnBTrash)
            {
                if (isCallGame)
                {
                    lstBoxB.Items.Insert(x, randomData.ElementAt(count).Value);
                }
                else
                {
                    lstBoxB.Items.Insert(x, randomData.ElementAt(count).Key);
                }

                count++;
            }
        }

        public void loadProfile()
        {
            string profile = "";
            profile += "Username:\t" + user.getUsername() + "\n";
            profile += "Points:\t" + user.getTotalPoints() + "\n";
            profile += "Currency:\t" + user.getTotalCurrency() + "\n";
            txtProfile.Text = profile;
        }

        private void btnHint_Click(object sender, EventArgs e)
        {
            if (this.maxHintNumber >= randomData.Count)
            {
                //Show message
                MessageBox.Show("You can not buy hints", "Error");
                return;
            }

            //Make sure the person has the currency for a hint
            if (user.getTotalCurrency() < 10)
            {
                MessageBox.Show("You don't have enough currency", "error");
                return;
            }
            //Take away the currency for doing a hint
            dbLink.updateCurrency(user, "bought a hint at identifying areas", -10);
            user.updateCurrency(-10);
            loadProfile();

            String value = "";
            if (isCallGame)
            {
                value = randomData.ElementAt(this.maxHintNumber).Value;
            }
            else
            {
                value = randomData.ElementAt(this.maxHintNumber).Key;
            }

            //Remove this entry from the listboxB
            for (int i = 0; i < lstBoxB.Items.Count; i++)
            {
                if (lstBoxB.Items[i].ToString().Equals(value))
                {
                    lstBoxB.Items.RemoveAt(i);
                    break;
                }
            }

            this.maxHintNumber++;
        }

        private void lblRoundsPlayed_Click(object sender, EventArgs e)
        {

        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This will display a message");
        }
    }
}