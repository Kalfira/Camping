using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataSources
{
    class Counter
    {
        
        public static void CountWords(string entry)
        {
            int count = 0;
            string[] spaced = entry.Split(null);
            foreach (string s in spaced)
            {
                Console.WriteLine(s);
                count++;
            }
            Console.WriteLine(count);
        }
    }
}
