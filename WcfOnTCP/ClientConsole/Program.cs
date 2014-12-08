using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClientConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceReference1.Service1Client myService = new ServiceReference1.Service1Client();
            Console.WriteLine(myService.GetData(123));
            myService.Close();
        }
    }
}
