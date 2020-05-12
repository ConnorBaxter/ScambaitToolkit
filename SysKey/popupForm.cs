using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Net;
using Timer = System.Windows.Forms.Timer;

namespace SysKey
{
    public partial class popupForm : Form
    {
        Timer t = new Timer();
        private int time = 0;
        Random rnd = new Random();

        public popupForm(Color txtCol, Point pos)
        {
            InitializeComponent();

            label1.ForeColor = txtCol;
            label1.BackColor = Color.Black;
            this.BackColor = Color.Black;

            this.Location = pos;

            t.Interval = 1000;
            t.Tick += T_Tick;
            t.Start();
        }

        private void T_Tick(object sender, EventArgs e)
        {
            time++;
            if (time > 60)
            {
                t.Stop();
                this.Close();
            }
        }

        private void killSwitch()
        {

        }

        private void PopupForm_Load(object sender, EventArgs e)
        {
            label1.Text = File.ReadAllLines("settings.txt")[0];
        }

        private void PopupForm_Shown(object sender, EventArgs e)
        {
            //killSwitch();
        }

        private void PopupForm_MouseEnter(object sender, EventArgs e)
        {
            Point p = new Point();
            p.X = rnd.Next(0, Screen.PrimaryScreen.Bounds.Right);
            p.Y = rnd.Next(0, Screen.PrimaryScreen.Bounds.Bottom);

            this.Location = p;
        }
    }
}
