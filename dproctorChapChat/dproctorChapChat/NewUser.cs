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
    
    public partial class NewUser : Form
    {
        Form1 mainPage;
        
        public String User
        {
            get; set;
        }

        public NewUser()
        {
            InitializeComponent();
        }

        private void Startup_Load(object sender, EventArgs e)
        {
            Form1 mainPage = new Form1();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            
            mainPage = new Form1();
            mainPage.theUsername.Text = createUser.Text;
            this.DialogResult = DialogResult.OK;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void theUsername_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void theUsername_KeyDown(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode == Keys.Enter)
            {                
                
                this.DialogResult = DialogResult.OK;
            }
        }

    }
}
