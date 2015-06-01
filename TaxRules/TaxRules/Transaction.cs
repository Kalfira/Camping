using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxRules
{
    public class Transaction
    {
        public string fname { get; set; }
        public string lname { get; set; }
        public int age { get; set; }
        public DateTime date { get; set; }
        public double cost { get; set; }
        private double tax = 0.08;

        public Transaction(string name1, string name2, int howOld, DateTime time, double price)
        {
            fname = name1;
            lname = name2;
            age = howOld;
            date = time;
            cost = price;
        }

        public double Calculate()
        {
            if (date.DayOfWeek == DayOfWeek.Thursday)
            {
                tax = tax*2;
            }
            if (fname.ToLower().First() == 'j')
            {
                tax = tax*2;
            }
            if (age<5)
            {
                tax = 0;
            }
            if (lname.ToLower().First() == 'w' && !(cost*tax < 1))
            {
                return (tax * cost) - 1;
            }
            else
            {
                return tax*cost;
            }
        }

        

    }
}
