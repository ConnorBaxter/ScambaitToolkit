using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eventvwr
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form optionForm = new OptionsForm();
            optionForm.ShowDialog();
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Windows has detected a peer to peer remote administration tool running on this PC. To protect this machine Event Viewer has disabled some functions.\n\nTo re-enable Event Viewer go to File > Options > Disable Security",
                "Event Viewer Security",
                MessageBoxButtons.OK,
                MessageBoxIcon.Asterisk);
        }
    }
}
