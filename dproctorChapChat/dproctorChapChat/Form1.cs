using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChapNet;

namespace dproctorChapChat
{
    public partial class Form1 : Form, IChapChatReceiver, IDisposable
    {
        CheckProfanity checkProfanity;
        NewUser startBox;
        bool profanityFilter = false;
        delegate void MessageDelegate(string message);
        delegate void UserNameDelegate(string userName);
        ChapChatNetDriver netDriver;
        

        public Form1()
        {
            startBox = new NewUser();
            netDriver = new ChapChatNetDriver(this);
            DialogResult result = startBox.ShowDialog(this);
            UserNameDelegate userName = new UserNameDelegate(AddUsername);
            if (result == DialogResult.OK)
            {
                
                startBox.Close();
            }
            
            // netDriver.OnUserConnect();
            netDriver.SendConnect();
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            if (sendMessageBox.Text != "")
            {
                IfChecked(sendMessageBox.Text);
                sendMessageBox.Clear();
            }
            else
            {
                MessageBox.Show("Please enter your message.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sendMessageBox.Focus();
            }
        }

        private void Chat_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            chatHistory.Clear();
        }
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void sendMessageBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Shift && e.KeyCode == Keys.Enter)
            {
               
                sendMessageBox.Text.Insert(sendMessageBox.SelectionStart, Environment.NewLine);
                sendMessageBox.ScrollToCaret();
            }
            else if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                IfChecked(sendMessageBox.Text);
                sendMessageBox.Clear();

            }
        }

        public void username_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void clearButton_Click_1(object sender, EventArgs e)
        {
            sendMessageBox.Clear();
        }
        

        private void preferencesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Preferences pref = new Preferences();
            DialogResult result = pref.ShowDialog(this);
            if (result == DialogResult.OK)
            {
                if (Preferences.Profanity == true)
                {
                    MessageBox.Show("Profanity will now be hidden by *s", "Profanity OFF", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    profanityFilter = true;
                }
                else
                {
                    MessageBox.Show("Profanity is now on", "Profanity ON", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    profanityFilter = false;
                }
                pref.Close();
            }
            else if (result == DialogResult.Cancel)
            {
                pref.Close();
            }

        }
        
        private void IfChecked(string messageText)
        {
            netDriver = new ChapChatNetDriver(this);
            checkProfanity = new CheckProfanity();
            DateTime now = DateTime.Now;
            
            if (profanityFilter == true)
            {
                netDriver.SendMessage(messageText);
                chatHistory.AppendText(now + ": " + checkProfanity.ProfanityChecker(messageText));
                chatHistory.AppendText(Environment.NewLine);
            }
            else
            {
                netDriver.SendMessage(messageText);               
                chatHistory.AppendText(now + ": " + messageText);
                chatHistory.AppendText(Environment.NewLine);

            }
        }



        public void OnReceiveMessage(string sender, string receivedMessage)
        {
            DateTime now = DateTime.Now;
            this.Invoke(new MessageDelegate(chatHistory.AppendText), now + ": " + receivedMessage + Environment.NewLine);                     
        }

        public string GetUsername()
        {
            return startBox.User;            
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            netDriver.SendDisconnect();
        }

        private void AddUsername(string userName)
        {
            onlineUsersBox.Items.Add(userName);
        }

        public void theUsername_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

}
