using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Battle
    {
        Random rng = new Random();
        public void Start(Contestant red, Contestant blue, int rounds)
        {
            for (int i = 0; i < rounds; i++)
            {
                Choose(red);
                Choose(blue);
                Resolve(red, blue);
            }
        }

        private static void Resolve(Contestant red, Contestant blue)
        {
            if (red.choice % 3 + 1 == blue.choice)
            {
                blue.wins++;
            }
            else if (blue.choice % 3 + 1 == red.choice)
            {
                red.wins++;
            }
            else
            {
                red.draws++;
                blue.draws++;
            }
        }

       private void Choose(Contestant cont)
       {
           
           cont.choice = rng.Next(1,4);
           if (cont.choice == 1) { cont.rocks++; }
           else if(cont.choice == 2){cont.papers++;}
           else { cont.scissors++; }
       }

       public static void Results(Contestant red, Contestant blue)
       {
           if (red.wins > blue.wins)
           {
               Console.WriteLine("The winner is... {0} {1} with a record of {2} - {3} with {4} draws", red.firstname, red.lastname, red.wins, blue.wins, red.draws);
           }
           else if (blue.wins > red.wins)
           {
               Console.WriteLine("The winner is... {0} {1} with a record of {2} - {3} with {4} draws", blue.firstname, blue.lastname, blue.wins, red.wins, blue.draws);
           }
           else{
               Console.WriteLine("The winner is... YOU! The match ended in a draw with {0} draws", red.draws);
           }
           Console.WriteLine("{0} threw {1} rocks, {2} papers, and {3} scissors.", red.firstname, red.rocks, red.papers, red.scissors);
           Console.WriteLine("Where as {0} threw {1} rocks, {2} papers, and {3} scissors.", blue.firstname, blue.rocks, blue.papers, blue.scissors);
       }
    }
}
