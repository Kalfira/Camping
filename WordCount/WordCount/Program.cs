using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace Testing
{
    class Program
    {
        static void Main(string[] args)
        {
            List<String> ignoreList = new List<string> { "the", "and", "a", "an", "to", "of", "i", "you", "my" };
            string hamletFile = Regex.Replace(File.ReadAllText("ham.txt").Replace("\r\n", " "), @"[^\w\s]", "");
            var split = hamletFile
                .Split(' ')
                .Where(t => !string.IsNullOrWhiteSpace(t))
                .GroupBy(t => t, StringComparer.InvariantCultureIgnoreCase)
                .OrderByDescending(t => t.Count());
            foreach (var word in split)
            {
                if (!ignoreList.Contains(word.Key.ToLower()))
                {
                    Console.WriteLine("The word \"{0}\" was used {1} times", word.Key, word.Count());
                    Console.ReadKey();
                }
            }

            Console.Read();

        }
    }
}
