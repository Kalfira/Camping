using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace IMDBTest
{
    class Program
    {
        static void Main(string[] args)
        {
            HttpWebRequest request = WebRequest.CreateHttp("http://www.omdbapi.com/?t=Ghostbusters&y=&plot=short&r=xml");
            var response = request.GetResponse();
            Console.WriteLine(response.ResponseUri);
            Console.ReadKey();
        }
    }
}
