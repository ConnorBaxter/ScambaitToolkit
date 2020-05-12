using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notepad
{
    public partial class FontForm : Form
    {
        private bool loaded = false;

        public FontForm()
        {
            InitializeComponent();
        }

        private void FontForm_Load(object sender, EventArgs e)
        {
            this.Text = "Font";

            lbFontSize.Items.Clear();
            lbFontStyle.Items.Clear();
            lbFontNames.Items.Clear();

            for (int i = 8; i <= 12; i++)
            {
                lbFontSize.Items.Add(i);
            }

            for (int i = 14; i <= 28; i += 2)
            {
                lbFontSize.Items.Add(i);
            }

            lbFontSize.Items.Add(36);
            lbFontSize.Items.Add(48);
            lbFontSize.Items.Add(72);

            lbFontStyle.Items.Add("Regular");
            lbFontStyle.Items.Add("Bold");
            lbFontStyle.Items.Add("Italic");
            lbFontStyle.Items.Add("Bold Italic");

            FontCollection fCollection = new InstalledFontCollection();
            List<FontFamily> fonts = fCollection.Families.ToList();
            List<string> FontNames = new List<string>();
            foreach (var f in fonts)
            {
                FontNames.Add(f.Name);
            }

            lbFontNames.Items.AddRange(FontNames.ToArray());

            txtFontName.Text = "Consolas";
            txtFontSize.Text = "11";
            txtFontStyle.Text = "Regular";

            lbFontNames.SelectedIndex = 0;
            lbFontStyle.SelectedIndex = 0;
            lbFontSize.SelectedIndex = 0;

            loaded = true;
        }

        private void SelectionChanged(object sender, EventArgs e)
        {

            if (loaded)
            {
                txtFontName.Text = lbFontNames.Items[lbFontNames.SelectedIndex].ToString();
                txtFontStyle.Text = lbFontStyle.Items[lbFontStyle.SelectedIndex].ToString();
                txtFontSize.Text = lbFontSize.Items[lbFontSize.SelectedIndex].ToString();

                UpdateSample();
            }
        }

        private void UpdateSample()
        {
            FontStyle fontEnum;
            bool fontSty = Enum.TryParse(txtFontStyle.Text, out fontEnum);

            Font f = new Font(new FontFamily(txtFontName.Text), float.Parse(txtFontSize.Text), fontEnum);
            lblSample.Font = f;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOkay_Click(object sender, EventArgs e)
        {
            string data = "";
            data += txtFontName.Text + ",";
            data += txtFontStyle.Text + ",";
            data += txtFontSize.Text;

            this.Text = data;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
