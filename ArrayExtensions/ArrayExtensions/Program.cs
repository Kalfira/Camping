using System;

namespace ArrayExtensions
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var val = true;
            string[] array = {"Mars Invades!", "Cancer is cured!", "The Four Horsemen are here!"};
            while (val)
            {
                array.GetRandom();
                Console.WriteLine("Again? ( y / n)");
                var entry = Console.ReadLine();
                if (entry.ToLower() != "y")
                {
                    val = false;
                }
            }
        }
    }

    public static class ArrayExtensions
    {
        public static void GetRandom(this string[] thing)
        {
            var rng = new Random();
            Console.WriteLine(thing[rng.Next(0, thing.Length)]);
        }
    }
}