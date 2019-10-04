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
    public partial class Preferences : Form
    {
        
        
        public Preferences()
        {
            InitializeComponent();

        }

        public static Boolean Profanity
        {
            get; set;
        }

        private void Preferences_Load(object sender, EventArgs e)
        {

        }

        private void okButton_Click(object sender, EventArgs e)
        {
            Profanity = profanityFilter.Checked;
            this.DialogResult = DialogResult.OK;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void okButton_KeyDown(object sender, KeyEventArgs e)
        {
            Profanity = profanityFilter.Checked;
            this.DialogResult = DialogResult.OK;
        }

        private void profanityFilter_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
