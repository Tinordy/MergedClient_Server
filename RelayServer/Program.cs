using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace RelayServer
{
    class Program
    {
        static void Main(string[] args)
        {

            //Try to start a new server using the default port in the config file.
            try
            {
                Server server = new Server(Properties.Settings.Default.Port);

                while (true) { Thread.Sleep(1000); }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            Console.ReadKey();
        }

    }
}
