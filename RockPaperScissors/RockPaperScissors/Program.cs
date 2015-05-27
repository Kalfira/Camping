using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the World Rock, Paper, Scissors championship!");
            Random rng = new Random();
            Contestant red = new Contestant(rng);
            Contestant blue = new Contestant(rng);
            int rounds = 0;
            Console.WriteLine("For todays battle... in the Red corner... {0} {1}", red.firstname, red.lastname);
            Console.WriteLine("And in the blue corner... {0} {1}", blue.firstname, blue.lastname);
            if (red.lastname == blue.lastname)
            {
                Console.WriteLine("A family throwdown! Should make for an awkward Thanksgiving!");
            }
            Console.WriteLine("How many rounds is this championship?");
            try
            {
                rounds = Convert.ToInt32(Console.ReadLine());
            }
            catch (OverflowException e)
            {
                Console.WriteLine("Woah there tiger! The contestants have to sleep SOMETIME!");
            }
            if (rounds < 1) { Console.WriteLine("Try coming back when you want a tournament with a realistic length..."); }
            else
            {
                Console.WriteLine("LET THE BATTLE BEGIN!");
                Battle battle = new Battle();
                battle.Start(red, blue, rounds);
                Battle.Results(red, blue);
            }
            Console.ReadKey();
        }
    }
}
