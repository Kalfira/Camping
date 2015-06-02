using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entry to check if it's a palindrome:");
            string entry = Console.ReadLine();
            var reverse = entry.Reverse();

            if (Check(entry, reverse.ToArray()))
            {
                Console.WriteLine("Yes! {0} is a palindrome!", entry);
            }
            else
            {
                Console.WriteLine("Sorry... {0} is not a palindrome", entry);
            }
            Console.ReadKey();
        }

        static bool Check(string thing, char[] reverse)
        {
            bool val = false;
            int i = 0;
            Console.WriteLine("Starting");
            foreach (char letter in thing)
            {
                if (letter == reverse[i])
                {
                    val = true;
                }
                else
                {
                    return false;
                }
                i++;
            }
            return val;
        }
    }
}
