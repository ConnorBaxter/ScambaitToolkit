using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FakeFileCreator
{
    public partial class MainForm : Form
    {
        private Random rand = new Random();
        private static string EnglishWordListURL = @"https://raw.githubusercontent.com/dwyl/english-words/master/words_alpha.txt";

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnDocuments_Click(object sender, EventArgs e)
        {
            List<string> extensions = new List<string> { ".txt", ".docx", ".pdf", ".xls", ".xlxs", ".ppt", ".pptx", ".odt" };

            Console.WriteLine("Looking for words.txt...");
            if (!File.Exists("words.txt"))
            {
                var client = new WebClient();
                Console.WriteLine("Getting words from github...");
                string data = client.DownloadString(EnglishWordListURL);
                using (StreamWriter sw = new StreamWriter("words.txt")) { sw.Write(data); }
            }

            List<string> words = new List<string>();
            using (StreamReader sr = new StreamReader("words.txt"))
            {
                while (!sr.EndOfStream)
                {
                    words.Add(sr.ReadLine());
                }
            }

            Console.WriteLine("Words count: " + words.Count);

            if(words.Count == 0) return;
            if(extensions.Count == 0) return;

            int filesToGenerate = rand.Next(10, 50);
            Console.WriteLine($"Generating [{filesToGenerate}] files...");
            for (int i = 0; i < filesToGenerate; i++)
            {
                string filename = "";
                int wordsLong = rand.Next(1, 4);
                for (int j = 0; j < wordsLong; j++)
                {
                    int wordToGet = rand.Next(0, words.Count);
                    Console.WriteLine("Word to get: " + wordToGet);
                    filename += words[wordToGet] + " ";
                }
                filename += extensions[rand.Next(0, extensions.Count)];

                Console.WriteLine($"Filename: {filename}");

                string myDocs = Path.Combine(Environment.ExpandEnvironmentVariables("%userprofile%"), "Documents");
                FileInfo fInf = new FileInfo(myDocs + "/" + filename);
                if (fInf.Exists) continue;

                fInf.Create().Close();

                StreamWriter sw = new StreamWriter(fInf.OpenWrite());
                sw.Write("NULL_NULL_NULL");
                sw.Flush();
                sw.Close();
            }
        }
    }
}
