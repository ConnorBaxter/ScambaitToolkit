namespace Notepad
{
    partial class FontForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtFontName = new System.Windows.Forms.TextBox();
            this.txtFontStyle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFontSize = new System.Windows.Forms.TextBox();
            this.lbFontNames = new System.Windows.Forms.ListBox();
            this.lbFontStyle = new System.Windows.Forms.ListBox();
            this.lbFontSize = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblSample = new System.Windows.Forms.Label();
            this.btnOkay = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Font:";
            // 
            // txtFontName
            // 
            this.txtFontName.Location = new System.Drawing.Point(12, 25);
            this.txtFontName.Name = "txtFontName";
            this.txtFontName.Size = new System.Drawing.Size(135, 20);
            this.txtFontName.TabIndex = 1;
            // 
            // txtFontStyle
            // 
            this.txtFontStyle.Location = new System.Drawing.Point(153, 25);
            this.txtFontStyle.Name = "txtFontStyle";
            this.txtFontStyle.Size = new System.Drawing.Size(155, 20);
            this.txtFontStyle.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(150, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Font Style:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(311, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Size:";
            // 
            // txtFontSize
            // 
            this.txtFontSize.Location = new System.Drawing.Point(314, 25);
            this.txtFontSize.Name = "txtFontSize";
            this.txtFontSize.Size = new System.Drawing.Size(80, 20);
            this.txtFontSize.TabIndex = 5;
            // 
            // lbFontNames
            // 
            this.lbFontNames.FormattingEnabled = true;
            this.lbFontNames.Location = new System.Drawing.Point(12, 51);
            this.lbFontNames.Name = "lbFontNames";
            this.lbFontNames.Size = new System.Drawing.Size(135, 134);
            this.lbFontNames.TabIndex = 6;
            this.lbFontNames.SelectedIndexChanged += new System.EventHandler(this.SelectionChanged);
            // 
            // lbFontStyle
            // 
            this.lbFontStyle.FormattingEnabled = true;
            this.lbFontStyle.Location = new System.Drawing.Point(153, 51);
            this.lbFontStyle.Name = "lbFontStyle";
            this.lbFontStyle.Size = new System.Drawing.Size(155, 134);
            this.lbFontStyle.TabIndex = 7;
            this.lbFontStyle.SelectedIndexChanged += new System.EventHandler(this.SelectionChanged);
            // 
            // lbFontSize
            // 
            this.lbFontSize.FormattingEnabled = true;
            this.lbFontSize.Location = new System.Drawing.Point(314, 51);
            this.lbFontSize.Name = "lbFontSize";
            this.lbFontSize.Size = new System.Drawing.Size(80, 134);
            this.lbFontSize.TabIndex = 8;
            this.lbFontSize.SelectedIndexChanged += new System.EventHandler(this.SelectionChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblSample);
            this.groupBox1.Location = new System.Drawing.Point(153, 191);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(241, 100);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sample";
            // 
            // lblSample
            // 
            this.lblSample.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSample.Location = new System.Drawing.Point(3, 16);
            this.lblSample.Name = "lblSample";
            this.lblSample.Size = new System.Drawing.Size(235, 81);
            this.lblSample.TabIndex = 0;
            this.lblSample.Text = "AaBbYyZz";
            this.lblSample.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnOkay
            // 
            this.btnOkay.Location = new System.Drawing.Point(233, 358);
            this.btnOkay.Name = "btnOkay";
            this.btnOkay.Size = new System.Drawing.Size(75, 23);
            this.btnOkay.TabIndex = 10;
            this.btnOkay.Text = "OK";
            this.btnOkay.UseVisualStyleBackColor = true;
            this.btnOkay.Click += new System.EventHandler(this.btnOkay_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(319, 358);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FontForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 391);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOkay);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbFontSize);
            this.Controls.Add(this.lbFontStyle);
            this.Controls.Add(this.lbFontNames);
            this.Controls.Add(this.txtFontSize);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFontStyle);
            this.Controls.Add(this.txtFontName);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FontForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Font";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FontForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFontName;
        private System.Windows.Forms.TextBox txtFontStyle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFontSize;
        private System.Windows.Forms.ListBox lbFontNames;
        private System.Windows.Forms.ListBox lbFontStyle;
        private System.Windows.Forms.ListBox lbFontSize;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblSample;
        private System.Windows.Forms.Button btnOkay;
        private System.Windows.Forms.Button btnCancel;
    }
}