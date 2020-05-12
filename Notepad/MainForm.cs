﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notepad
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtMain.Clear();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void formatToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form FontDialog = new FontForm();
            FontDialog.ShowDialog();
            if (FontDialog.DialogResult == DialogResult.OK)
            {
                string[] data = FontDialog.Text.Split(',');
                if(data.Length != 3) throw new Exception("Error in response data!");

                string fontName = data[0];
                string fontStyle = data[1];
                string fontSize = data[2];

                FontStyle fontEnum;
                bool fontSty = Enum.TryParse(fontStyle, out fontEnum);

                Font f = new Font(new FontFamily(fontName), float.Parse(fontSize), fontEnum);
                txtMain.Font = f;
            }
        }

        private void txtMain_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMain_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtMain.AppendText("\n\n\n");
            }

            if (e.KeyCode == Keys.Space)
            {
                txtMain.AppendText("  ");
            }

            if (e.KeyCode == Keys.Subtract || e.KeyCode == Keys.OemMinus)
            {
                e.Handled = true;
                txtMain.AppendText("_");
            }

            if (e.KeyCode == Keys.OemSemicolon)
            {
                txtMain.AppendText(":-)");
            }
        }

        private void txtMain_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {
                txtMain.AppendText(" TAB");
            }

            
        }

        private void txtMain_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '-')
            {
                e.Handled = true;
            }

            if (e.KeyChar == ';' || e.KeyChar == ':')
            {
                e.Handled = true;
            }
        }
    }
}
