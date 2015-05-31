using System;

namespace BirthDayoftheWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            bool answer = true;
            while (answer)
            {
                Run();
                Console.Clear();
                Console.WriteLine("Again? (y / n)");
                string thing = Console.ReadLine().ToLower();
                if (thing == "y")
                {

                }
                else answer = false;
            }
        }

        static void Run()
        {
            DateTime now = DateTime.Now;
            Console.WriteLine(now);
            Console.WriteLine("Hello! Enter your birthday! (Month/Day/Year format)");
            string raw = Console.ReadLine();
            DateTime dt = DateTime.Parse(raw);
            if (dt.Day == now.Day && dt.Month == now.Month)
            {
                Console.WriteLine("Happy Birthday!");
            }
            Console.WriteLine("You were born on a {0} ", dt.DayOfWeek);
            DateTime thisYear = new DateTime(now.Year, dt.Month, dt.Day);
            TimeSpan ts = now - thisYear;
            Console.WriteLine("This year your Birthday was on a {0}.", thisYear.DayOfWeek);
            Console.WriteLine("What year would you like to know the day it will be on your birthday?");
            int targetYear = Convert.ToInt32(Console.ReadLine());
            DateTime final = new DateTime(targetYear, dt.Month, dt.Day);
            Console.WriteLine("The day of the week of your birthday on {0} in {1} and you will be {2} years old.", final.DayOfWeek, final.ToString(("MMMM dd, yyyy")), final.Year - dt.Year);
            Console.WriteLine("Press any key to continue:");
            Console.ReadKey();
        }
    }
}
