using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringFormatDouble
{
    class Program
    {
        static void Main(string[] args)
        {
            // Pattern 1: just two decimal places
            Console.WriteLine("**************************************");
            Console.WriteLine("Pattern 1: just two decimal places");
            Console.WriteLine("**************************************");
            Console.WriteLine(String.Format("{0:0.00}", 123.4567));      // "123.46"
            Console.WriteLine(String.Format("{0:0.00}", 123.4));         // "123.40"
            Console.WriteLine(String.Format("{0:0.00}", 123.0));         // "123.00"

            //Pattern 2: max. two decimal places
            Console.WriteLine("**************************************");
            Console.WriteLine("Pattern 2: max. two decimal places");
            Console.WriteLine("**************************************");
            Console.WriteLine(String.Format("{0:0.##}", 123.4567));      // "123.46"
            Console.WriteLine(String.Format("{0:0.##}", 123.4));         // "123.4"
            Console.WriteLine(String.Format("{0:0.##}", 123.0));         // "123"

            //Pattern 3: at least two digits before decimal point
            Console.WriteLine("***************************************************");
            Console.WriteLine("Pattern 3: at least two digits before decimal point");
            Console.WriteLine("***************************************************");
            Console.WriteLine(String.Format("{0:00.0}", 123.4567));      // "123.5"
            Console.WriteLine(String.Format("{0:00.0}", 23.4567));       // "23.5"
            Console.WriteLine(String.Format("{0:00.0}", 3.4567));        // "03.5"
            Console.WriteLine(String.Format("{0:00.0}", -3.4567));       // "-03.5"

            //Pattern 4: Thousand Separators
            Console.WriteLine("**************************************");
            Console.WriteLine("Pattern 4: Thousand Separators");
            Console.WriteLine("**************************************");
            Console.WriteLine(String.Format("{0:0,0.0}", 12345.67));     // "12,345.7"
            Console.WriteLine(String.Format("{0:0,0}", 12345.67));       // "12,346"

            //Pattern 5: Align Number with spaces
            Console.WriteLine("**************************************");
            Console.WriteLine("Pattern 5: Align Number with spaces");
            Console.WriteLine("**************************************");
            Console.WriteLine(String.Format("{0,10:0.0}", 123.4567));    // "     123.5"
            Console.WriteLine(String.Format("{0,-10:0.0}", 123.4567));   // "123.5     "
            Console.WriteLine(String.Format("{0,10:0.0}", -123.4567));   // "    -123.5"
            Console.WriteLine(String.Format("{0,-10:0.0}", -123.4567));  // "-123.5    "

            //Pattern 6: Numbers between zero and one
            Console.WriteLine("**************************************");
            Console.WriteLine("Pattern 6: Numbers between zero and one");
            Console.WriteLine("**************************************");
            Console.WriteLine(String.Format("{0:0.0}", 0.0));            // "0.0"
            Console.WriteLine(String.Format("{0:0.#}", 0.0));            // "0"
            Console.WriteLine(String.Format("{0:#.0}", 0.0));            // ".0"
            Console.WriteLine(String.Format("{0:#.#}", 0.0));            // ""     

            //Pattern 7: Custom formatting for negative numbers and zero
            Console.WriteLine("**********************************************************");
            Console.WriteLine("Pattern 7: Custom formatting for negative numbers and zero");
            Console.WriteLine("**********************************************************");
            Console.WriteLine(String.Format("{0:0.00;minus 0.00;zero}", 123.4567));   // "123.46"
            Console.WriteLine(String.Format("{0:0.00;minus 0.00;zero}", -123.4567));  // "minus 123.46"
            Console.WriteLine(String.Format("{0:0.00;minus 0.00;zero}", 0.0));        // "zero"
        }
    }
}
