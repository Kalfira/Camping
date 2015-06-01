using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string to check for cats:");
            string entry = Console.ReadLine().ToLower();
            Stopwatch watch = new Stopwatch();
            watch.Start();
            string results = CatChecker(entry);
            watch.Stop();
            Console.WriteLine("There were {0} cats in the provided string. This took {1} to calculate.", results, watch.Elapsed);
            Console.ReadKey();
        }

        static string CatChecker(string entry)
        {
            int cats = entry.Split(' ').Count(s => s == "cat");
            return cats.ToString();
        }
    }
}
