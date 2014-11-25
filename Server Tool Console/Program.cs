using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Server_Tool_Network;

namespace Server_Tool_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Network MyNetwork = new Network();

            Console.WriteLine(MyNetwork.StatusMessage());

            Console.WriteLine("Press any key to close ...");
            Console.ReadKey();
        }
    }
}
