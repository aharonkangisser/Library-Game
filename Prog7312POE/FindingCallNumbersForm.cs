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
  
    public partial class FindingCallNumbersForm : Form
    {
        public User user;
        public DbLink dbLink;
        public Home previous;
        private DeweyDecimalTree tree;
        private DeweyDecimalTreeNode currentNode;
        private List<DeweyDecimalTreeNode> currentAnswers;
        private DeweyDecimalTreeNode primaryParent;
        private string path;
        private int roundCount;
        private Random rnd;


        public FindingCallNumbersForm()
        {
            InitializeComponent();
            btnHint.Enabled = false;
            btnSelectAnswer.Enabled = false;
            currentAnswers = new List<DeweyDecimalTreeNode>();
            roundCount = 0;
            rnd = new Random();
            lblDescription.Text = "";
            lblPath.Text = "";
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginForm f1 = new LoginForm();
            f1.Show();
            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            previous.loadProfile();
            previous.Show();
            this.Close();
        }
        public void loadProfile()
        {
            string profile = "";
            profile += "Username:\t" + user.getUsername() + "\n";
            profile += "Points:\t" + user.getTotalPoints() + "\n";
            profile += "Currency:\t" + user.getTotalCurrency() + "\n";
            txtUserProfile.Text = profile;
        }

        private void FindingCallNumbersForm_Load(object sender, EventArgs e)
        {

        }
        private void startGame() 
        {
            btnHint.Enabled = true;
            btnSelectAnswer.Enabled = true;
            this.path = "";
            lblPath.Text = this.path;
            this.tree = dbLink.buildTree();
            currentNode = this.tree.getRandomChild(rnd);
            while (currentNode.getChildrenCount() != 0)
            {
                currentNode = currentNode.getRandomChild(rnd);

            }
            this.primaryParent = currentNode.getParent();
            while (this.primaryParent.getParent() != null)
            {
                this.primaryParent = this.primaryParent.getParent();
            }
            lblDescription.Text = "Description: \n"+ currentNode.toString();
            lstOptions.Items.Clear();
            lstOptions.Items.Add(this.primaryParent.fullToString());
            var randomList = this.tree.getRandomChildren(rnd);
            int count = 3;
            this.currentAnswers.Clear();

            int currentCount = 0;
            foreach (int index in randomList)
            {
                if (currentCount == count)
                {
                    break;
                }
                DeweyDecimalTreeNode tempNode = this.tree.getChild(index);
                if (tempNode.fullToString().Equals(this.primaryParent.fullToString()))
                {
                    continue;
                }
                this.currentAnswers.Add(tempNode);
                currentCount++;
            }
            this.currentAnswers.Add(this.primaryParent);
            GFG gg = new GFG();
            this.currentAnswers.Sort(gg);
            lstOptions.Items.Clear();
            foreach (DeweyDecimalTreeNode node in this.currentAnswers)
            {
                lstOptions.Items.Add(node.fullToString());
            }
        }
        private void btnStartGame_Click(object sender, EventArgs e)
        {
            startGame();
        }

        private void btnSelectAnswer_Click(object sender, EventArgs e)
        {
            int index = lstOptions.SelectedIndex;
            if (index < 0)
            {
                MessageBox.Show("Please select an answer");
            }
            else
            {
                DeweyDecimalTreeNode selectedNode = this.currentAnswers.ElementAt<DeweyDecimalTreeNode>(index);
                if (selectedNode.getCallNumber() == this.primaryParent.getCallNumber())
                {
                    MessageBox.Show("Answer Correct");
                    dbLink.updatePoints(user, "answer correct, FInding call numbers Game", 10);
                    dbLink.updateCurrency(user, "answer correct, FInding call numbers Game", 2);
                    user.updatePoints(10);
                    user.updateCurrency(2);
                    loadProfile();
                    //mke sure that primary parent is not yet current node.
                    path = path + "→ " + this.primaryParent.fullToString() + "\n";
                    lblPath.Text = "Path: \n" + path;
                    if (this.primaryParent.getCallNumber() == this.currentNode.getCallNumber())
                    {
                        MessageBox.Show("Game complete");
                        dbLink.updatePoints(user, "round won, Finding call numbers Game", 50);
                        dbLink.updateCurrency(user, "round won, finding call numbers Game", 5);
                        user.updatePoints(50);
                        user.updateCurrency(5);
                        loadProfile();
                        roundCount++;
                        lblRoundCounter.Text = roundCount + " rounds played";
                        startGame();
                    }
                    else 
                    {
                        //700 - primaryPartent
                        //752  - current node = parent = 750 710 720 750
                        //1. Find the corret parent, which will become the correct answer
                        //2. Generate three incorrect answers
                        //3. Add to list for questions

                        DeweyDecimalTreeNode nextParent = this.primaryParent.findClosestChild(this.currentNode);
                        
                        var randomList = this.primaryParent.getRandomChildren(rnd);
                        int count = 3;
                        this.currentAnswers.Clear();

                        int currentCount = 0;
                        foreach (int entry in randomList)
                        {
                            if (currentCount == count)
                            {
                                break;
                            }
                            DeweyDecimalTreeNode tempNode = this.primaryParent.getChild(entry);
                            if (tempNode.getCallNumber() == nextParent.getCallNumber())
                            {
                                continue;
                            }
                            this.currentAnswers.Add(tempNode);
                            currentCount++;
                        }
                        this.primaryParent = nextParent;
                        this.currentAnswers.Add(this.primaryParent);
                        GFG gg = new GFG();
                        this.currentAnswers.Sort(gg);
                        lstOptions.Items.Clear();
                        foreach (DeweyDecimalTreeNode node in this.currentAnswers)
                        {
                            lstOptions.Items.Add(node.fullToString());
                        }
                    }
                }
                else 
                {
                    MessageBox.Show("Answer incorrect");
                    MessageBox.Show("Please start again");
                    startGame();
                }
            }

        }

        private void btnHint_Click(object sender, EventArgs e)
        {
            if ( this.currentAnswers.Count == 1)
            {
                MessageBox.Show("You can not buy more hints for this round", "error");
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


            int count = 0;
            foreach(DeweyDecimalTreeNode node in this.currentAnswers)
            {
                if (node.getCallNumber() == this.primaryParent.getCallNumber())
                {
                    count++;
                    continue;
                }
                break;
            }
            this.currentAnswers.RemoveAt(count);
            lstOptions.Items.RemoveAt(count);
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This will display a help message");
        }
    }
}
