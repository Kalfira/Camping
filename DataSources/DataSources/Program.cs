using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DataSources
{
    class Program
    {
        static void Main(string[] args)
        {
            //string sample = "The quick brown fox jumped over the lazy dog!";
            string filetext;
            using (StreamReader text = new StreamReader("C:/Projects/file.txt"))
            {
                filetext = text.ReadToEnd();
                //Console.WriteLine(filetext);
                Console.WriteLine("End of line");
            }
            Counter.CountWords(filetext);
            Console.ReadKey();

        }
    }
}
