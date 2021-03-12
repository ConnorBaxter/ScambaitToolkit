using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace tree
{
    class Program
    {
        
        static void Main(string[] args)
        {
            // Change me to swap between the 2 modes
            bool neverEndingTreeOutput = true;

            string pathToTree = @"C:\Windows\System32\tree.com";

            string newArgs = "";
            foreach (var arg in args) { newArgs += arg + " "; }

            ProcessStartInfo psi = new ProcessStartInfo(pathToTree);
            psi.UseShellExecute = false;
            psi.RedirectStandardInput = true;
            psi.RedirectStandardOutput = true;
            psi.RedirectStandardError = true;
            psi.CreateNoWindow = true;
            psi.WorkingDirectory = @"C:\Windows\System32\";
            psi.Arguments = newArgs;

            Process proc = new Process();
            proc.StartInfo = psi;
            proc.OutputDataReceived += (s, e) => Console.WriteLine(e.Data);
            proc.ErrorDataReceived += (s, e) => Console.Write(e.Data);
            proc.Start();
            proc.BeginOutputReadLine();
            proc.BeginErrorReadLine();

            proc.WaitForExit();

            if (neverEndingTreeOutput)
            {
                while (true)
                {
                    proc.CancelOutputRead();
                    proc.CancelErrorRead();

                    proc.Start();
                    proc.BeginOutputReadLine();
                    proc.BeginErrorReadLine();
                    proc.WaitForExit();
                }
            }
            else
            {
                Console.WriteLine(@"NO VIRUSES FOUND ON THIS COMPUTER!");
            }
#if DEBUG
            Console.ReadLine();
#endif
        }
    }
}
