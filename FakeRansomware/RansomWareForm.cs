using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Timer = System.Timers.Timer;

namespace FakeRansomware
{
    public partial class RansomWareForm : Form
    {
        private TimeSpan timeToEncrpt;
        private TimeSpan normTime = new TimeSpan(0, 1, 0);

        private string message;
        private string lang;
        private string bitcoinaddress;

        List<string> fileNames = new List<string>();
        private int fileCounter = 0;

        private Thread t;

        private Settings settings = new Settings();

        public RansomWareForm()
        {
            InitializeComponent();

            #if DEBUG
            this.TopMost = false;
            #endif

            ContextMenu contextMenu = new ContextMenu();
            contextMenu.MenuItems.Add("About", showAbout);
            contextMenu.MenuItems.Add("Help");
            contextMenu.MenuItems.Add("Payment Link", close);

            this.ContextMenu = contextMenu;
            txtMainMessage.ContextMenu = contextMenu;
            txtFiles.ContextMenu = contextMenu;
            txtTimer.ContextMenu = contextMenu;

            //settings.debugCreateSettingsFile();
            //settings = getFormDesign();
            //ChangeTheme();

            timeToEncrpt = normTime;
            
            t = new Thread(WriteSlowly);

            message = "";
            StreamReader sr = new StreamReader("message.txt");
            while (!sr.EndOfStream)
            {
                message += sr.ReadLine() + Environment.NewLine;
            }
            sr.Close();

            sr = new StreamReader("files.txt");
            while (!sr.EndOfStream)
            {
                fileNames.Add(sr.ReadLine());
            }
            sr.Close();

            sr = new StreamReader("bitcoinaddress.txt");
            while (!sr.EndOfStream)
            {
                bitcoinaddress = sr.ReadLine();
            }
            sr.Close();
        }

        private Settings getFormDesign()
        {
            Settings s = new Settings();

            s.LoadFromJSON();

            return s;
        }

        private void ChangeTheme()
        {
            //background colors
            this.BackColor = settings.BackgroundColourPrimary;
            txtMainMessage.BackColor = settings.BackgroundColourSecondary;
            txtFiles.BackColor = settings.BackgroundColourSecondary;
            txtBitcoinAddress.BackColor = settings.BackgroundColourTertiary;
            txtTimer.BackColor = settings.BackgroundColourPrimary;

            //foreground colors
            this.ForeColor = settings.ForegroundColourPrimary;
            txtMainMessage.ForeColor = settings.ForegroundColourPrimary;
            txtFiles.ForeColor = settings.BackgroundColourSecondary;
            txtBitcoinAddress.ForeColor = settings.BackgroundColourTertiary;

            txtTimer.ForeColor = settings.CountdownColour;
        }

        private void showAbout(object sender, EventArgs e)
        {
            Form aboutForm = new AboutForm();
            aboutForm.StartPosition = FormStartPosition.CenterParent;
            aboutForm.ShowDialog();
        }

        private void close(object sender, EventArgs e)
        {
            t.Abort();
            Application.Exit();
        }

        private void RansomWareForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                MessageBox.Show("YOU CANNOT CLOSE ME - FOR I AM GOD!", "GOD", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                e.Cancel = true;
            }
            else
            {
                e.Cancel = false;
            }
        }

        private void WriteSlowly()
        {
            ClearMain("");

            List<char> chars = new List<char>();
            chars.AddRange(message.ToCharArray());

            foreach (char c in chars)
            {
                WriteToMain(c.ToString());
                Thread.Sleep(125);
            }
        }

        private void RansomWareForm_Load(object sender, EventArgs e)
        {
            encryptionTimer.Start();
        }

        private void RansomWareForm_Shown(object sender, EventArgs e)
        {
            string message = "";
            StreamReader sr = new StreamReader("message.txt");
            while (!sr.EndOfStream)
            {
                message += sr.ReadLine() + Environment.NewLine;
            }
            sr.Close();

            t.Start();

            txtBitcoinAddress.Text = bitcoinaddress;

            cbMessageLang.SelectedIndex = 0;
            lang = cbMessageLang.SelectedText;
        }

        private void ClearMain(string newVal)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<string>(ClearMain), newVal);
                return;
            }
            txtMainMessage.Text = "";
        }

        private void WriteToMain(string value)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<string>(WriteToMain), value);
                return;
            }
            txtMainMessage.Text += value;
        }

        private void encryptionTimer_Tick(object sender, EventArgs e)
        {
            if (timeToEncrpt.TotalSeconds <= 1)
            {
                encryptFile();
                timeToEncrpt = normTime;
            }

            timeToEncrpt = timeToEncrpt.Subtract(new TimeSpan(0, 0, 1));

            string time = "";
            string mins = timeToEncrpt.Minutes.ToString();
            string seconds = timeToEncrpt.Seconds.ToString();
            if (mins.Length == 1) time += "0";
            time += mins;
            time += ":";
            if (seconds.Length == 1) time += "0";
            time += seconds;

            txtTimer.Text = time;
        }

        private void encryptFile()
        {
            if (fileCounter >= fileNames.Count) fileCounter = 0;

            string fileMessage = "";
            fileMessage += $"<{DateTime.Now}> ";
            fileMessage += "File encrypted: " + fileNames[fileCounter];

            txtFiles.AppendText(fileMessage + Environment.NewLine);
            fileCounter++;
        }

        private void cbMessageLang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbMessageLang.Text != lang)
            {
                t.Abort();
                t = new Thread(WriteSlowly);

                message = "";
                string filename = (cbMessageLang.Text == @"English") ? "message.txt" : "message_hindi.txt";
                StreamReader sr = new StreamReader(filename);
                while (!sr.EndOfStream)
                {
                    message += sr.ReadLine() + Environment.NewLine;
                }
                sr.Close();

                t.Start();
            }

            lang = cbMessageLang.SelectedText;
        }
    }
}
