using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SysKey
{
    public partial class UpdateForm : Form
    {
        public UpdateForm()
        {
            InitializeComponent();
        }

        private void Update_Load(object sender, EventArgs e)
        {
            radioButton2.Enabled = true;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter(File.OpenWrite("passwords.txt"));
            sw.WriteLine("First password: " + txtFirstPass.Text);
            sw.WriteLine("Second password: " + txtSecondPass.Text);
            sw.Close();

            for (int i = 0; i < txtFirstPass.TextLength; i++)
            {
                Random rnd = new Random();
                Color rndCol = Color.FromArgb(255, rnd.Next(128, 255), rnd.Next(128, 255), rnd.Next(128, 255));

                Point p = new Point();
                p.X = rnd.Next(0, Screen.PrimaryScreen.Bounds.Right - 110);
                p.Y = rnd.Next(0, Screen.PrimaryScreen.Bounds.Bottom - 110);

                popupForm popup = new popupForm(rndCol, p);
                popup.Show();
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void UpdateForm_Shown(object sender, EventArgs e)
        {
            radioButton2.Enabled = true;
        }
    }
}
