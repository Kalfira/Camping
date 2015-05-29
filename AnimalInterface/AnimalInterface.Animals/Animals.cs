using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalInterface.Animals
{
    public abstract class Animals : IAnimals 
    {
        public string Name { get; set; }
        protected string Sound { get; set; }
        public string MakeSound()
        {
            return Sound;
        }
    }
    public class Bear : Animals
    {
        public Bear()
        {
            Name = "Bear";
            Sound = "ROAR!";
        }
    }

    public class Chicken : Animals
    {
        public Chicken()
        {
            Name = "Chicken";
            Sound = "Cluck Cluck FOOL!";
        }
    }

    public class Eagle : Animals
    {
        public Eagle()
        {
            Name = "Eagle";
            Sound = "CAW!";
        }
    }
}
