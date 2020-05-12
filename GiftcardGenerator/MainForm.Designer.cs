namespace GiftcardGenerator
{
    partial class MainForm
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
            this.cbCardType = new System.Windows.Forms.ComboBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.lbGiftcardNumbers = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // cbCardType
            // 
            this.cbCardType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbCardType.FormattingEnabled = true;
            this.cbCardType.Items.AddRange(new object[] {
            "Apple",
            "Bass Pro",
            "Google Play",
            "Target",
            "Walmart"});
            this.cbCardType.Location = new System.Drawing.Point(12, 12);
            this.cbCardType.Name = "cbCardType";
            this.cbCardType.Size = new System.Drawing.Size(342, 21);
            this.cbCardType.Sorted = true;
            this.cbCardType.TabIndex = 0;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGenerate.Location = new System.Drawing.Point(360, 12);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(75, 21);
            this.btnGenerate.TabIndex = 1;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // lbGiftcardNumbers
            // 
            this.lbGiftcardNumbers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbGiftcardNumbers.Font = new System.Drawing.Font("Consolas", 14F);
            this.lbGiftcardNumbers.FormattingEnabled = true;
            this.lbGiftcardNumbers.ItemHeight = 22;
            this.lbGiftcardNumbers.Location = new System.Drawing.Point(12, 39);
            this.lbGiftcardNumbers.Name = "lbGiftcardNumbers";
            this.lbGiftcardNumbers.Size = new System.Drawing.Size(423, 180);
            this.lbGiftcardNumbers.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 223);
            this.Controls.Add(this.lbGiftcardNumbers);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.cbCardType);
            this.Name = "MainForm";
            this.Text = "Giftcard Generator";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbCardType;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.ListBox lbGiftcardNumbers;
    }
}

