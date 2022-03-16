namespace Prog7312POE
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnReplacingBooks = new System.Windows.Forms.Button();
            this.btnIdentifyingAreas = new System.Windows.Forms.Button();
            this.btnFindingCallNumbers = new System.Windows.Forms.Button();
            this.lblHeadingHome = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtProfileHome = new System.Windows.Forms.RichTextBox();
            this.txtLeaderboard = new System.Windows.Forms.RichTextBox();
            this.lblProfileHeading = new System.Windows.Forms.Label();
            this.lblLeaderBoard = new System.Windows.Forms.Label();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnReplacingBooks
            // 
            this.btnReplacingBooks.BackColor = System.Drawing.Color.Lime;
            this.btnReplacingBooks.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReplacingBooks.Location = new System.Drawing.Point(64, 179);
            this.btnReplacingBooks.Name = "btnReplacingBooks";
            this.btnReplacingBooks.Size = new System.Drawing.Size(180, 100);
            this.btnReplacingBooks.TabIndex = 0;
            this.btnReplacingBooks.Text = "Replacing Books";
            this.btnReplacingBooks.UseVisualStyleBackColor = false;
            this.btnReplacingBooks.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnIdentifyingAreas
            // 
            this.btnIdentifyingAreas.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnIdentifyingAreas.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIdentifyingAreas.Location = new System.Drawing.Point(290, 179);
            this.btnIdentifyingAreas.Name = "btnIdentifyingAreas";
            this.btnIdentifyingAreas.Size = new System.Drawing.Size(180, 100);
            this.btnIdentifyingAreas.TabIndex = 1;
            this.btnIdentifyingAreas.Text = "Identifying Areas";
            this.btnIdentifyingAreas.UseVisualStyleBackColor = false;
            this.btnIdentifyingAreas.Click += new System.EventHandler(this.btnIdentifyingAreas_Click);
            // 
            // btnFindingCallNumbers
            // 
            this.btnFindingCallNumbers.BackColor = System.Drawing.Color.DarkOrange;
            this.btnFindingCallNumbers.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindingCallNumbers.Location = new System.Drawing.Point(509, 179);
            this.btnFindingCallNumbers.Name = "btnFindingCallNumbers";
            this.btnFindingCallNumbers.Size = new System.Drawing.Size(180, 100);
            this.btnFindingCallNumbers.TabIndex = 2;
            this.btnFindingCallNumbers.Text = "Finding Call Numbers";
            this.btnFindingCallNumbers.UseVisualStyleBackColor = false;
            this.btnFindingCallNumbers.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblHeadingHome
            // 
            this.lblHeadingHome.AutoSize = true;
            this.lblHeadingHome.Font = new System.Drawing.Font("Perpetua Titling MT", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeadingHome.Location = new System.Drawing.Point(349, 35);
            this.lblHeadingHome.Name = "lblHeadingHome";
            this.lblHeadingHome.Size = new System.Drawing.Size(121, 38);
            this.lblHeadingHome.TabIndex = 16;
            this.lblHeadingHome.Text = "Home";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem,
            this.logOutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.logOutToolStripMenuItem.Text = "Log out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // txtProfileHome
            // 
            this.txtProfileHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProfileHome.Location = new System.Drawing.Point(599, 56);
            this.txtProfileHome.Name = "txtProfileHome";
            this.txtProfileHome.ReadOnly = true;
            this.txtProfileHome.Size = new System.Drawing.Size(189, 105);
            this.txtProfileHome.TabIndex = 18;
            this.txtProfileHome.Text = "";
            // 
            // txtLeaderboard
            // 
            this.txtLeaderboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLeaderboard.Location = new System.Drawing.Point(139, 323);
            this.txtLeaderboard.Name = "txtLeaderboard";
            this.txtLeaderboard.ReadOnly = true;
            this.txtLeaderboard.Size = new System.Drawing.Size(489, 166);
            this.txtLeaderboard.TabIndex = 19;
            this.txtLeaderboard.Text = "";
            // 
            // lblProfileHeading
            // 
            this.lblProfileHeading.AutoSize = true;
            this.lblProfileHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfileHeading.Location = new System.Drawing.Point(596, 35);
            this.lblProfileHeading.Name = "lblProfileHeading";
            this.lblProfileHeading.Size = new System.Drawing.Size(62, 18);
            this.lblProfileHeading.TabIndex = 20;
            this.lblProfileHeading.Text = "Profile:";
            // 
            // lblLeaderBoard
            // 
            this.lblLeaderBoard.AutoSize = true;
            this.lblLeaderBoard.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLeaderBoard.Location = new System.Drawing.Point(136, 302);
            this.lblLeaderBoard.Name = "lblLeaderBoard";
            this.lblLeaderBoard.Size = new System.Drawing.Size(107, 18);
            this.lblLeaderBoard.TabIndex = 21;
            this.lblLeaderBoard.Text = "Leaderboard:";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 501);
            this.Controls.Add(this.lblLeaderBoard);
            this.Controls.Add(this.lblProfileHeading);
            this.Controls.Add(this.txtLeaderboard);
            this.Controls.Add(this.txtProfileHome);
            this.Controls.Add(this.lblHeadingHome);
            this.Controls.Add(this.btnFindingCallNumbers);
            this.Controls.Add(this.btnIdentifyingAreas);
            this.Controls.Add(this.btnReplacingBooks);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReplacingBooks;
        private System.Windows.Forms.Button btnIdentifyingAreas;
        private System.Windows.Forms.Button btnFindingCallNumbers;
        private System.Windows.Forms.Label lblHeadingHome;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.RichTextBox txtProfileHome;
        private System.Windows.Forms.RichTextBox txtLeaderboard;
        private System.Windows.Forms.Label lblProfileHeading;
        private System.Windows.Forms.Label lblLeaderBoard;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
    }
}

