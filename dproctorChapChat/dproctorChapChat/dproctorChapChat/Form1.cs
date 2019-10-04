using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dproctorChapChat
{
    public partial class Form1 : Form
    {
        bool profanityFilter = false;
        public Form1()
        {
            
            NewUser startBox = new NewUser();
            DialogResult result = startBox.ShowDialog(this);
            if (result == DialogResult.OK)
            {                  
                startBox.Close();
            }            
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            NewUser username = new NewUser();
            theUsername.Items.Add(username.User());
        }

       
        
      

        private void sendButton_Click(object sender, EventArgs e)
        {
            if (this.sendMessageBox.Text != "")
            {
                IfChecked(sendMessageBox.Text);
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

            }
        }

        public void username_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void clearButton_Click_1(object sender, EventArgs e)
        {
            sendMessageBox.Clear();
        }
        private void ToHistory(String message)
        {
            if (chatHistory.Text != "")
            {
                chatHistory.AppendText(" \n" + message);
                sendMessageBox.Clear();
            }
            else
            {
                chatHistory.AppendText(message);
                sendMessageBox.Clear();
            }
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
            if (profanityFilter == true)
            {
                ToHistory(CheckProfanity.ProfanityChecker(messageText));
            }
            else
            {
                ToHistory(sendMessageBox.Text);
            }
        }
    }
}
