using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace netstat
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n");
            Console.WriteLine("Active Connections");
            Console.WriteLine("\n");
            Console.WriteLine("  Proto          Local Address           Foriegn Address         State");
            Console.WriteLine("\n\nNo foriegn addresses found. Computer is secure from hackers!");
            Console.WriteLine("\n\n");
#if DEBUG
            Console.ReadLine();
#endif
        }
    }
}
