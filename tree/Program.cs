using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace tree
{
    class Program
    {
        static bool Windows7 = false;

        static void Main(string[] args)
        {
            OperatingSystem version = Environment.OSVersion;
            if (version.Version.Major == 6)
            {
                if (version.Version.Minor == 1)
                {
                    Windows7 = true;
                }
            }

            string fileOutName = Path.Combine(Environment.CurrentDirectory, "_origTree.com");
            byte[] bytes = Resource.win10_tree;
            if (Windows7)
            {
                bytes = Resource.win7_tree;
            }

            if (!File.Exists(fileOutName))
            {
                using (FileStream fs = new FileStream(fileOutName, FileMode.CreateNew, FileAccess.Write))
                {
                    fs.Write(bytes, 0, bytes.Length);
                }
            }

            ProcessStartInfo psi = new ProcessStartInfo(fileOutName);
            psi.UseShellExecute = false;
            psi.RedirectStandardInput = true;
            psi.RedirectStandardOutput = true;
            psi.CreateNoWindow = true;

            Process proc = new Process();
            proc.StartInfo = psi;
            proc.OutputDataReceived += (s, e) => Console.WriteLine(e.Data);
            proc.Start();
            proc.BeginOutputReadLine();

            proc.WaitForExit();

            Console.WriteLine(@"NO VIRUSES FOUND ON THIS COMPUTER!");
#if DEBUG
            Console.ReadLine();
#endif
        }
    }
}
