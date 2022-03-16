namespace Prog7312POE
{
    partial class IdentifyingAreasForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblHeadingIdentifying = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.lstBoxA = new System.Windows.Forms.ListBox();
            this.lstBoxB = new System.Windows.Forms.ListBox();
            this.btnMatch = new System.Windows.Forms.Button();
            this.txtProfile = new System.Windows.Forms.RichTextBox();
            this.lblRoundsPlayed = new System.Windows.Forms.Label();
            this.lblProfileHeading = new System.Windows.Forms.Label();
            this.lblColumnA = new System.Windows.Forms.Label();
            this.lblColumnB = new System.Windows.Forms.Label();
            this.btnHint = new System.Windows.Forms.Button();
            this.lblInstruction = new System.Windows.Forms.Label();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
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
            // lblHeadingIdentifying
            // 
            this.lblHeadingIdentifying.AutoSize = true;
            this.lblHeadingIdentifying.Font = new System.Drawing.Font("Perpetua Titling MT", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeadingIdentifying.Location = new System.Drawing.Point(174, 37);
            this.lblHeadingIdentifying.Name = "lblHeadingIdentifying";
            this.lblHeadingIdentifying.Size = new System.Drawing.Size(367, 38);
            this.lblHeadingIdentifying.TabIndex = 8;
            this.lblHeadingIdentifying.Text = "Identifying Areas";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Red;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(17, 408);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(100, 30);
            this.btnBack.TabIndex = 9;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lstBoxA
            // 
            this.lstBoxA.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstBoxA.FormattingEnabled = true;
            this.lstBoxA.ItemHeight = 18;
            this.lstBoxA.Location = new System.Drawing.Point(19, 143);
            this.lstBoxA.Name = "lstBoxA";
            this.lstBoxA.Size = new System.Drawing.Size(240, 184);
            this.lstBoxA.TabIndex = 10;
            // 
            // lstBoxB
            // 
            this.lstBoxB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstBoxB.FormattingEnabled = true;
            this.lstBoxB.HorizontalScrollbar = true;
            this.lstBoxB.ItemHeight = 18;
            this.lstBoxB.Location = new System.Drawing.Point(303, 143);
            this.lstBoxB.Name = "lstBoxB";
            this.lstBoxB.Size = new System.Drawing.Size(240, 184);
            this.lstBoxB.TabIndex = 11;
            // 
            // btnMatch
            // 
            this.btnMatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMatch.Location = new System.Drawing.Point(453, 350);
            this.btnMatch.Name = "btnMatch";
            this.btnMatch.Size = new System.Drawing.Size(100, 30);
            this.btnMatch.TabIndex = 12;
            this.btnMatch.Text = "Match";
            this.btnMatch.UseVisualStyleBackColor = true;
            this.btnMatch.Click += new System.EventHandler(this.btnMatch_Click);
            // 
            // txtProfile
            // 
            this.txtProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProfile.Location = new System.Drawing.Point(599, 50);
            this.txtProfile.Name = "txtProfile";
            this.txtProfile.ReadOnly = true;
            this.txtProfile.Size = new System.Drawing.Size(189, 95);
            this.txtProfile.TabIndex = 15;
            this.txtProfile.Text = "";
            // 
            // lblRoundsPlayed
            // 
            this.lblRoundsPlayed.AutoSize = true;
            this.lblRoundsPlayed.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoundsPlayed.Location = new System.Drawing.Point(175, 364);
            this.lblRoundsPlayed.MaximumSize = new System.Drawing.Size(300, 0);
            this.lblRoundsPlayed.MinimumSize = new System.Drawing.Size(250, 0);
            this.lblRoundsPlayed.Name = "lblRoundsPlayed";
            this.lblRoundsPlayed.Size = new System.Drawing.Size(250, 33);
            this.lblRoundsPlayed.TabIndex = 16;
            this.lblRoundsPlayed.Text = "rounds played";
            this.lblRoundsPlayed.Click += new System.EventHandler(this.lblRoundsPlayed_Click);
            // 
            // lblProfileHeading
            // 
            this.lblProfileHeading.AutoSize = true;
            this.lblProfileHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfileHeading.Location = new System.Drawing.Point(596, 29);
            this.lblProfileHeading.Name = "lblProfileHeading";
            this.lblProfileHeading.Size = new System.Drawing.Size(62, 18);
            this.lblProfileHeading.TabIndex = 28;
            this.lblProfileHeading.Text = "Profile:";
            // 
            // lblColumnA
            // 
            this.lblColumnA.AutoSize = true;
            this.lblColumnA.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColumnA.Location = new System.Drawing.Point(16, 122);
            this.lblColumnA.Name = "lblColumnA";
            this.lblColumnA.Size = new System.Drawing.Size(81, 18);
            this.lblColumnA.TabIndex = 29;
            this.lblColumnA.Text = "Column A";
            // 
            // lblColumnB
            // 
            this.lblColumnB.AutoSize = true;
            this.lblColumnB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColumnB.Location = new System.Drawing.Point(297, 120);
            this.lblColumnB.Name = "lblColumnB";
            this.lblColumnB.Size = new System.Drawing.Size(82, 18);
            this.lblColumnB.TabIndex = 30;
            this.lblColumnB.Text = "Column B";
            // 
            // btnHint
            // 
            this.btnHint.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHint.Location = new System.Drawing.Point(19, 350);
            this.btnHint.Name = "btnHint";
            this.btnHint.Size = new System.Drawing.Size(100, 30);
            this.btnHint.TabIndex = 31;
            this.btnHint.Text = "Hint";
            this.btnHint.UseVisualStyleBackColor = true;
            this.btnHint.Click += new System.EventHandler(this.btnHint_Click);
            // 
            // lblInstruction
            // 
            this.lblInstruction.AutoSize = true;
            this.lblInstruction.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstruction.Location = new System.Drawing.Point(62, 94);
            this.lblInstruction.Name = "lblInstruction";
            this.lblInstruction.Size = new System.Drawing.Size(419, 16);
            this.lblInstruction.TabIndex = 33;
            this.lblInstruction.Text = "Please select a question from column A and an answer from column B";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // IdentifyingAreasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblInstruction);
            this.Controls.Add(this.btnHint);
            this.Controls.Add(this.lblColumnB);
            this.Controls.Add(this.lblColumnA);
            this.Controls.Add(this.lblProfileHeading);
            this.Controls.Add(this.lblRoundsPlayed);
            this.Controls.Add(this.txtProfile);
            this.Controls.Add(this.btnMatch);
            this.Controls.Add(this.lstBoxB);
            this.Controls.Add(this.lstBoxA);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblHeadingIdentifying);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "IdentifyingAreasForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Identifying Areas Game";
            this.Load += new System.EventHandler(this.IdentifyingAreasForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label lblHeadingIdentifying;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ListBox lstBoxA;
        private System.Windows.Forms.ListBox lstBoxB;
        private System.Windows.Forms.Button btnMatch;
        private System.Windows.Forms.RichTextBox txtProfile;
        private System.Windows.Forms.Label lblRoundsPlayed;
        private System.Windows.Forms.Label lblProfileHeading;
        private System.Windows.Forms.Label lblColumnA;
        private System.Windows.Forms.Label lblColumnB;
        private System.Windows.Forms.Button btnHint;
        private System.Windows.Forms.Label lblInstruction;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
    }
}