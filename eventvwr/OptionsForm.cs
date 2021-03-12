using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace eventvwr
{
    public partial class OptionsForm : Form
    {
        public OptionsForm()
        {
            InitializeComponent();
        }

        private void btnOkay_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDeleteFiles_Click(object sender, EventArgs e)
        {
            lblFileSize.Text = @"1.69 TB";
        }

        private void btnDisableSecurity_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This will cause event viewer to be re-enabled. Only do this if you understand the potential security risks.", "Re-enable Event Viewer", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            string response = Interaction.InputBox(
                "To prevent automated attacks please type the following 5 random words to confirm action.\n\nI am a stupid scammer",
                "Re-enable Event Viewer");

            if (response.ToLower() == "i am a stupid scammer")
            {
                MessageBox.Show("Did you really think that would work?", "Re-enabled Event Viewer", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Incorrect response to security check", "Re-enable Event Viewer", MessageBoxButtons.OK);
            }
        }
    }
}
