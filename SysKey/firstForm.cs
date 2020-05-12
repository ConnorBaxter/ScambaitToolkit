using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SysKey
{
    public partial class firstForm : Form
    {
        public firstForm()
        {
            InitializeComponent();
        }

        private void SwapRadio()
        {
            if (rbEnabled.Checked)
            {
                rbDisabled.Checked = false;
                rbEnabled.Checked = true;

                btnUpdate.Enabled = false;
            }
            else
            {
                rbDisabled.Checked = true;
                rbEnabled.Checked = false;

                btnUpdate.Enabled = true;
            }
        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            SwapRadio();
        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            SwapRadio();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            UpdateForm uf = new UpdateForm();
            DialogResult dr = uf.ShowDialog();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
