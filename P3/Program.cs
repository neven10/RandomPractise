using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(Check20(25));


            //int x = Convert.ToInt32(Console.ReadLine());
            //int y = Convert.ToInt32(Console.ReadLine());

            //if (x==y)
            //{
            //    Console.WriteLine(3*(x + y));
            //}
            //else
            //{
            //    Console.WriteLine((x + y));
            //}

            //{
            //    Console.WriteLine(SumTriple(2, 2));
            //    Console.WriteLine(SumTriple(12, 10));
            //    Console.WriteLine(SumTriple(-5, 2));
            //}
          
            Console.ReadLine();

        }

        static int SumTriple(int a, int b)
        {
            return a == b ? (a + b) * 3 : a + b;
        }

        static bool Check20(int a)
        {
            if (Math.Abs(a - 100) <= 10 || Math.Abs(a - 200) <= 10)
                return true;
            return false;
        }

    }


}

