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
    public partial class ReplacingBooksForm : Form
    {
        public User user;
        public DbLink dbLink;
        public Home previous;
        private List<DeweyDecimal> ddList;
        private List<DeweyDecimal> sortedList;
        private int roundNumber;
        private int maxRoundNumber;
        public ReplacingBooksForm()
        {
            InitializeComponent();
            btnSubmit.Enabled = false;
            btnHint.Enabled = false;
            btnUp.Enabled = false;
            btnDown.Enabled = false;
            roundNumber = 0;
            maxRoundNumber = 5;
        }

        //this method control the up button and moves the item selcted up 1 slot on the list
        private void btnUp_Click(object sender, EventArgs e)
        {
            int selected = lstList.SelectedIndex;
            if (selected > 0)
            {
                //move up
                var item = lstList.SelectedItem;
                lstList.Items.Remove(item);
                lstList.Items.Insert(selected - 1, item);
                lstList.SelectedIndex = selected - 1;

                var newItem = ddList[selected];
                ddList.Remove(newItem);
                ddList.Insert(selected - 1, newItem);
            }

        }
        //this method control the down button and moves the item selcted down 1 slot on the list
        private void btnDown_Click(object sender, EventArgs e)
        {
            int selected = lstList.SelectedIndex;
            if (selected > 0 && selected != lstList.Items.Count - 1)
            {
                //move down
                var item = lstList.SelectedItem;
                lstList.Items.Remove(item);
                lstList.Items.Insert(selected + 1, item);
                lstList.SelectedIndex = selected + 1;

                var newItem = ddList[selected];
                ddList.Remove(newItem);
                ddList.Insert(selected + 1, newItem);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            previous.loadProfile();
            previous.Show();
            this.Close();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginForm f1 = new LoginForm();
             f1.Show();
            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //Compare answers
            Boolean correct = true;
            int count = 0;
            /*
             * if (lstList.Items.Count == 0)
            {
                MessageBox.Show("Please press start game", "Error");
            }
            */
            //this checks if the sorted list is equal to the original list
            for (int i = 0; i < ddList.Count; i++)
            {
                if (ddList[i] != sortedList[i])
                {
                    correct = false;
                    count++;
                }
            }

            if (correct)
                {
                //this shows the player they got it correct as well as adds points and currency
                    MessageBox.Show("Correct", "Success");
                    dbLink.updatePoints(user, "round won, Replacing Books Game", 50);
                    dbLink.updateCurrency(user, "round won, Replacing Books Game", 5);
                    user.updatePoints(50);
                    user.updateCurrency(5);
                    loadProfile();
                    if (roundNumber == maxRoundNumber)
                    {
                        gameProgress.Value = 100;
                        MessageBox.Show("Congrats you have finished all the games for today!", "Congrats");
                        dbLink.updatePoints(user, "Game won, Replacing Books Game", 250);
                        dbLink.updateCurrency(user, "Game won, Replacing Books Game", 25);
                        user.updatePoints(250);
                        user.updateCurrency(50);
                        loadProfile();
                    }
                    else
                    {
                        loadGame();
                    }

                }
                else
                {
                    MessageBox.Show("Incorrect", "Fail");
                }
            
        }
        //this method starts the game and populates the list with call numbers
        private void btnStartGame_Click(object sender, EventArgs e)
        {
            loadGame();
            btnSubmit.Enabled=true;
            btnHint.Enabled=true;
            btnUp.Enabled=true;
            btnDown.Enabled=true;
        }
        //this methods populates the list with call numbers
        private void loadGame()
        {
            double value = (double)roundNumber / (double)maxRoundNumber;
            int finalvalue = (int)Math.Round(value * 100);
            gameProgress.Value = finalvalue;
            roundNumber++;
            sortedList = new List<DeweyDecimal>();

            ddList = dbLink.generateReplacingBookList(10);
            lstList.Items.Clear();
            for (int i = 0; i < ddList.Count; i++)
            {
                lstList.Items.Add(ddList[i].getCallNumber());
                sortedList.Add(ddList[i]);

            }
            sortedList = dbLink.sortCallNumbers(sortedList);
        }
        //this method is used to update the list with the moved item in the list that the user selects by removing it and re-inserting it back in the list in the posisiton that the player leaves it in
        private Boolean swapTiles(int swapNumber)
        {
            if (ddList[swapNumber] == sortedList[swapNumber])
            {
                return false;
            }

            var swapItem = sortedList[swapNumber];
            ddList.Remove(swapItem);
            ddList.Insert(swapNumber, swapItem);

            for (int i = 0; i < lstList.Items.Count; i++)
            {
                if (lstList.Items[i].ToString().Equals(swapItem.getCallNumber()))
                {
                    var listItem = lstList.Items[i];
                    lstList.Items.Remove(listItem);
                    lstList.Items.Insert(swapNumber, listItem);
                    break;
                }
            }


            return true;
        }

        private void btnHint_Click(object sender, EventArgs e)
        {
            if (user.getTotalCurrency() >= 10)
            {
                //Look for x tiles that are wrong, swap them with the correct answer.
                dbLink.updateCurrency(user, "currency used on hint", -10);
                user.updateCurrency(-10);
                loadProfile();

                int swapNumber = 2;
                int currentSwap = 0;
                int swapTryCount = 0;
                Random random = new Random();

                while (currentSwap < swapNumber && swapTryCount < 50)
                {
                    int swapTile = random.Next(ddList.Count);
                    if (swapTiles(swapTile))
                    {
                        currentSwap++;
                    }
                    swapTryCount++;
                }
            }
            else
            {
                MessageBox.Show("You don't have enough currency", "error");
            }
        }
        public void loadProfile()
        {
            string profile = "";
            profile += "Username:\t" + user.getUsername() + "\n";
            profile += "Points:\t" + user.getTotalPoints() + "\n";
            profile += "Currency:\t" + user.getTotalCurrency() + "\n";
            txtUserProfile.Text = profile;
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This will display a message");
        }
    }
}
