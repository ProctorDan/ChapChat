namespace dproctorChapChat
{
    partial class Form1
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
            this.sendButton = new System.Windows.Forms.Button();
            this.clearHistoryButton = new System.Windows.Forms.Button();
            this.sendGroup = new System.Windows.Forms.GroupBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.sendMessageBox = new System.Windows.Forms.RichTextBox();
            this.userLabel = new System.Windows.Forms.Label();
            this.chatHistory = new System.Windows.Forms.RichTextBox();
            this.chatHistoryBox = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.theUsername = new System.Windows.Forms.ListBox();
            this.sendGroup.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // sendButton
            // 
            this.sendButton.Location = new System.Drawing.Point(192, 66);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(75, 23);
            this.sendButton.TabIndex = 0;
            this.sendButton.Text = "Send";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // clearHistoryButton
            // 
            this.clearHistoryButton.Location = new System.Drawing.Point(199, 54);
            this.clearHistoryButton.Name = "clearHistoryButton";
            this.clearHistoryButton.Size = new System.Drawing.Size(75, 36);
            this.clearHistoryButton.TabIndex = 1;
            this.clearHistoryButton.Text = "Clear\r\nHistory";
            this.clearHistoryButton.UseVisualStyleBackColor = true;
            this.clearHistoryButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // sendGroup
            // 
            this.sendGroup.Controls.Add(this.clearButton);
            this.sendGroup.Controls.Add(this.sendMessageBox);
            this.sendGroup.Controls.Add(this.sendButton);
            this.sendGroup.Location = new System.Drawing.Point(12, 295);
            this.sendGroup.Name = "sendGroup";
            this.sendGroup.Size = new System.Drawing.Size(283, 100);
            this.sendGroup.TabIndex = 4;
            this.sendGroup.TabStop = false;
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(192, 19);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 2;
            this.clearButton.TabStop = false;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click_1);
            // 
            // sendMessageBox
            // 
            this.sendMessageBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.sendMessageBox.Location = new System.Drawing.Point(5, 13);
            this.sendMessageBox.Name = "sendMessageBox";
            this.sendMessageBox.Size = new System.Drawing.Size(181, 81);
            this.sendMessageBox.TabIndex = 1;
            this.sendMessageBox.Text = "";
            this.sendMessageBox.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            this.sendMessageBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.sendMessageBox_KeyDown);
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Location = new System.Drawing.Point(307, 54);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(55, 13);
            this.userLabel.TabIndex = 6;
            this.userLabel.Text = "Username";
            // 
            // chatHistory
            // 
            this.chatHistory.Location = new System.Drawing.Point(12, 54);
            this.chatHistory.Name = "chatHistory";
            this.chatHistory.ReadOnly = true;
            this.chatHistory.Size = new System.Drawing.Size(181, 235);
            this.chatHistory.TabIndex = 7;
            this.chatHistory.Text = "";
            // 
            // chatHistoryBox
            // 
            this.chatHistoryBox.AutoSize = true;
            this.chatHistoryBox.Location = new System.Drawing.Point(12, 38);
            this.chatHistoryBox.Name = "chatHistoryBox";
            this.chatHistoryBox.Size = new System.Drawing.Size(64, 13);
            this.chatHistoryBox.TabIndex = 8;
            this.chatHistoryBox.Text = "Chat History";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(429, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.preferencesToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // preferencesToolStripMenuItem
            // 
            this.preferencesToolStripMenuItem.Name = "preferencesToolStripMenuItem";
            this.preferencesToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.preferencesToolStripMenuItem.Text = "Preferences";
            this.preferencesToolStripMenuItem.Click += new System.EventHandler(this.preferencesToolStripMenuItem_Click);
            // 
            // theUsername
            // 
            this.theUsername.BackColor = System.Drawing.Color.LightGray;
            this.theUsername.FormattingEnabled = true;
            this.theUsername.Location = new System.Drawing.Point(309, 70);
            this.theUsername.Name = "theUsername";
            this.theUsername.Size = new System.Drawing.Size(108, 17);
            this.theUsername.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(429, 468);
            this.Controls.Add(this.theUsername);
            this.Controls.Add(this.chatHistoryBox);
            this.Controls.Add(this.chatHistory);
            this.Controls.Add(this.userLabel);
            this.Controls.Add(this.sendGroup);
            this.Controls.Add(this.clearHistoryButton);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.sendGroup.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.Button clearHistoryButton;
        private System.Windows.Forms.GroupBox sendGroup;
        private System.Windows.Forms.RichTextBox sendMessageBox;
        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.RichTextBox chatHistory;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Label chatHistoryBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preferencesToolStripMenuItem;
        private System.Windows.Forms.ListBox theUsername;
    }
}

