using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;

namespace P2
{
    class Program
    {
        
        static void Main(string[] args)
        {


            string s = "hippopotomonstrosesquippedaliophobia";

            for (int r = 1; r > 0; r++)
            {

                for (int i = s.Length; i >= 0; i--)
                {
                    Console.WriteLine(s.Remove(0, s.Length - i));
                    Thread.Sleep(20);
                }

                for (int e = 0; e <= s.Length; e++)
                {
                    Console.WriteLine(s.Remove(0, s.Length - e));
                    Thread.Sleep(20);
                }
            }
            


            Console.ReadLine();
        }
    }
}
