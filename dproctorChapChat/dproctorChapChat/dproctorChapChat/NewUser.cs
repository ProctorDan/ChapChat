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
    
    public partial class NewUser : Form
    {

        private static string user;

        public String User()
        {
            return user;
        }

        public NewUser()
        {
            InitializeComponent();
        }

        private void Startup_Load(object sender, EventArgs e)
        {

        }

        private void okButton_Click(object sender, EventArgs e)
        {
            user = theUsername.Text;
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
                user = theUsername.Text;
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
