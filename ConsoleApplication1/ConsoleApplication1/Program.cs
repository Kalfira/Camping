using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            var thing = new System.Net.WebClient();
            thing.DownloadFile("http://services.odata.org/Northwind/Northwind.svc/", "C:/file.svc");
            Console.Read();
        }
    }
}
