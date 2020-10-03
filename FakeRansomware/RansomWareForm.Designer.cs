namespace FakeRansomware
{
    partial class RansomWareForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtMainMessage = new System.Windows.Forms.TextBox();
            this.encryptionTimer = new System.Windows.Forms.Timer(this.components);
            this.txtTimer = new System.Windows.Forms.TextBox();
            this.txtFiles = new System.Windows.Forms.TextBox();
            this.lblBitcoin = new System.Windows.Forms.Label();
            this.txtBitcoinAddress = new System.Windows.Forms.TextBox();
            this.cbMessageLang = new System.Windows.Forms.ComboBox();
            this.lblTitleStuff = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtMainMessage
            // 
            this.txtMainMessage.BackColor = System.Drawing.Color.DimGray;
            this.txtMainMessage.ForeColor = System.Drawing.Color.Lime;
            this.txtMainMessage.Location = new System.Drawing.Point(12, 12);
            this.txtMainMessage.Multiline = true;
            this.txtMainMessage.Name = "txtMainMessage";
            this.txtMainMessage.ReadOnly = true;
            this.txtMainMessage.ShortcutsEnabled = false;
            this.txtMainMessage.Size = new System.Drawing.Size(972, 215);
            this.txtMainMessage.TabIndex = 0;
            // 
            // encryptionTimer
            // 
            this.encryptionTimer.Interval = 1000;
            this.encryptionTimer.Tick += new System.EventHandler(this.encryptionTimer_Tick);
            // 
            // txtTimer
            // 
            this.txtTimer.BackColor = System.Drawing.Color.DimGray;
            this.txtTimer.Font = new System.Drawing.Font("Digital-7 Mono", 71.99999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimer.ForeColor = System.Drawing.Color.Red;
            this.txtTimer.Location = new System.Drawing.Point(12, 337);
            this.txtTimer.Name = "txtTimer";
            this.txtTimer.ReadOnly = true;
            this.txtTimer.ShortcutsEnabled = false;
            this.txtTimer.Size = new System.Drawing.Size(233, 102);
            this.txtTimer.TabIndex = 1;
            this.txtTimer.Text = "00:00";
            // 
            // txtFiles
            // 
            this.txtFiles.BackColor = System.Drawing.Color.Black;
            this.txtFiles.ForeColor = System.Drawing.Color.Red;
            this.txtFiles.Location = new System.Drawing.Point(12, 233);
            this.txtFiles.Multiline = true;
            this.txtFiles.Name = "txtFiles";
            this.txtFiles.ReadOnly = true;
            this.txtFiles.ShortcutsEnabled = false;
            this.txtFiles.Size = new System.Drawing.Size(972, 98);
            this.txtFiles.TabIndex = 2;
            // 
            // lblBitcoin
            // 
            this.lblBitcoin.AutoSize = true;
            this.lblBitcoin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBitcoin.ForeColor = System.Drawing.Color.Lime;
            this.lblBitcoin.Location = new System.Drawing.Point(251, 337);
            this.lblBitcoin.Name = "lblBitcoin";
            this.lblBitcoin.Size = new System.Drawing.Size(395, 24);
            this.lblBitcoin.TabIndex = 3;
            this.lblBitcoin.Text = "Please send $570 to following bitcoin address:";
            // 
            // txtBitcoinAddress
            // 
            this.txtBitcoinAddress.BackColor = System.Drawing.Color.Black;
            this.txtBitcoinAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBitcoinAddress.ForeColor = System.Drawing.Color.Lime;
            this.txtBitcoinAddress.Location = new System.Drawing.Point(255, 364);
            this.txtBitcoinAddress.Multiline = true;
            this.txtBitcoinAddress.Name = "txtBitcoinAddress";
            this.txtBitcoinAddress.Size = new System.Drawing.Size(729, 75);
            this.txtBitcoinAddress.TabIndex = 4;
            // 
            // cbMessageLang
            // 
            this.cbMessageLang.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbMessageLang.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbMessageLang.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.cbMessageLang.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.cbMessageLang.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbMessageLang.ForeColor = System.Drawing.Color.Lime;
            this.cbMessageLang.FormattingEnabled = true;
            this.cbMessageLang.Items.AddRange(new object[] {
            "English",
            "Hindi"});
            this.cbMessageLang.Location = new System.Drawing.Point(860, 15);
            this.cbMessageLang.Name = "cbMessageLang";
            this.cbMessageLang.Size = new System.Drawing.Size(121, 21);
            this.cbMessageLang.TabIndex = 5;
            this.cbMessageLang.SelectedIndexChanged += new System.EventHandler(this.cbMessageLang_SelectedIndexChanged);
            // 
            // lblTitleStuff
            // 
            this.lblTitleStuff.AutoSize = true;
            this.lblTitleStuff.ForeColor = System.Drawing.Color.Red;
            this.lblTitleStuff.Location = new System.Drawing.Point(784, 335);
            this.lblTitleStuff.Name = "lblTitleStuff";
            this.lblTitleStuff.Size = new System.Drawing.Size(200, 26);
            this.lblTitleStuff.TabIndex = 6;
            this.lblTitleStuff.Text = "| GOD Ransomware |\r\nALL YOUR FILES ARE BELONG TO US";
            this.lblTitleStuff.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RansomWareForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(992, 451);
            this.Controls.Add(this.lblTitleStuff);
            this.Controls.Add(this.cbMessageLang);
            this.Controls.Add(this.txtBitcoinAddress);
            this.Controls.Add(this.lblBitcoin);
            this.Controls.Add(this.txtFiles);
            this.Controls.Add(this.txtTimer);
            this.Controls.Add(this.txtMainMessage);
            this.Cursor = System.Windows.Forms.Cursors.Cross;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1111, 490);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1008, 490);
            this.Name = "RansomWareForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GOD";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RansomWareForm_FormClosing);
            this.Load += new System.EventHandler(this.RansomWareForm_Load);
            this.Shown += new System.EventHandler(this.RansomWareForm_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMainMessage;
        private System.Windows.Forms.Timer encryptionTimer;
        private System.Windows.Forms.TextBox txtTimer;
        private System.Windows.Forms.TextBox txtFiles;
        private System.Windows.Forms.Label lblBitcoin;
        private System.Windows.Forms.TextBox txtBitcoinAddress;
        private System.Windows.Forms.ComboBox cbMessageLang;
        private System.Windows.Forms.Label lblTitleStuff;
    }
}

