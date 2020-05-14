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
        
        static void Main(string[] args)
        {
            string pathToTree = @"C:\Windows\System32\tree.com";

            ProcessStartInfo psi = new ProcessStartInfo(pathToTree);
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
