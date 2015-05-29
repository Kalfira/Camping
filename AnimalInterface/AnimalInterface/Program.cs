using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AnimalInterface.Animals
{
    class Program
    {
        static void Main(string[] args)
        {
            IAnimals[] animals = new IAnimals[] { new Bear(), new Chicken(), new Eagle()};

            //IAnimals eagle = new Eagle();
            //IAnimals chicken = new Chicken();
            //IAnimals bear = new Bear();
            //IAnimals[] animals = new IAnimals[] { eagle, chicken, bear };

            DoSomething(animals);
            Console.Read();

        }

        static void DoSomething(IAnimals[] ray)
        {
            foreach (Animals animal in ray)
            {
                Console.WriteLine("The " + animal.Name + " goes " + animal.MakeSound());
            }
        }
    }
}
