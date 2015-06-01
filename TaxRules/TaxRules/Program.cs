using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxRules
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your first name:");
            string fname = Console.ReadLine();
            Console.WriteLine("Enter your last name:");
            string lname = Console.ReadLine();
            Console.WriteLine("Enter your age in years:");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the date you are shopping (MM/DD/YY format):");
            string rawDate = Console.ReadLine();
            DateTime dt = DateTime.Parse(rawDate);
            Console.WriteLine("Enter the price of your item:");
            double cost = Convert.ToDouble(Console.ReadLine());
            Transaction trans = new Transaction(fname, lname,age, dt, cost);
            Console.WriteLine("Your effective tax on {0} for {1} {2} who is {3} years old is {4:C}", rawDate, fname, lname, age, trans.Calculate());
            Console.WriteLine("This totals to a final amount of {0:C} . Thank you for shopping with us!", trans.Calculate()+cost );
            Console.Read();
        }
    }
}
