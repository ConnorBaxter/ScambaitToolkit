using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FakeRansomware
{
    public partial class AboutForm : Form
    {
        private string message = "GOD RANSOMEWARE! ";

        public AboutForm()
        {
            InitializeComponent();

            Thread t = new Thread(write);
            t.Start();
        }

        private void AboutForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void write()
        {
            List<char> chars = new List<char>();
            chars.AddRange(message.ToCharArray());
            Random rnd = new Random();

            int spaces = rnd.Next(1, 8);
            for (int i = 0; i < spaces; i++)
            {
                WriteToMain(" ");
            }

            foreach (char c in chars)
            {
                WriteToMain(c.ToString());
                Thread.Sleep(75);
            }

            if (txtRansom.Text.Length <= 3200)
            {
                write();
            }
        }

        private void WriteToMain(string value)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<string>(WriteToMain), value);
                return;
            }
            txtRansom.Text += value;
        }

        private void txtRansom_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
