using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetterTryParse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting Parse Tests");

            int? x = TryParseAsInt("89898");
            Debug.Assert(x == 89898);

            int? y =TryParseAsInt("I am not a number");
            Debug.Assert(y == null);

            int? z = TryParseAsInt("6.5");
            Debug.Assert(z == null);

            Console.Read();
        }

        static int? TryParseAsInt(string val)
        {
            try
            {
                return int.Parse(val);
            }
            catch
            {

            }
            return null;
        }
    }
}
