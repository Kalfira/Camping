using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxRules
{
    public class Transaction
    {
        public string Fname { get; set; }
        public string Lname { get; set; }
        public int Age { get; set; }
        public DateTime Date { get; set; }
        public double Cost { get; set; }
        private double _tax = 0.08;

        public Transaction(string name1, string name2, int howOld, DateTime time, double price)
        {
            Fname = name1;
            Lname = name2;
            Age = howOld;
            Date = time;
            Cost = price;
        }

        public double Calculate()
        {
            if (Date.DayOfWeek == DayOfWeek.Thursday)
            {
                _tax = _tax*2;
            }
            if (Fname.ToLower().First() == 'j')
            {
                _tax = _tax*2;
            }
            if (Age<5)
            {
                _tax = 0;
            }
            if (Lname.ToLower().First() == 'w' && !(Cost*_tax < 1))
            {
                return (_tax * Cost) - 1;
            }
            else
            {
                return _tax*Cost;
            }
        }

        

    }
}
