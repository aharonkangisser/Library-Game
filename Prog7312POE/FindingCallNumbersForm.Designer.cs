namespace Prog7312POE
{
    partial class FindingCallNumbersForm
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
            this.lblHeadingFinding = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnBack = new System.Windows.Forms.Button();
            this.txtUserProfile = new System.Windows.Forms.RichTextBox();
            this.lblProfileHeading = new System.Windows.Forms.Label();
            this.lstOptions = new System.Windows.Forms.ListBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblPath = new System.Windows.Forms.Label();
            this.btnSelectAnswer = new System.Windows.Forms.Button();
            this.btnStartGame = new System.Windows.Forms.Button();
            this.lblRoundCounter = new System.Windows.Forms.Label();
            this.btnHint = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHeadingFinding
            // 
            this.lblHeadingFinding.AutoSize = true;
            this.lblHeadingFinding.Font = new System.Drawing.Font("Perpetua Titling MT", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeadingFinding.Location = new System.Drawing.Point(196, 38);
            this.lblHeadingFinding.Name = "lblHeadingFinding";
            this.lblHeadingFinding.Size = new System.Drawing.Size(444, 38);
            this.lblHeadingFinding.TabIndex = 9;
            this.lblHeadingFinding.Text = "Finding Call Numbers";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 10;
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
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.logOutToolStripMenuItem.Text = "Log out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click_1);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Red;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(12, 405);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(130, 33);
            this.btnBack.TabIndex = 11;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // txtUserProfile
            // 
            this.txtUserProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserProfile.Location = new System.Drawing.Point(599, 112);
            this.txtUserProfile.Name = "txtUserProfile";
            this.txtUserProfile.Size = new System.Drawing.Size(189, 95);
            this.txtUserProfile.TabIndex = 12;
            this.txtUserProfile.Text = "";
            // 
            // lblProfileHeading
            // 
            this.lblProfileHeading.AutoSize = true;
            this.lblProfileHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfileHeading.Location = new System.Drawing.Point(596, 91);
            this.lblProfileHeading.Name = "lblProfileHeading";
            this.lblProfileHeading.Size = new System.Drawing.Size(62, 18);
            this.lblProfileHeading.TabIndex = 21;
            this.lblProfileHeading.Text = "Profile:";
            // 
            // lstOptions
            // 
            this.lstOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstOptions.FormattingEnabled = true;
            this.lstOptions.HorizontalScrollbar = true;
            this.lstOptions.ItemHeight = 18;
            this.lstOptions.Location = new System.Drawing.Point(13, 112);
            this.lstOptions.Name = "lstOptions";
            this.lstOptions.Size = new System.Drawing.Size(234, 166);
            this.lstOptions.TabIndex = 22;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(253, 128);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(83, 18);
            this.lblDescription.TabIndex = 23;
            this.lblDescription.Text = "Description";
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPath.Location = new System.Drawing.Point(256, 189);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(38, 18);
            this.lblPath.TabIndex = 24;
            this.lblPath.Text = "Path";
            // 
            // btnSelectAnswer
            // 
            this.btnSelectAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectAnswer.Location = new System.Drawing.Point(259, 273);
            this.btnSelectAnswer.Name = "btnSelectAnswer";
            this.btnSelectAnswer.Size = new System.Drawing.Size(146, 35);
            this.btnSelectAnswer.TabIndex = 25;
            this.btnSelectAnswer.Text = "Select Answer";
            this.btnSelectAnswer.UseVisualStyleBackColor = true;
            this.btnSelectAnswer.Click += new System.EventHandler(this.btnSelectAnswer_Click);
            // 
            // btnStartGame
            // 
            this.btnStartGame.BackColor = System.Drawing.Color.LimeGreen;
            this.btnStartGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartGame.Location = new System.Drawing.Point(658, 405);
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.Size = new System.Drawing.Size(130, 33);
            this.btnStartGame.TabIndex = 26;
            this.btnStartGame.Text = "Start Game";
            this.btnStartGame.UseVisualStyleBackColor = false;
            this.btnStartGame.Click += new System.EventHandler(this.btnStartGame_Click);
            // 
            // lblRoundCounter
            // 
            this.lblRoundCounter.AutoSize = true;
            this.lblRoundCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoundCounter.Location = new System.Drawing.Point(368, 389);
            this.lblRoundCounter.Name = "lblRoundCounter";
            this.lblRoundCounter.Size = new System.Drawing.Size(0, 25);
            this.lblRoundCounter.TabIndex = 27;
            // 
            // btnHint
            // 
            this.btnHint.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHint.Location = new System.Drawing.Point(259, 314);
            this.btnHint.Name = "btnHint";
            this.btnHint.Size = new System.Drawing.Size(77, 29);
            this.btnHint.TabIndex = 28;
            this.btnHint.Text = "Hint";
            this.btnHint.UseVisualStyleBackColor = true;
            this.btnHint.Click += new System.EventHandler(this.btnHint_Click);
            // 
            // FindingCallNumbersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnHint);
            this.Controls.Add(this.lblRoundCounter);
            this.Controls.Add(this.btnStartGame);
            this.Controls.Add(this.btnSelectAnswer);
            this.Controls.Add(this.lblPath);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lstOptions);
            this.Controls.Add(this.lblProfileHeading);
            this.Controls.Add(this.txtUserProfile);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblHeadingFinding);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FindingCallNumbersForm";
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Finding Call Numbers Game";
            this.Load += new System.EventHandler(this.FindingCallNumbersForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeadingFinding;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.RichTextBox txtUserProfile;
        private System.Windows.Forms.Label lblProfileHeading;
        private System.Windows.Forms.ListBox lstOptions;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.Button btnSelectAnswer;
        private System.Windows.Forms.Button btnStartGame;
        private System.Windows.Forms.Label lblRoundCounter;
        private System.Windows.Forms.Button btnHint;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
    }
}