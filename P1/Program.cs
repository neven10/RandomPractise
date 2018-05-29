using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1
{
    class Program
    {

        static int n;

        static void Main(string[] args)
        {
            n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < 5; i++)
            {
                x();

            }

            for (int g=0; g<=3;g++)
            {
                a();
                for (int t = 0; t <= 2; t++) 
                {
                    b();
                }
            }

            Console.ReadLine();

        }

        static void x()
        {
            Console.WriteLine("{0}, {0}, {0} \n{0},{0},{0}", n);
        }

        static void a()
        {
            Console.WriteLine("{0},{0},{0}", n);

        }
        static void b()
        {
            Console.WriteLine("{0},{0}", n);
        }
    }
}
