using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Contestant
    {
        public string firstname;
        public string lastname;
        public int rocks;
        public int papers;
        public int scissors;
        public int choice;
        public int wins;
        public int draws;
        string[] fname = new string[] { "Julio", "Nick", "Abdiel", "Alexander", "Voltaire", "Isaac", "Anna", "Katy", "Kasie", "David", "Joshua", "Justin", "Keigo", "Mike", "Rob", "Thad", "Chelsea", "Zane", "Christian", "Kal", "Peter", "Bruce" };
        string[] lname = new string[] { "Rodriguez", "Brittain", "Guzman", "Cassaro", "Whaley", "Christiansen", "Plourde", "Ito", "Cooley", "Greenlee", "Lang", "Degner", "Talon", "Goliath", "Peralta", "'El", "Parker", "Wayne", "Jacob-Jingleheimerschmidt", "Christ", "McParty", "Robbins"};

        public Contestant(Random rng)
        {
            firstname = fname[rng.Next(fname.Length)];
            lastname = lname[rng.Next(lname.Length)];
        }
    }
}
