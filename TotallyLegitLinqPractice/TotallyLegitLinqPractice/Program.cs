using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace TotallyLegitLinqPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] collection =
            {
                "Monkey Gundam", "Uh this thing...", "The fantastic Mr. Fox McCloud",
                "The stuff of my nightmares!"
            };

            var Query =

                from thing in collection
                where thing.Length > 5
                select thing;

            foreach (var col in Query)
            {
                Console.WriteLine(col);
            }
            Console.Read();
        }
    }
}
