using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GiftcardGenerator
{
    public partial class MainForm : Form
    {
        Random rand = new Random();

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            cbCardType.SelectedIndex = 0;
        }

        private void GetType(string type)
        {
            //Apple
            // Bass Pro
            // Google Play
            // Target
            // Walmart

            switch (type.ToLower())
            {
                case "apple":
                    Generate(true);
                    break;
                case "bass pro":
                    GenerateBassPro();
                    break;
                case "google play":
                    Generate(false);
                    break;
                case "target":
                    GenerateTarget();
                    break;
                case "walmart":
                    GenerateWalmart();
                    break;
                default:
                    Generate(false);
                    break;
            }
        }

        private void GenerateBassPro()
        {
            for (int i = 0; i < 5; i++)
            {
                string card = "";
                for (int j = 0; j < 19; j++)
                {
                    card += rand.Next(0, 10);
                    if (j % 3 == 0) card += " ";
                }

                card = card.Remove(card.Length - 1, 1);

                string pin = rand.Next(1000, 9999).ToString();

                lbGiftcardNumbers.Items.Add(card + " | Pin: " + pin);
            }
        }

        private void GenerateWalmart()
        {
            for (int i = 0; i < 5; i++)
            {
                string card = "";
                for (int j = 0; j < 5; j++)
                {
                    card += rand.Next(1000, 10000);
                    card += "-";
                }

                card = card.Remove(card.Length - 1, 1);

                string pin = rand.Next(1000, 9999).ToString();

                lbGiftcardNumbers.Items.Add(card + " | Pin: " + pin);
            }
        }

        private void GenerateTarget()
        {
            for (int i = 0; i < 5; i++)
            {
                string card = "";
                for (int j = 0; j < 5; j++)
                {
                    card += rand.Next(100, 1000);
                    card += "-";
                }

                card = card.Remove(card.Length - 1, 1);

                string pin = rand.Next(1000, 9999).ToString();
                pin += " ";
                pin += rand.Next(1000, 9999).ToString();

                lbGiftcardNumbers.Items.Add(card + " | Pin: " + pin);
            }
        }

        private void Generate(bool withPin)
        {
            if (!withPin)
            {
                for (int i = 0; i < 5; i++)
                {
                    lbGiftcardNumbers.Items.Add(GenerateCard());
                }
            }
            else
            {
                for (int i = 0; i < 5; i++)
                {
                    lbGiftcardNumbers.Items.Add(GenerateCard() + " | Pin: " + GeneratePin());
                }
            }
        }

        private string GeneratePin()
        {
            string pin = "";
            for (int i = 0; i < 4; i++)
            {
                pin += rand.Next(0, 10);
            }

            return pin;
        }

        private string GenerateCard()
        {
            string cardNumber = "";

            for (int i = 0; i < 16; i++)
            {
                if (i % 4 == 0) cardNumber += " ";
                int numOrChar = rand.Next(0, 2);
                if (numOrChar >= 1)
                {
                    cardNumber += rand.Next(0, 10);
                }
                else
                {
                    cardNumber += Convert.ToChar(rand.Next(65, 90));
                }
            }

            return cardNumber;
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            lbGiftcardNumbers.Items.Clear();
            GetType(cbCardType.Text);
        }
    }
}
