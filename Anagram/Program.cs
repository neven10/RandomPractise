using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anagram
{
    class Program
    {
        static void Main(string[] args)
        {
            string one = "neven";
            string two = "neven";

            char[] arr1 = one.ToCharArray();
            char[] arr2 = two.ToCharArray();


            Array.Sort(arr1);
            Array.Sort(arr2);

            string one1 = new string(arr1);
            string two2 = new string(arr2);

            if (one1 == two2)
            {
                Console.WriteLine("Yep");
            }
            else { Console.WriteLine("Nope"); }

            Console.ReadLine();





        }
    }
}
