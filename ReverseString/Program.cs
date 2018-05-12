using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SimpleWay("asdfg"));
            Console.WriteLine(WayFaster("asdfg"));


            Console.ReadLine();
        }

        public static string SimpleWay(string s)
        {
            char[] array = s.ToCharArray();
            Array.Reverse(array);
            return new string(array);
        }

        public static string WayFaster(string s)
        {
            char[] array = new char[s.Length];
            int ii = 0;
            for(int i=s.Length-1; i>=0;i--)
            {
                array[ii++] = s[i];
            }
            return new string(array);
        }
    }
}
