using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using WcfService;
namespace ServiceConsole
{
    class Program
    {
        internal static ServiceHost myServiceHost = null; 

        static void Main(string[] args)
        {
            if (myServiceHost != null)
            {
                myServiceHost.Close();
            }
            myServiceHost = new ServiceHost(typeof(Service1));
            myServiceHost.Open();

            Console.WriteLine(@"WCF Service is running");
            Console.WriteLine(@"Press ENTER to exit...");
            Console.ReadLine();

            myServiceHost.Close();
            myServiceHost = null;
        }
    }
}
